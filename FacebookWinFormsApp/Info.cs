namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Info
    {
        public class InfoPacket
        {
            public string Label { get; set; }

            public string Info { get; set; }
        }

        public Info()
        {
            InfoPacket1 = new InfoPacket();
            InfoPacket2 = new InfoPacket();
            InfoPacket3 = new InfoPacket();
            InfoPacket4 = new InfoPacket();
        }

        public InfoPacket InfoPacket1 { get; set; }

        public InfoPacket InfoPacket2 { get; set; }

        public InfoPacket InfoPacket3 { get; set; }

        public InfoPacket InfoPacket4 { get; set; }
    }
}
