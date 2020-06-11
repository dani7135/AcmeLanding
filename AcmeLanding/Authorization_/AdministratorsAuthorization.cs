using ClassLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Threading.Tasks;

namespace AcmeLanding.Authorization_.Authorization
{
    public class AdministratorsAuthorization : AuthorizationHandler<OperationAuthorizationRequirement, Submission_Model>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Submission_Model resource)
        {
            if (context.User == null)
            {
                return Task.CompletedTask;
            }
            /* if (context.User.IsInRole(Constants.ContactAdministratorsRole))
             {
                 context.Succeed(requirement);
             }*/
            return Task.CompletedTask;
        }
    }
}
