

using Microsoft.AspNetCore.Identity;

namespace JWTBearerTokenExampleDal.Classes {
    public class UserInfo : IdentityUser {
        public virtual UserProfileInfo ProfileInformation { get; set; }

    }



}




