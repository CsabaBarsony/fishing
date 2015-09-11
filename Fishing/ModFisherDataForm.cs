using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class ModFisherDataForm : Form
    {
        public ModFisherDataForm()
        {
            InitializeComponent();
        }

        private void btn_CancelModFisher_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FillWithData(string rajtszam, string nev, string lakhely, string szuldatum, string megjegyzes)
        {
            txt_Rajtszam.Text = rajtszam;
            txt_Nev.Text = nev;
            txt_Lakhely.Text = lakhely;
            date_SzulDatum.Value = Convert.ToDateTime(szuldatum);
            txt_Megjegyzes.Text = megjegyzes;
        }

        private void btn_ModFisherData_Click(object sender, EventArgs e)
        {
            DatabaseOperations dbops = new DatabaseOperations();
            dbops.DB_CONNECT();
            if (txt_Nev.Text != "" && txt_Lakhely.Text != "")
            {
                string sql_string = "UPDATE fishers SET nev='"+txt_Nev.Text+"',lakhely='"+txt_Lakhely.Text+"',szuldatum='"+date_SzulDatum.Value.ToShortDateString()+"',megjegyzes='"+txt_Megjegyzes.Text+"' WHERE ident='"+txt_Rajtszam.Text+"'";
                dbops.DB_UPDATE(sql_string);
                this.label_Status.ForeColor = System.Drawing.Color.Green;
                this.label_Status.Text = "Adatok sikeresen módosítva";
            }
            else
            {
                this.label_Status.ForeColor = System.Drawing.Color.Red;
                this.label_Status.Text = "Nem töltötte ki a szükséges mezőket!";
            }
            dbops.DB_CLOSE();
         }
    }
}
