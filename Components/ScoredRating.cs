using Microsoft.AspNetCore.Mvc;
using Ecommerce.Repositories; 

namespace Ecommerce.Components
{
    public class ScoredRating : ViewComponent
    {

        private readonly IScoredRepository _scoredRepository;

        public ClassName(IScoredRepository scoredRepository)
        {
            _scoredRepository=scoredRepository;
        }

        public IViewComponentResult Invoke(){
            return View();
        }
    }
}