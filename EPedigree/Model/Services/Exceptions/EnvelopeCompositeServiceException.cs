using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Services.Exceptions;

namespace EPedigree.Model.Services.Exceptions
{
    public class EnvelopeCompositeServiceException : Exception
    {

    private const long serialVersionUID = 287802666559509882L;

        public EnvelopeCompositeServiceException(string esxMessage) : base(esxMessage)
        {
            
        }


        public EnvelopeCompositeServiceException(string esxMessage, Exception eNestedException) : base(esxMessage, eNestedException)
        {
            
        }

    }


}
    

