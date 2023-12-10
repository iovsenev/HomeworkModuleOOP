using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public class ProductsOnSale<TProduct> : Lists<TProduct> where TProduct : Product
    {
    }
}
