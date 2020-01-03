using APITeste.Domain.Models;
using System.Collections.Generic;

namespace APITeste.Infra.Interfaces
{
    public interface IShopRepository
    {
        Shop Post(Shop shop);
        void Put(Shop shop);
        IEnumerable<Shop> Get(Shop shop);
        void Delete(int Id);
    }
}
