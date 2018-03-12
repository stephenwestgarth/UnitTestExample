using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    public class OrganisationLogic : LogicRepository<OrganisationModel>
    {
        public OrganisationLogic()
        {

        }

        public override OrganisationModel GetOrganisation()
        {

            return new OrganisationModel { Id = 1, OrganisationName = "My Orgaisation", Address = "Logic" };
            
        }

    }
}
