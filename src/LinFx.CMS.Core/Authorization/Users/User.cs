using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Authorization.Users;
using Abp.Extensions;
using LinFx.CMS.Utils;

namespace LinFx.CMS.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123456";

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long Id { get; set; }

        public static long CreateNewId()
        {
            return IDUtils.GenerateId();
        }

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            //var user = new User
            //{
            //    TenantId = tenantId,
            //    UserName = AdminUserName,
            //    Name = AdminUserName,
            //    Surname = AdminUserName,
            //    EmailAddress = emailAddress
            //};

            var user = new User
            {
                TenantId = tenantId,
                UserName = emailAddress,
                Name = emailAddress,
                Surname = emailAddress,
                EmailAddress = emailAddress
            };

            user.Id = CreateNewId();
            user.SetNormalizedNames();
            
            return user;
        }
    }
}
