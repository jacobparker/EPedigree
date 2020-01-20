using EPedigree.Model.Business.Factory;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.PedigreeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Business.Managers
{
    public class PedigreeManager : ManagerSuperType
    {
        /**
         * @author Ish
         *
         * This Manager class uses the properties file provided by the SuperManagerType,
         * calls the ServiceFactory, and executes services requested by the presentation layer. 
         *
         *  It called to create a new pedigree object.
         *
         *
         */
         public PedigreeManager()
        {
            // construct object . . .
        }


        //Use Case Driven - Adding new pedigree
        public void addNewPedigree(Pedigree pedigree)
		    {


            ServiceFactory serviceFactory = new ServiceFactory();
            IPedigreeService pedigreeSvc = (IPedigreeService)GetService(typeof(IPedigreeService).Name);
            pedigreeSvc.storePedigreeData(pedigree);
		    	
		    }//end addNewPedigree
    }
}
