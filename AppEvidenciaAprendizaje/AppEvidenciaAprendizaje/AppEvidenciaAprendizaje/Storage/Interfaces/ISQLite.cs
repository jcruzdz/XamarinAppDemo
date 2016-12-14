using SQLite;

namespace AppEvidenciaAprendizaje.Storage.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}