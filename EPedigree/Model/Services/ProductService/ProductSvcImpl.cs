using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;
using System.IO;

namespace EPedigree.Model.Services.ProductService
{
    public class ProductSvcImpl : IProductService
    {

        /**
         * Product Service Implementation
         * Creates a new product object at the request of ProductManager.
         *
         */


        public new void storeProductData(Product product)
        {

            Product pDT1 = new Product();

            try
            {
                Stream os = new System.IO.FileStream("product1.obj", System.IO.FileMode.Create, System.IO.FileAccess.Write);
                os.Equals(pDT1);
                os.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }

           
        } // end Product Service

    }


}