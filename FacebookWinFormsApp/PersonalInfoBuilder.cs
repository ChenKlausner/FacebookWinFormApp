using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PersonalInfoBuilder : IInfoBuilder
    {
        public Info Info { get; set; }

        public PersonalInfoBuilder()
        {
            Info = new Info();
        }

        public void BuildInfoPacket1(User i_LoggedInUser)
        {
            Info.InfoPacket1.Label = "Birthday:";
            Info.InfoPacket1.Info = i_LoggedInUser.Birthday;
        }

        public void BuildInfoPacket2(User i_LoggedInUser)
        {
            Info.InfoPacket2.Label = "Hometown:";
            Info.InfoPacket2.Info = i_LoggedInUser.Hometown == null ? "Tel-Aviv" :
                i_LoggedInUser.Hometown.ToString();
        }

        public void BuildInfoPacket3(User i_LoggedInUser)
        {
            Info.InfoPacket3.Label = "Religion:";
            Info.InfoPacket3.Info = i_LoggedInUser.Religion == null ? "Judaism" :
                i_LoggedInUser.Religion.ToString();
        }

        public void BuildInfoPacket4(User i_LoggedInUser)
        {
            Info.InfoPacket4.Label = "Nickname:";
            Info.InfoPacket4.Info = i_LoggedInUser.ShortName == null ? "Ahi" :
                i_LoggedInUser.ShortName.ToString();
        }
    }
}
