using ssoTest.Entity;

namespace ssoTest.Business
{
    public class GradeBusiness
    {
        public GradeResponse GetGradeResponse(string ssoToken,string ssoTokenName="SsoToken")
        {
            var adminUserId = ConfigHelper.GetUserForTheToken(ssoTokenName);

            var result = new GradeResponse { Result = "0000" };

            switch (ssoToken)
            {
                case GradeResultEnum.Gradeerror00000000000000:
                    result.Result="2050";
                    result.StatusCode = "400";
                    break;
                case GradeResultEnum.Invalid00000000000000000:
                    result.Result="0001";
                    result.StatusCode = "200";
                    break;
                case GradeResultEnum.Remotedberror00000000000:
                    result.Result = "9999";
                    result.StatusCode = "500";
                    break;
                case GradeResultEnum.Remotesvcerror0000000000:
                    result.Result = "9910";
                    result.StatusCode = "500";
                    break;
                case GradeResultEnum.Svcunavailable0000000000:
                    result.Result="";
                    result.StatusCode = "503";
                    break;
                case GradeResultEnum.Unknown00000000000000000:
                    result.Result = "1040";
                    result.StatusCode = "400";
                    break;
                case GradeResultEnum.Valid0000000000000000000:
                    result.Result="0000";
                    result.StatusCode = "200";
                    result.AdminUserId = adminUserId;
                    break;
            }

            return result;
        }
    }
}