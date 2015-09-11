using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Fishing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            NewVerseny();//Új verseny beállítása
            FillSzektorWithTabs(); //Szektorlapok feltöltése
            UpdateDataGrid(); //betölti megnyitáskor a datagridet
            
        }
      
        private void btn_NewFisher_Click(object sender, EventArgs e)
        {
            NewFisherForm newfisher = new NewFisherForm(this);
            newfisher.ShowDialog();
        }

        private void tab_Versenyzok_Enter(object sender, EventArgs e)
        {
            UpdateDataGrid();
            //MessageBox.Show("Hahó");
        }

        //adatok betöltése a táblázatba
        public void UpdateDataGrid()
        {
            string sql = "SELECT * FROM fishers;";
            DataSet dataSet = new DataSet();
            DatabaseOperations dbops = new DatabaseOperations();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, dbops.dbConnection);
            dataAdapter.Fill(dataSet);
            dataGrid_Versenyzok.DataSource = dataSet.Tables[0].DefaultView;
        }

        //dupla kattintásra az adott versenyző adatainak betöltése a 
        private void dataGrid_Versenyzok_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string rajtszam = "", nev = "", lakhely = "", szuldatum = "", megjegyzes = "";
            int id = Convert.ToInt32(dataGrid_Versenyzok.Rows[e.RowIndex].Cells["ident"].Value.ToString());
            string sql = "SELECT * FROM fishers WHERE ident=" + id + "";
            DataTable dataTable = new DataTable();
            DatabaseOperations dbops = new DatabaseOperations();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, dbops.dbConnection);
            dataAdapter.Fill(dataTable);
            //MessageBox.Show(""+id);

            //adatok kiolvasása a feltöltött adattáblából
            foreach (DataRow dr in dataTable.Rows) {
                rajtszam = dr["ident"].ToString();
                nev = dr["nev"].ToString();
                lakhely = dr["lakhely"].ToString();
                szuldatum = dr["szuldatum"].ToString();
                megjegyzes = dr["megjegyzes"].ToString();
            }

            //adatmódosító form betöltése
            ModFisherDataForm modfisher = new ModFisherDataForm();
            modfisher.FillWithData(rajtszam,nev,lakhely,szuldatum,megjegyzes);
            modfisher.ShowDialog();
        }

        //Szektorlapok feltöltése
        private void FillSzektorWithTabs()
        {
            string sql = "SELECT * FROM szektorok";
            DataTable dataTable = new DataTable();
            DatabaseOperations dbops = new DatabaseOperations();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, dbops.dbConnection);
            dataAdapter.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                var newTabpage = new System.Windows.Forms.TabPage();
                this.tab_szektorok.TabPages.Add(newTabpage);
                newTabpage.Name = "tab_Szektor"+ dr["szektor"].ToString().ToUpper();
                newTabpage.Text = "" + dr["szektor"].ToString().ToUpper() + " szektor";

            }
            

        }

        //Új verseny beállítása, indításkor ha nem léteznek a szükséges táblák
        private void NewVerseny()
        {
            string sql = "SELECT name FROM sqlite_master WHERE type='table' AND name LIKE '_nap'";
            DatabaseOperations dbops = new DatabaseOperations();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, dbops.dbConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            string table_name = null;

            foreach (DataRow dr in dataTable.Rows)
            {
                table_name = dr["name"].ToString();
            }

            //ha nem létezik a tábla megnyílik a verseny inicializálása form
            if (table_name == null)
            {
                NewVersenyForm newversenyform = new NewVersenyForm();
                newversenyform.ShowDialog();
            }

        }

        //versenyzo hozzáadása a naphoz
        private void btn_addtoDay1_Click(object sender, EventArgs e)
        {
            AddVersenyzoToDay addversenyzotoday = new AddVersenyzoToDay();
            addversenyzotoday.ShowDialog();
        }
        
        public string getDay() {
            string s = (string)this.tab_1nap.Tag;
            return s;
        }
    }
}
