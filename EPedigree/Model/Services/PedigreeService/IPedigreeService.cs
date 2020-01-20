using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;

namespace EPedigree.Model.Services.PedigreeService
{ 
    public class IPedigreeService : IService
{

    /** 
     * Create an pedigree object 
     * @param Pedigree
     * 							captures information  from the manufacturer to create a pedigree object. 
     * @throws PedigreeServiceException
     *  
     * 							If the Pedigree object is null or is not found 
     * 
     * */


    public String NAME = "IPedigreeService";

        public void storePedigreeData(Pedigree pedigree)
        {
            if (pedigree == null) throw new ArgumentNullException();
        }
    }


}

