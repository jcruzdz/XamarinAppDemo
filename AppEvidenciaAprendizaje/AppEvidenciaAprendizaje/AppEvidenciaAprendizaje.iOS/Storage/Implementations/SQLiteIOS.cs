using System;
using System.IO;
using AppEvidenciaAprendizaje.iOS.Storage.Implementations;
using AppEvidenciaAprendizaje.Storage.Interfaces;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteIOS))]
namespace AppEvidenciaAprendizaje.iOS.Storage.Implementations
{
    public class SQLiteIOS : ISQLite
    {
        public SQLiteIOS()
        {
        }

        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TodoSQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFileName);
            //create Conecction
            var conn = new SQLite.SQLiteConnection(path);
            //Return dthe database coneccetion
            return conn;
        }
    }
}