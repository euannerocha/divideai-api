using Microsoft.EntityFrameworkCore;

namespace divideai.ApiService.Model{
    public class DivideAiContext: DbContext{
        public DbSet<Pessoa> Pessoas {get; set;}

        public DivideAiContext (DbContextOptions options) : base(options){
            
        }
    }
}