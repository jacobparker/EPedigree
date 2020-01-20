using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Services.Exceptions
{
    public class ProductServiceException : Exception
    {

        private const long serialVersionUID = 7133082510771918407L;



        public ProductServiceException(String esxMessage) : base(esxMessage)
        {
        }


        public ProductServiceException(string esxMessage, Exception eNestedException) : base(esxMessage, eNestedException)
        {
            
        }
    }

}
