namespace BasicFacebookFeatures
{
    using FacebookWrapper;

    internal class FacebookFacade
    {
        public LoginResult Login(string appId, string[] permissions)
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            return FacebookWrapper.FacebookService.Login(appId, permissions);
        }

        public LoginResult Connect(string accessToken)
        {
            return FacebookWrapper.FacebookService.Connect(accessToken);
        }
    }
}