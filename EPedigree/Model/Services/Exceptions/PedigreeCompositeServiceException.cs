using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Services.Exceptions
{
    public class PedigreeCompositeServiceException : Exception
    {

        private const long serialVersionUID = 2423223608541848379L;

        public PedigreeCompositeServiceException(string esxMessage) : base(esxMessage)
        {
            
        }

        public PedigreeCompositeServiceException(string esxMessage, Exception eNestedException) : base(esxMessage, eNestedException)
        {
            
        }

    }

}
