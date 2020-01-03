namespace APITeste.Domain.Models
{
    public class ShopClient
    {
        public int IdShop { get; set; }
        public int IdClient { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual Client Client { get; set; }
    }
}
