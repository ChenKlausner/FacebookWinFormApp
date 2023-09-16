using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class BusinessInfoBuilder : IInfoBuilder
    {
        public Info Info { get; set; }

        public BusinessInfoBuilder()
        {
            Info = new Info();
        }

        public void BuildInfoPacket1(User i_LoggedInUser)
        {
            Info.InfoPacket1.Label = "Email:";
            Info.InfoPacket1.Info = i_LoggedInUser.Email;
        }

        public void BuildInfoPacket2(User i_LoggedInUser)
        {
            Info.InfoPacket2.Label = "Gender:";
            Info.InfoPacket2.Info = i_LoggedInUser.Gender.ToString();
        }

        public void BuildInfoPacket3(User i_LoggedInUser)
        {
            Info.InfoPacket3.Label = "Work place:";
            Info.InfoPacket3.Info = i_LoggedInUser.WorkExperiences == null ? "Unemployed" :
                i_LoggedInUser.WorkExperiences[0].ToString();
        }

        public void BuildInfoPacket4(User i_LoggedInUser)
        {
            Info.InfoPacket4.Label = "Location:";
            Info.InfoPacket4.Info = i_LoggedInUser.Location.ToString();
        }
    }
}
