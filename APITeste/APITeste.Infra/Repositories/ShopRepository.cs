using APITeste.Domain.Models;
using APITeste.Infra.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace APITeste.Infra.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly List<Shop> shops;
        public ShopRepository(List<Shop> shops)
        {
            this.shops = shops;
        }
       
        public Shop Post(Shop shop)
        {
            shops.Add(shop);
            shop.Id = shops.Count;
            return shop;
        }

        public void Put(Shop shop)
        {
            shops.ForEach(e => {
                if (e.Id == shop.Id)
                {
                    e.Name = shop.Name;
                    return;
                }
            });
        }
        public IEnumerable<Shop> Get(Shop shop)
        {
            var result = shops.Where(w =>
                    (shop.Id == 0 || w.Id == shop.Id)
                    &&
                    (shop.Name == null || w.Name.ToUpper().Equals(shop.Name.ToUpper()))
                ).ToList();
            return result;
        }
        public void Delete(int Id)
        {
            shops.RemoveAll(r => r.Id == Id);
        }

    }
}
