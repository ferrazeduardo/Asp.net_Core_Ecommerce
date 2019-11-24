using System;
using System.Collections.Generic;
using System.Linq;
using Ecommerce.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce.ViewModels;

namespace Ecommerce.Models
{
    /*modelo para o carrinho de compra */
    public class Carrinho
    {
        private readonly AppDbContext _context;
        public Carrinho(AppDbContext context)
        {
            _context=context;
        }
        public Carrinho(string carrinhoId) 
        {
            this.CarrinhoId = carrinhoId;
        
        }
        public string CarrinhoId { get; set; }//hash de identificação do carrinho

        public List<ProdutoCarrinho> ProdutosCarrinho { get; set; }//lista para adicionar os itens

        public IEnumerable<ProdutoCarrinho> produtos { get; set; }

        /*obter a sessão */
        public static Carrinho GetCarrinho(IServiceProvider services)
        {
            ISession session = 
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; 

            var context = services.GetService<AppDbContext>();

            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            session.SetString("CarrinhoId",carrinhoId);

            return new Carrinho(context){
                CarrinhoId=carrinhoId
            };
        }
        /*metodo para adiconar um item ao carrinho */
        public void AdicionarAoCarrinho(Produto produto,int quantidade){
            var produtoCarrinho = 
                _context.ProdutosCarrinho.SingleOrDefault(
                    s=>s.Produto.ProdutoId ==  produto.ProdutoId && s.CarrinhoId == CarrinhoId
                );

            if(produtoCarrinho==null){
                produtoCarrinho = new ProdutoCarrinho{
                    CarrinhoId=CarrinhoId,
                    Produto = produto,
                    Quantidade = 1
                };
                _context.ProdutosCarrinho.Add(produtoCarrinho);
            }

            _context.SaveChanges();
        }
        /*funçaõ para remover um item do carrinho */
        public int RemoverDoCarrinho(Produto produto){

            var produtoCarrinho=
                _context.ProdutosCarrinho.SingleOrDefault(
                    s=>s.Produto.ProdutoId == produto.ProdutoId && s.CarrinhoId == CarrinhoId
                );
            
            var quantidadeLocal = 0;

            if(produtoCarrinho!=null){
                
                if(produtoCarrinho.Quantidade>1){
                    
                    produtoCarrinho.Quantidade--;

                    quantidadeLocal = produtoCarrinho.Quantidade;
                }
                else{
                    _context.ProdutosCarrinho.Remove(produtoCarrinho);
                }
            }

            _context.SaveChanges();

            return quantidadeLocal;
        }
        /*Funçaõ para retornar todos os itens do carrinho */
        public List<ProdutoCarrinho> GetProdutosCarrinho(){
            
            return ProdutosCarrinho ?? 
                (ProdutosCarrinho=
                    _context.ProdutosCarrinho.Where(c=>c.CarrinhoId==CarrinhoId)
                    .Include(s=>s.Produto)
                    .ToList());
        }

        public void LimparCarrinho(){
            var produtoCarrinho = _context.ProdutosCarrinho
                .Where(c => c.CarrinhoId == CarrinhoId);

            _context.ProdutosCarrinho.RemoveRange(produtoCarrinho);

            _context.SaveChanges();
        }

        public decimal GetCarrinhoTotal()
        {
            var total = _context.ProdutosCarrinho.Where(c => c.CarrinhoId == CarrinhoId)
                .Select(c => c.Produto.Preco * c.Quantidade).Sum();

            return total;
        }

        public IEnumerable<ProdutoCarrinho> GetFinalizarCarrinho(List<Produto> Produtos){

            foreach(var produto in Produtos){
                produtos = _context.ProdutosCarrinho.Where(p => p.Produto.ProdutoId == produto.ProdutoId && p.CarrinhoId == CarrinhoId);
            }

            if(produtos != null){
                _context.ProdutosCarrinho.UpdateRange(produtos);
            }

            _context.SaveChanges();

            return _context.ProdutosCarrinho;
        }
    }
}