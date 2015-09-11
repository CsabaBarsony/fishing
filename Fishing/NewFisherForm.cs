using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace Fishing
{
    public partial class NewFisherForm : Form
    {
        MainForm mainForm;

        public NewFisherForm(MainForm mf)
        {
            this.mainForm = mf;
            InitializeComponent();
            SetRajtszam();
        }

        private void btn_CancelNewFisher_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btn_AddNewFisher_Click(object sender, EventArgs e)
        {
            DatabaseOperations dbops = new DatabaseOperations();
            dbops.DB_CONNECT();
            if (txt_Nev.Text != "" && txt_Lakhely.Text != "") {
                string nev = txt_Nev.Text;
                string datas = "'" + txt_Nev.Text + "','" + txt_Lakhely.Text + "','" + date_SzulDatum.Value.ToShortDateString() + "','" + txt_Megjegyzes.Text + "'";
                string sql_string = "INSERT INTO fishers (nev, lakhely, szuldatum, megjegyzes) VALUES (" + datas + ")";
                dbops.DB_INSERT(sql_string);
                ResetForm();
                this.label_Status.ForeColor = System.Drawing.Color.Green;
                this.label_Status.Text = nev + " nevű versenyző sikeresen felvéve.";
                this.mainForm.UpdateDataGrid();
            }
            else
            {
                this.label_Status.ForeColor = System.Drawing.Color.Red;
                this.label_Status.Text = "Nem töltötte ki a szükséges mezőket!";
            }
        }

        private void ResetForm() {
            this.txt_Lakhely.Text = "";
            this.txt_Megjegyzes.Text = "";
            this.txt_Nev.Text = "";
            this.date_SzulDatum.Value = DateTime.Now;
            SetRajtszam();
        }

        private void SetRajtszam() {
            DatabaseOperations dbops = new DatabaseOperations();
            
            //első rajtszám az 1, ha ez nem létezik még, akkor kivétel jön létre a SELECT-nél
            try
            {
                dbops.DB_CONNECT();
                string sql_string = "SELECT ident FROM fishers ORDER BY ident desc LIMIT 1";
                int x = int.Parse(dbops.DB_SELECT(sql_string, "ident"));
                x++;
                txt_Rajtszam.Text = "" + x;
                dbops.DB_CLOSE();
            }
            catch { txt_Rajtszam.Text = "1"; }

        }

    }
}
