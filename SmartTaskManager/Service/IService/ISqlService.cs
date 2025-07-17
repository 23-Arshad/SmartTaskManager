using Npgsql;

namespace SmartTaskManager.Service.IService
{
    public interface ISqlService
    {
        NpgsqlConnection GetNpgsqlConnection();
    }
}
