using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plans.API.Models
{
    public class UserConstants
    {
        public static List<UserModel> users = new List<UserModel>()
        {
            new UserModel(){ UserName = "Abdullah_Admin", EmailAddress="mustafabdullah1126@gmail.com",Password="1234",GivenName="Abdullah",Surname="Çağış",Role="Admin"},
            new UserModel(){ UserName = "Yusuf_Kullanici", EmailAddress="Yusuf@gmail.com",Password="1234",GivenName="Yusuf",Surname="Çağış",Role="Kullanici"}

        };
    }
}
