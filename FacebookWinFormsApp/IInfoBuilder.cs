namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection.Emit;
    using System.Text;
    using System.Threading.Tasks;
    using FacebookWrapper.ObjectModel;

    internal interface IInfoBuilder
    {
        Info Info { get; set; }

        void BuildInfoPacket1(User i_LoggedInUser);

        void BuildInfoPacket2(User i_LoggedInUser);

        void BuildInfoPacket3(User i_LoggedInUser);

        void BuildInfoPacket4(User i_LoggedInUser);
    }
}