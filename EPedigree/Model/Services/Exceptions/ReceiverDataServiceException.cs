using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Services.Exceptions
{
    public class ReceiverDataServiceException : Exception
    {
        private const long serialVersionUID = -4378838238452875425L;

        public ReceiverDataServiceException(string esxMessage) : base(esxMessage)
        {
            
        }

        public ReceiverDataServiceException(string esxMessage, Exception eNestedException) : base(esxMessage, eNestedException)
        {
            
        }

    }

}
