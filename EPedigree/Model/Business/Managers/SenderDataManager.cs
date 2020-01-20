using EPedigree.Model.Business.Factory;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.SenderDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Business.Managers
{
    public class SenderDataManager : ManagerSuperType
    {
        /**
         * @author Ish
         *
         * This Manager class uses the properties file provided by the SuperManagerType,
         * calls the ServiceFactory, and executes services requested by the presentation layer. 
         *
         *  It called to open, save, and close sender's data in envelope object. 
         *
         *
         */
    public SenderDataManager()
        {
            // construct object . . .
        }


        //Use Case Driven - support the construction of an envelope 
        public void helpSenderEnvelopeData(SendersEnvelopeDataForm sendersEnvelopeDataForm)
		    {

            ISenderDataService sendersDataSvc = (ISenderDataService)GetService(typeof(ISenderDataService).Name);
            sendersDataSvc.storeSenderData(sendersEnvelopeDataForm);
		    	    	

		    }//end helpSenderEnvelopeData

    }
}
