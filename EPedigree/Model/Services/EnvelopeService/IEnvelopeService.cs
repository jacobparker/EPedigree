using EPedigree.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;

namespace EPedigree.Model.Services.EnvelopeService
{
    public class IEnvelopeService
    {

        /** 
         * Create an envelope object 
         * @param Envelope should hold user data captured from the sender's and reciever's sub-forms to create an envelope object. 
         * @throws EnvelopeServiceException If the Envelope object is null or is not found 
         * 
         * */

        public void createEnvelopeData(Envelope envelope)
        {
            if (envelope == null) throw new ArgumentNullException();
        }

    }
}
