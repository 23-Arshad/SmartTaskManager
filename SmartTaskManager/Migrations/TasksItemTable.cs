using FluentMigrator;

namespace SmartTaskManager.Migrations
{
    [Migration(202507171408)]
    public class TasksItemTable : Migration
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Execute.Script(@"Scripts\TasksItems.sql");
        }
    }
}
