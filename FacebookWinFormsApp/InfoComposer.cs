namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FacebookWrapper.ObjectModel;

    internal class InfoComposer
    {
        public IInfoBuilder InfoBuilder { get; set; }

        public void ConstructInfoPackets(User i_LoggedInUser)
        {
            InfoBuilder.BuildInfoPacket1(i_LoggedInUser);
            InfoBuilder.BuildInfoPacket2(i_LoggedInUser);
            InfoBuilder.BuildInfoPacket3(i_LoggedInUser);
            InfoBuilder.BuildInfoPacket4(i_LoggedInUser);
        }
    }
}
