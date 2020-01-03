using System.Collections.Generic;

namespace APITeste.Domain.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SocialNumber { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
