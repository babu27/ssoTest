using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace ssoTest
{
    public class ConfigHelper
    {
        

        public static NameValueCollection GetUserAndTokens()
        {
            var tokens = ConfigurationManager.AppSettings["TokenNameAndAdminUserId"];
            var tokenAndUsers = tokens == null ? null : tokens.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (tokenAndUsers == null) return null;

            var collection=new NameValueCollection();

            foreach (var userAndToken in tokenAndUsers)
            {
                var userAndTokenAry = userAndToken.Split("#".ToCharArray());
                if(userAndTokenAry.Length==2)

                collection.Add(userAndTokenAry[0],userAndTokenAry[1]);
            }

            return collection;
        }

        public static bool IsUserExistsForTheToken(string incomingToken)
        {
            var allTokens = GetUserAndTokens();
            return (allTokens != null && allTokens.AllKeys.Contains(incomingToken));
        }

        public static string GetUserForTheToken(string token)
        {
            if (IsUserExistsForTheToken(token))
            {
                var allToken = GetUserAndTokens();
                return allToken[token];
            }

            return string.Empty;
        }

        public static bool IsValidToken(string token)
        {
            return GetUserAndTokens().AllKeys.Contains(token);
        }
    }

    
}