namespace APITeste.Domain.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Name { get; set; }
        public EnumPetSpecies species { get; set; }

        public virtual Client Client { get; set; }
    }
}
