using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Services.Exceptions
{
    public class PedigreeServiceException : Exception
    {

        private const long serialVersionUID = 5748491972694207553L;

        public PedigreeServiceException(string esxMessage) : base(esxMessage)
        {
            
        }
    
        public PedigreeServiceException(string esxMessage, Exception eNestedException) : base(esxMessage, eNestedException)
        {
            
        }
    }

}
