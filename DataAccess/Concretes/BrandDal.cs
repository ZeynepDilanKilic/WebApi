using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class BrandDal : IBrandDal
{
    List<Brand> brands;

    public BrandDal()
    {
        brands = new List<Brand>();
        brands.Add(new Brand { Id = 1, Name = "BMW", CreatedDate = DateTime.Now });
        brands.Add(new Brand { Id = 2, Name = "Mercedes", CreatedDate = DateTime.Now });
        brands.Add(new Brand { Id = 3, Name = "Alfa Romeo", CreatedDate = DateTime.Now });
    }

    public void Add(Brand brand)
    {
        brands.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return brands;
    }
}
