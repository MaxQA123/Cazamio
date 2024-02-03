using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowPetPolicies
{
    public partial class ModalWindowPetPolicies
    {
        [AllureStep("SelectAllItems")]
        public ModalWindowPetPolicies SelectAllItems()
        {
            Pages.ModalWindowPetPolicies
                .SelectItemPetPolocies(ItemsPetPolicies.CASE_BY_CASE)
                .SelectItemPetPolocies(ItemsPetPolicies.PETS_FEE)
                .SelectItemPetPolocies(ItemsPetPolicies.ALL_PETS_ALLOWED)
                .SelectItemPetPolocies(ItemsPetPolicies.SMALL_PETS_ALLOWED)
                .SelectItemPetPolocies(ItemsPetPolicies.CATS_ONLY)
                .SelectItemPetPolocies(ItemsPetPolicies.PETS_FEE);

            return this;
        }
    }
}
