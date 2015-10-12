using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ssoTest.Entity;

namespace ssoTest.Business
{
    public class GradeBusiness
    {
        public GradeResponse GetGradeResponse(string ssoToken)
        {
            var adminUserId = ConfigurationManager.AppSettings["AdminUserId"] ?? "p";

            var result = new GradeResponse { AdminUserId = adminUserId, Result = "0000" };

            switch (ssoToken)
            {
                case GradeResultEnum.Gradeerror00000000000000:
                    break;
                case GradeResultEnum.Invalid00000000000000000:
                    break;
                case GradeResultEnum.Remotedberror00000000000:
                    break;
                case GradeResultEnum.Remotesvcerror0000000000:
                    break;
                case GradeResultEnum.Svcunavailable0000000000:
                    break;
                case GradeResultEnum.Unknown00000000000000000:
                    break;
                case GradeResultEnum.Valid0000000000000000000:
                    break;
            }

            return result;
        }
    }
}