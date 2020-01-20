using EPedigree.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;
using System.IO;

namespace EPedigree.Model.Services.SenderDataService

{
    public class SenderDataSvcImpl : ISenderDataService
    {
        /**
         * Sender's Data Service Implementation
         * Creates a new sender envelope data form at the request of the SenderDataManager.
         */

        public new void storeSenderData(SendersEnvelopeDataForm sendersEnvelopeData)
        {

            SendersEnvelopeDataForm sED1 = new SendersEnvelopeDataForm();

            try
            {
                Stream os = new System.IO.FileStream("senders1.obj", System.IO.FileMode.Create, System.IO.FileAccess.Write);
                os.Equals(sED1);
                os.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }

      
        } // end Senders Data Service

    }
}
	
		

