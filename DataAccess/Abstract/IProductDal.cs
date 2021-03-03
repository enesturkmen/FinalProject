using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface metotlar publictir ancak interface in kendisi public degildir
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}
