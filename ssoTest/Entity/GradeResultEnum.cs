using System.Configuration;

namespace ssoTest.Entity
{
    public static class GradeResultEnum
    {
        public const string Valid0000000000000000000 = "valid0000000000000000000";
        public const string Unknown00000000000000000 = "unknown00000000000000000";
        public const string Invalid00000000000000000 = "invalid00000000000000000";
        public const string Gradeerror00000000000000 = "gradeerror00000000000000";
        public const string Remotedberror00000000000 = "remotedberror00000000000";
        public const string Remotesvcerror0000000000 = "remotesvcerror0000000000";
        public const string Svcunavailable0000000000 = "svcunavailable0000000000";
        public const string ValidUrlEscaped000000000 = "valid++00000000000000000";

    }

    public static class Grade
    {
        public static string TokenName
        {
            get { return ConfigurationManager.AppSettings["TokenName"] ?? "SsoToken"; }
        }
    }
}


