using Microsoft.AspNetCore.Mvc;
using Ecommerce.Repositories;
using Ecommerce.ViewModels;

namespace Ecommerce.Components
{
    public class MenuCategoria : ViewComponent 
    {

        private readonly ICategoriaRepository _categoriaRepository;

        public MenuCategoria(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository=categoriaRepository;
        }

        public IViewComponentResult Invoke(){

            var produtoViewModel = new ProdutoViewModel{
                Categorias = _categoriaRepository.Categorias
            };

            return View(model: produtoViewModel);

        }
    }
}