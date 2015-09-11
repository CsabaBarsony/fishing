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
    public partial class NewVersenyForm : Form
    {
        public NewVersenyForm()
        {
            InitializeComponent();
        }

        //szektorszám választó, kiírja a szektorok neveit
        private void numericUpDown_SzektortokSzama_ValueChanged(object sender, EventArgs e)
        {
            string napok = null;
            int value = (int)numericUpDown_SzektortokSzama.Value;
            if (value > 0)
            {
                for (int i = 1; i<= value; i++)
                {
                    napok = napok + (char)(i + 64) + ", ";
                }
                label_SzektorNevekDinPrint.Text = napok;
            }
        }

        //MÉGSE gomb, kilép az egész programból
        private void btn_MegseNewVerseny_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //verseny beállítása gomb, meghívja a verseny beállításához szükséges függvényt
        private void btn_SaveVersenyData_Click(object sender, EventArgs e)
        {
            DatabaseOperations dbops = new DatabaseOperations();
            dbops.SetVersenyTables((int)numericUpDown_NapokSzama.Value, (int)numericUpDown_SzektortokSzama.Value, (int)numericUpDown_HelyekSzama.Value);
            this.Close();
        }
    }
}
