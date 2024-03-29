using Microsoft.AspNetCore.Mvc;
using Ecommerce.Repositories; 
using Ecommerce.ViewModels;

namespace Ecommerce.Components
{
    public class ScoredRating : ViewComponent
    {

        private readonly IScoredRepository _scoredRepository;

        public ScoredRating(IScoredRepository scoredRepository)
        {
            _scoredRepository=scoredRepository;
        }

        public IViewComponentResult Invoke(int ProdutoId){

            var somaScored = _scoredRepository.GetScored(ProdutoId);

            var scoredViewModel = new ScoredViewModel{
                Scored = somaScored
            };

            return View(scoredViewModel);
        }
    }
}