using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public static string AppId { get; } = "670188127876189";

		public static string[] Permissions { get; } = new string[]
		{
			"email",
			"public_profile",
			"user_age_range",
			"user_birthday",
			"user_events",
            "user_friends",
			"user_gender",
			"user_hometown",
			"user_likes",
			"user_link",
			"user_location",
			"user_photos",
			"user_posts",
			"user_videos"
		};

		public bool RememberUser { get; set; }

		public string LastAccessToken { get; set; }

		public AppSettings()
		{
			RememberUser = true;
			LastAccessToken = null;
		}

		public void SaveData(string i_FileName)
		{
			using (Stream stream = new FileStream(i_FileName, FileMode.Truncate))
			{
				XmlSerializer serializer = new XmlSerializer(this.GetType());

				serializer.Serialize(stream, this);
			}
		}

		public void LoadAppSettingsData(string i_FileName)
		{
			using (Stream stream = new FileStream(i_FileName, FileMode.Open))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
				AppSettings loaded = serializer.Deserialize(stream) as AppSettings;

				foreach (PropertyInfo currProperty in typeof(AppSettings).GetProperties())
				{
					if (!currProperty.GetMethod.IsStatic)
					{
						var value = currProperty.GetValue(loaded);

						currProperty.SetValue(this, value);
					}
				}
			}
		}
	}
}
