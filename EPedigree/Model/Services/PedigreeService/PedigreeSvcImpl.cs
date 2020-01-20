using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;
using System.IO;

namespace EPedigree.Model.Services.PedigreeService
{ 
    public class PedigreeSvcImpl : IPedigreeService
{
        /**
         * Pedigree Service Implementation
         * Creates a new pedigree object at the request of PedigreeManager.
         *  
         *
         */

        public new void storePedigreeData(Pedigree pedigree)
        {

            Pedigree pED1 = new Pedigree();

            try
            {
                Stream os = new System.IO.FileStream("pedigree1.obj", System.IO.FileMode.Create, System.IO.FileAccess.Write); ;
                os.Equals(pED1);
                os.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }

          
        } // end Pedigree Service

    }

}

