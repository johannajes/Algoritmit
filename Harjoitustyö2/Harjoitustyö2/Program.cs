// using System.Data.SQLite;
using Microsoft.Data.Sqlite.Core;
using System.Data.SQLite;
// https://zetcode.com/csharp/sqlite/
namespace Harjoitustyö2
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;           //https://www.codeguru.com/dotnet/using-sqlite-in-a-c-application/
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn); 
            sqlite_conn.Close();
            
        }
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=database1.db;Version=3;New=True;Compress=True;"); //Version=3;New=True;Compress=True;
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sqlite_conn;
        }
        static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string LuoPöytä = "CREATE TABLE JoukkueenJäsenet (ID AUTOINTEGER, Nimi VARCHAR(30))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = LuoPöytä;
            sqlite_cmd.ExecuteNonQuery();
        }
        static void InsertData(SQLiteConnection conn)
        { 
            List<string> nimilista = new List<string>();
            string i = a;
            SQLiteCommand sqlite_cmd;
            while (i != x)
            {
                Console.WriteLine("Poistu kirjoittamalla x ");
                Console.WriteLine("Syötä lisättävän pelaajan sukunimi : ");
                i = Console.ReadLine();
                nimilista.Add(i);
            }
            nimilista.Sort();
            sqlite_cmd = ConnectionEventArgs.CreateCommand();
            for (int b = 0; i < nimilista.Lenght; i++)
            {                   // https://learn.microsoft.com/en-us/dotnet/standard/data/sqlite/?tabs=netcore-cli
                sqlite_cmd.CommandText = @"INSERT INTO JoukkueenJäsenet (Nimi) VALUES ($b)";
                command.Parameters.AddWithValue("$b", nimilista[b]);
                sqlite_cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd=conn.CreateCommand();
            Console.WriteLine("Etsitkö pelaajaa nimellä (1) vai pelinumerolla? (2)");
            int valinta = Console.ReadLine();
            if valinta == 1;
            { 
                Console.WriteLine("Anna pelaajan nimi : ");
                string sukunimi = Console.ReadLine();
                try
                {
                    sqlite_cmd.CommandText = @"SELECT ID FROM JoukkueenJäsenet WHERE Nimi=$b";
                    command.Parameters.AddWithValue("$b", sukunimi);
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    string tiedonluku = sqlite_datareader.GetString(0);
                    Console.WriteLine(tiedonluku);
                }
            } else if {
                valinta == 2;
                Console.WriteLine("Anna pelaajan pelinumero : ");
                int numero = Console.ReadLine();
                try
                {
                    sqlite_cmd.CommandText = @"SELECT Nimi FROM JoukkueenJäsenet WHERE ID=$b";
                    command.Parameters.AddWithValue("$b", numero);
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    string tiedonluku = sqlite_datareader.GetString(0);
                    Console.WriteLine(tiedonluku);
                }
            }
            conn.Clone();

        }
            
            
    }
}