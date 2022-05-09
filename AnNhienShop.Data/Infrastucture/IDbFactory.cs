using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnNhienShop.Data.Infrastucture
{
    public interface IDbFactory : IDisposable
    {
        AnNhienShopDbContext Init();
    }
}
