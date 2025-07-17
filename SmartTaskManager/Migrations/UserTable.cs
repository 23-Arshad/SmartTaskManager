using FluentMigrator;

namespace SmartTaskManager.Migrations
{
    [Migration(202507171406)]
    public class UserTable : Migration
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Execute.Script(@"Scripts\User.sql");
        }
    }
}
