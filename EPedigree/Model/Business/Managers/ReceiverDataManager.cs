using EPedigree.Model.Business.Factory;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.ReceiverDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Business.Managers
{
    public class ReceiverDataManager : ManagerSuperType
    {

        /**
         * @author Ish
         *
         * This Manager class uses the properties file provided by the SuperManagerType,
         * calls the ServiceFactory, and executes services requested by the presentation layer. 
         *
         *  It called to open, save, and close receiver data in an envelope. 
         *
         *
         */

    public ReceiverDataManager()
        {
            // construct object . . .
        }


        //Use Case Driven - support the construction of an envelope 
        public void helpReceiverEnvelopeData(ReceiversEnvelopeDataForm receiversEnvelopeDataForm)
		    {

            ServiceFactory serviceFactory = new ServiceFactory();
            IReceiverDataService receiversDataSvc = (IReceiverDataService)GetService(typeof(IReceiverDataService).Name);
            receiversDataSvc.storeReceiverEnvelopeDataForm(receiversEnvelopeDataForm);


		    }//end helpReceiverEnvelopeData
    }
}
