using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;


namespace EPedigree.Model.Services.SenderDataService
{ 
    public class ISenderDataService
{

    /** 
     * Create a receiver's envelope object 
     * @param ReceiversForm
     * 							holds user data captured from the reciever's envelope section to construct an envelope object. 
     * @throws ReceiverDataServiceException
     *  
     * 							If the ReceiversForm object is null or is not found 
     * 
     * */

    public readonly string NAME = "ISendersDataService";

    public void storeSenderData(SendersEnvelopeDataForm sendersEnvelopeData)
        {
            if (sendersEnvelopeData == null) throw new ArgumentNullException();
        }


}


}
