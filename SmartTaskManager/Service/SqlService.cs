using Npgsql;
using SmartTaskManager.Service.IService;

namespace SmartTaskManager.Service
{
    public class SqlService : ISqlService
    {
        private string mConfiguration;

        public SqlService(IConfiguration configuration)
        {
            mConfiguration = configuration["ConnectionStrings:DbConnection"];
        }

        public NpgsqlConnection GetNpgsqlConnection()
        {
            return new NpgsqlConnection(mConfiguration);
        }
    }
}
