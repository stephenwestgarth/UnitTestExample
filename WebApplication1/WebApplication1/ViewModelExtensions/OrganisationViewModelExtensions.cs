using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModelExtensions
{
    public static class OrganisationViewModelExtensions
    {
        public static OrganisationViewModel ToViewModel(this OrganisationModel model)
        {
            return new OrganisationViewModel
            {
                Id = model.Id,
                OrganisationName = model.OrganisationName,
                Address = model.Address
            };
        }
    }
}