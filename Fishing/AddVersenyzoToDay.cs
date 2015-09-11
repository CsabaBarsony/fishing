using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class AddVersenyzoToDay : Form
    {
        public AddVersenyzoToDay()
        {
            InitializeComponent();
            FillVersenyzokDropdown();
            FillSzektorDropdown();
            FillUlohelyDropdown();
        }

        public class DropDownListItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void FillVersenyzokDropdown() {
            string sql = "SELECT * FROM fishers";
            DataTable dataTable = new DataTable();
            DatabaseOperations dbops = new DatabaseOperations();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, dbops.dbConnection);
            dataAdapter.Fill(dataTable);

            var items = new List<DropDownListItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                items.Add(new DropDownListItem() {Text = dr["nev"].ToString(), Value = dr["ident"]});
            }
            this.dropdown_Versenyzo.DataSource = items;
                      
        }

        private void FillSzektorDropdown() {
            string sql = "SELECT * FROM szektorok";
            DataTable dataTable = new DataTable();
            DatabaseOperations dbops = new DatabaseOperations();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, dbops.dbConnection);
            dataAdapter.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                dropdown_Szektor.Items.Add(dr["szektor"]);
            }
            
        }

        private void FillUlohelyDropdown() {
            string sql = "SELECT * FROM szektorok";
            DataTable dataTable = new DataTable();
            DatabaseOperations dbops = new DatabaseOperations();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, dbops.dbConnection);
            dataAdapter.Fill(dataTable);

            byte helyek_szama = Convert.ToByte(dataTable.Rows[0]["helyek"]);

            for (int i = 1; i <= helyek_szama; i++ ) {
                dropdown_Ulohely.Items.Add(i);
            }

        }

        private void btn_AddtoDay_Click(object sender, EventArgs e)
        {
            DatabaseOperations dbops = new DatabaseOperations();
            dbops.DB_CONNECT();
            var accessMainForm = new MainForm();
            string nap = accessMainForm.getDay();
            MessageBox.Show(nap);
            string sql = "INSERT INTO '"+nap+"'(ident, szektor, ulohely) VALUES('"+this.dropdown_Versenyzo.SelectedValue+"', '"+dropdown_Szektor.Text+"', '"+dropdown_Ulohely.Text+"')";
            dbops.DB_INSERT(sql);
            dbops.DB_CLOSE();
            this.Close();
        }
    }
}
