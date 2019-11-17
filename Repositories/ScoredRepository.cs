using System.Linq;
using Ecommerce.Data;
// using MySql.Data.MySqlClient;

namespace Ecommerce.Repositories
{
    public class ScoredRepository : IScoredRepository
    {
         private readonly AppDbContext _context;

         public ScoredRepository(AppDbContext context)
         {
             _context=context;
         }

        public int GetScored(int ProdutoId){

            // MySqlConnection conexao = new MySqlConnection("server=localhost;database=Ecommerce;User id=root;password=123456");
            // MySqlCommand comando = new MySqlCommand("SELECT * FROM SCOREDS",conexao);
            // var tabela = new MySqlDataAdapter();

            var somaValor = _context.Scoreds.Where(s=>s.ProdutoId==ProdutoId);

            var soma = 0;
            foreach(var valor in somaValor){

                soma = soma + valor.Score;

            }

            return soma;
        } 
    }
}