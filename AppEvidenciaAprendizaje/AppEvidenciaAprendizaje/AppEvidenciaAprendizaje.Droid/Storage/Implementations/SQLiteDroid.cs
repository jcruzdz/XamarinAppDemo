using System.IO;
using AppEvidenciaAprendizaje.Droid.Storage.Implementations;
using AppEvidenciaAprendizaje.Storage.Interfaces;
using SQLite;
using Xamarin.Forms;

//Registrar en el DependencyService para porder utilizarlo.
[assembly: Dependency(typeof(SQLiteDroid))]
namespace AppEvidenciaAprendizaje.Droid.Storage.Implementations
{
    public class SQLiteDroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            //Inicializa SQLite conforme a la plataforma que se está ejecutando.
            SQLitePCL.Batteries.Init();
            var sqliteFileName = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            //Create de connection
            var conn = new SQLite.SQLiteConnection(path);
            return conn;

        }
    }
}