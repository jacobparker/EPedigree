using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;

namespace EPedigree.Model.Services.ProductService
{
    public class IProductService : IService
    {

        /** 
         * Create an product object 
         * @param Product
         * 							captures information from manufacturer  to create a product object. 
         * @throws ProductServiceException
         *  
         * 							If the Product object is null or is not found 
         * 
         * */

        public String NAME = "IProductService";

	    public void storeProductData(Product product)
            {
                if (product == null) throw new ArgumentNullException();
         }
    }

}

