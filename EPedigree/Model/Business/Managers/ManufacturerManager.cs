using EPedigree.Model.Business.Factory;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.ManufacturerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Business.Managers
{
    public class ManufacturerManager : ManagerSuperType
    {

        /**
         * @author Ish
         *
         * This Manager class uses the properties file provided by the SuperManagerType,
         * calls the ServiceFactory, and executes services requested by the presentation layer. 
         *
         *  It called to create a manufacturer's working directory and manufacturer profile object. 
         *
         *
         */

    public ManufacturerManager()
        {
            // construct object . . .
        }


        //Use Case Driven - Adding new manufacturer 
        public void addNewManufacturer(Manufacturer manufacturer)
		    {


            ServiceFactory serviceFactory = new ServiceFactory();
            IManufacturerService manufacturerSvc = (IManufacturerService)GetService(typeof(IManufacturerService).Name);
            manufacturerSvc.createMfgrProfile(manufacturer);

		    }//end addNewManufacturer

    }
}
