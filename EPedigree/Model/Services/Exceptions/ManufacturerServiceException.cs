using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Services.Exceptions
{
    public class ManufacturerServiceException : Exception
    {

        private const long serialVersionUID = -577548794145979010L;

        public ManufacturerServiceException(string esxMessage) : base(esxMessage)
        {

            
        }


        public ManufacturerServiceException(string esxMessage, Exception eNestedException) : base(esxMessage, eNestedException)
        {
            
        }

    }

}

