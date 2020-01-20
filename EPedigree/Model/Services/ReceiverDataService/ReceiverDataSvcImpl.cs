using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;
using System.IO;

namespace EPedigree.Model.Services.ReceiverDataService
{
    public class ReceiverDataSvcImpl : IReceiverDataService
    {
        /**
         * Receiver's Data Service Implementation
         * Creates a new receiver envelope data form at the request of the ReceiverDataManager.
         *  
         */

        public new bool storeReceiverEnvelopeDataForm(ReceiversEnvelopeDataForm receiversEnvelopeDataForm)
        {

            bool isGood = false;

            ReceiversEnvelopeDataForm rED1 = new ReceiversEnvelopeDataForm();

            try
            {
                Stream os = new System.IO.FileStream("receiver1.obj", System.IO.FileMode.Create, System.IO.FileAccess.Write);
                os.Equals(rED1);
                os.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }

            return isGood;
        } // end Receiver's Data Service
    }


}
