using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Fishing
{
    class DatabaseOperations
    {
        //SQL kapcsolat opbjektum
        public SQLiteConnection dbConnection = new SQLiteConnection("Data Source=FishingDB.sqlite;Version=3;");

        // SQLITE adatbázis létrehozáshoz
        public void DB_CREATE() {
            SQLiteConnection.CreateFile("FishingDB.sqlite");
        }
        
        //adatbázis kapcsolat létesítése
        public void DB_CONNECT() {
            dbConnection.Close();
            dbConnection.Open();
        }

        //adatbázis kapcsolat lezárása
        public void DB_CLOSE()
        {
            dbConnection.Close();
        }

        //táblák létrehozása
        public void DB_CREATE_TABLE(string sqlString) {
            SQLiteCommand command = new SQLiteCommand(sqlString, dbConnection);
            DB_CONNECT();
            command.ExecuteNonQuery();
            DB_CLOSE();
        }

        //adatok beszúrása
        public void DB_INSERT(string sql_string) {
            SQLiteCommand command = new SQLiteCommand(sql_string, dbConnection);
            DB_CONNECT();
            command.ExecuteNonQuery();
            DB_CLOSE();
        }

        //adatok frissítése
        public void DB_UPDATE(string sql_string) {
            SQLiteCommand command = new SQLiteCommand(sql_string, dbConnection);
            DB_CONNECT();
            command.ExecuteNonQuery();
            DB_CLOSE();
        }

        //lekérdezés (SELECT)
        public string DB_SELECT(string sql_string, string assoc) {
            string result = "";
            SQLiteCommand command = new SQLiteCommand(sql_string, dbConnection);
            DB_CONNECT();
            command.ExecuteNonQuery();
            DB_CLOSE();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read()) { 
                result = "" + reader["" + assoc + ""];
            }
            return result;
        }

        //VERSENYHEZ szükséges táblák létrehozás
        //a Verseny beállítása form hívja meg
        public void SetVersenyTables(int napokszama, int szektorokszama, int helyek_szama)
        {
            string sql;
            DB_CONNECT();
            //versenynapok létrehozása
            for (int i=1; i<=napokszama; i++)
            {
                sql = "CREATE TABLE `"+i+"nap` (`ident`	INTEGER,`szektor`	TEXT,`ulohely`	INTEGER,`fogotthal`	INTEGER,`pontszam`	INTEGER,PRIMARY KEY(ident));";
                DB_CREATE_TABLE(sql);
            }
            //szektorok tábla létrehozása és feltöltése adattal
            sql = "CREATE TABLE `szektorok` (`szektor`	TEXT, `szektor_id`	INTEGER PRIMARY KEY AUTOINCREMENT, `helyek` INTEGER);";
            DB_CREATE_TABLE(sql);
            for (int i=1; i<=szektorokszama; i++)
            {
                sql = "INSERT INTO `szektorok`(`szektor`, `helyek`) VALUES ('"+(char)(i+64)+"',"+helyek_szama+");";
                DB_INSERT(sql);
            }
            DB_CLOSE();
        }

        //ellenőrzi, hogy a hozzáadni kívánt ülöhely foglalt-e
        public void CheckPlaceReserved() {


        }
    }
}
