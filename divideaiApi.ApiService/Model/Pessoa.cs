using System.ComponentModel.DataAnnotations;

namespace divideai.ApiService.Model{
    public class Pessoa{
        [Key]
        public int IdPessoa {get; set;}
        public string Nome {get; set;}
    }
}