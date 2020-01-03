# NETCore-CRUD-APITeste
Desafio de implementação de CRUD para uma web API em .NET Core 2.2.

## DESCRIÇÃO

A solução apresenta o padrão DDD (Domain Driven Design) e é composta por 3 camadas: API, Domain e Infra.  
A camada API é responsável por receber as requisições e devolver os resultados.  
A camada Domain mantém as classes das entidades que representam as tabelas do banco de dados.  
A camada Infra realiza as operações de regra de negócio.

## OBJETIVO

Implementar um sistema de CRUD de PetShop contendo lojas, clientes e pets.  

## REGRAS

- Uma loja pode ter vários clientes e um cliente pode ter várias lojas. Esta relação é representada pela entidade ShopClient.  
- Um cliente pode ter vários pets, mas um pet só pode pertencer a um cliente.  
- Deve-se criar classes de Controller, Interface e Repository para as entidades Client, Pet e ShopClient, baseando-se na estrutura definida para a entidade Shop.  
- O repositório da entidade ShopClient deverá ter apenas Post, Get e Delete, pois ela serve apenas para relacionar o ID do cliente com o da loja.
- No exemplo abaixo, o método Get do repositório da entidade Shop filtra por todos os atributos, mas permite que não sejam informados pelo usuário. Nessa condição, os atributos numéricos terão o valor 0 e os do tipo String terão o valor null. O mesmo deve ser aplicado às demais entidades.

	public IEnumerable<Shop> Get(Shop shop)
	{
		var result = shops.Where(w =>
				(shop.Id == 0 || w.Id == shop.Id)
				&&
				(shop.Name == null || w.Name.ToUpper().Equals(shop.Name.ToUpper()))
			).ToList();
		return result;
	}
