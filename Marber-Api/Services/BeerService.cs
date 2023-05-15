using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BeerService
    {
        public List<Beer> GetListBeer()
        {
            var listBeer = new List<Beer>();
            for (int i = 0; i < 30; i++)
            {
                listBeer.Add(new Beer
                {
                    Id = i,
                    BeerName = $"Beer {i}",
                    BeerStyle = $"Style {i}",
                    BeerPrice = "30"
                });
            }

            return listBeer;
        }

        //public Beer GetBeerById(int id)
        //{
        //    var listBeer = new List<Beer>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        listBeer.Add(new Beer
        //        {
        //            IdBeer = i,
        //            NameBeer = $"Beer {i}",
        //            StyleBeer = $"Style {i}",
        //            DescriptionBeer = $"Descripcion {i}",
        //            ContainerdBeer = $"Envase {i}",
        //            PriceBeer = i * 0.50
        //        });
        //    }

        //    Beer beerById = listBeer.Where(x => x.IdBeer == id).First();
        //    return beerById;
        //}

        //public List<Beer> AddBeer(Beer beer)
        //{
        //    var listBeer = new List<Beer>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        listBeer.Add(new Beer
        //        {
        //            IdBeer = i,
        //            NameBeer = $"Beer {i}",
        //            StyleBeer = $"Style {i}",
        //            DescriptionBeer = $"Descripcion {i}",
        //            ContainerdBeer = $"Envase {i}",
        //            PriceBeer = i * 0.50
        //        });
        //    }

        //    listBeer.Add(beer);
        //    return listBeer;
        //}

        //public List<Beer> ModifyBeer(int id, Beer beer)
        //{
        //    var listBeer = new List<Beer>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        listBeer.Add(new Beer
        //        {
        //            IdBeer = i,
        //            NameBeer = $"Beer {i}",
        //            StyleBeer = $"Style {i}",
        //            DescriptionBeer = $"Descripcion {i}",
        //            ContainerdBeer = $"Envase {i}",
        //            PriceBeer = i * 0.50
        //        });
        //    }

        //    foreach (var _beer in listBeer)
        //    {
        //        if (_beer.IdBeer == id)
        //        {
        //            _beer.IdBeer = beer.IdBeer;
        //            _beer.NameBeer = beer.NameBeer;
        //            _beer.StyleBeer = beer.StyleBeer;
        //            _beer.DescriptionBeer = beer.DescriptionBeer;
        //            _beer.ContainerdBeer = beer.ContainerdBeer;
        //            _beer.PriceBeer = beer.PriceBeer;
        //        }
        //    }

        //    return listBeer;
        //}

        //public List<Beer> DeleteBeerById(int id)
        //{
        //    var listBeer = new List<Beer>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        listBeer.Add(new Beer
        //        {
        //            IdBeer = i,
        //            NameBeer = $"Beer {i}",
        //            StyleBeer = $"Style {i}",
        //            DescriptionBeer = $"Descripcion {i}",
        //            ContainerdBeer = $"Envase {i}",
        //            PriceBeer = i * 0.50
        //        });
        //    }

        //    var beerToDelete = listBeer.Where(x => x.IdBeer == id).First();
        //    listBeer.Remove(beerToDelete);
        //    return listBeer;
        //}
    }
}
