using CazamioProgect.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.SideBarLandlord
{
    public partial class SideBarLandlord
    {
        public SideBarLandlord UploadImageLogoLandlordFirst()
        {
            WaitUntil.WaitSomeInterval(3000);
            ButtonUploadLogoOfLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.logoImgLandlordFirst));
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            return this;
        }

        public SideBarLandlord UploadImageLogoLandlordSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonUploadLogoOfLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.logoImgLandlordSecond));
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            return this;
        }

        public SideBarLandlord UploadImageAvatarUserLandlordFirst()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.avatarImgLandlordFirst));

            return this;
        }

        public SideBarLandlord UploadImageAvatarUserLandlordSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.avatarImgLandlordSecond));

            return this;
        }
    }
}
