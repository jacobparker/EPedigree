using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Services.Exceptions
{
    public class SenderDataServiceException : Exception
    {
        private const long serialVersionUID = -6963481377929219358L;

        public SenderDataServiceException(string esxMessage) : base(esxMessage)
        {
            
        }

        public SenderDataServiceException(string esxMessage, Exception eNestedException) : base(esxMessage, eNestedException)
        {
            
        }
    }
}
