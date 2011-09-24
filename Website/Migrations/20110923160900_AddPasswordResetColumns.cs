using System.Data;
using Migrator.Framework;

namespace NuGetGallery {
    [Migration(20110923160900)]
    public class AddPasswordResetColumns : Migration {
        public override void Up() {
            Database.AddColumn("Users", "PasswordResetToken", DbType.String, 32, ColumnProperty.Null);
            Database.AddColumn("Users", "PasswordResetTokenExpirationDate", DbType.DateTime, ColumnProperty.Null);
        }

        public override void Down() {
            Database.RemoveColumn("Users", "PasswordResetToken");
            Database.RemoveColumn("Users", "PasswordResetTokenExpirationDate");
        }
    }
}
