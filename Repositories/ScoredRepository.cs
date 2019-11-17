using System.Linq;
using Ecommerce.Data;

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

            
            var score = _context.Scoreds.Where(s=>s.ProdutoId==ProdutoId)
                            .Select(s=>s.Score);

            int count1=0,count2=0,count3=0,count4=0,count5=0;
            int produto1=1,produto2=1,produto3=1,produto4=1,produto5=1;    
            foreach(var valor in score){
                if(valor == 1){
                    count1++;
                    produto1 = valor*count1;
                }
                if(valor == 2){
                    count2++;
                    produto2 = valor*count2;
                }
                if(valor == 3){
                    count3++;
                    produto3 = valor*count3;
                }
                if(valor == 4){
                    count4++;
                    produto4 = valor*count4;
                }
                if(valor == 5){
                    count5++;
                    produto5 = valor*count5;
                }
            }

            int v = (count1 + count2 + count3 + count4 + count5);
            return (produto1 + produto2 + produto3 + produto4 + produto5) / v;
        } 
    }
}