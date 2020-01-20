using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Services.Exceptions
{
    public class EnvelopeServiceException : Exception
    {

        private const long serialVersionUID = 9172352070183292174L;

        public EnvelopeServiceException(string esxMessage) : base(esxMessage)
        {
            
        }
        public EnvelopeServiceException(string esxMessage, Exception eNestedException) : base(esxMessage, eNestedException)
        {
            
        }

    }
}
