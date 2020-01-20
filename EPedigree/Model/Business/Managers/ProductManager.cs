using EPedigree.Model.Business.Factory;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Business.Managers
{
    public class ProductManager : ManagerSuperType
    {
        /**
         * @author Ish
         *
         * This Manager class uses the properties file provided by the SuperManagerType,
         * calls the ServiceFactory, and executes services requested by the presentation layer. 
         *
         *  It called to create a new product object.
         *
         *
         */
     public ProductManager()
        {
            // construct object . . .
        }


        //Use Case Driven - Adding new envelope
        public void addNewProduct(Product product)
        {

        ServiceFactory serviceFactory = new ServiceFactory();
        IProductService productSvc = (IProductService)GetService(typeof(IProductService).Name);
        productSvc.storeProductData(product);

	    }//end addNewProduct
    }
}
