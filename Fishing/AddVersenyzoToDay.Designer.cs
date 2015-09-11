using System.Windows.Forms;

namespace Fishing
{
    partial class AddVersenyzoToDay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dropdown_Versenyzo = new System.Windows.Forms.ComboBox();
            this.dropdown_Szektor = new System.Windows.Forms.ComboBox();
            this.dropdown_Ulohely = new System.Windows.Forms.ComboBox();
            this.btn_AddtoDay = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropdown_Versenyzo
            // 
            this.dropdown_Versenyzo.AllowDrop = true;
            this.dropdown_Versenyzo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.dropdown_Versenyzo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdown_Versenyzo.DisplayMember = "Text";
            this.dropdown_Versenyzo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_Versenyzo.FormattingEnabled = true;
            this.dropdown_Versenyzo.Location = new System.Drawing.Point(12, 29);
            this.dropdown_Versenyzo.MaxDropDownItems = 32;
            this.dropdown_Versenyzo.Name = "dropdown_Versenyzo";
            this.dropdown_Versenyzo.Size = new System.Drawing.Size(229, 21);
            this.dropdown_Versenyzo.Sorted = true;
            this.dropdown_Versenyzo.TabIndex = 0;
            this.dropdown_Versenyzo.ValueMember = "Value";
            // 
            // dropdown_Szektor
            // 
            this.dropdown_Szektor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_Szektor.FormattingEnabled = true;
            this.dropdown_Szektor.Location = new System.Drawing.Point(247, 29);
            this.dropdown_Szektor.Name = "dropdown_Szektor";
            this.dropdown_Szektor.Size = new System.Drawing.Size(56, 21);
            this.dropdown_Szektor.TabIndex = 1;
            // 
            // dropdown_Ulohely
            // 
            this.dropdown_Ulohely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_Ulohely.FormattingEnabled = true;
            this.dropdown_Ulohely.Location = new System.Drawing.Point(318, 29);
            this.dropdown_Ulohely.Name = "dropdown_Ulohely";
            this.dropdown_Ulohely.Size = new System.Drawing.Size(48, 21);
            this.dropdown_Ulohely.TabIndex = 2;
            // 
            // btn_AddtoDay
            // 
            this.btn_AddtoDay.Location = new System.Drawing.Point(127, 72);
            this.btn_AddtoDay.Name = "btn_AddtoDay";
            this.btn_AddtoDay.Size = new System.Drawing.Size(143, 23);
            this.btn_AddtoDay.TabIndex = 3;
            this.btn_AddtoDay.Text = "Hozzáadás";
            this.btn_AddtoDay.UseVisualStyleBackColor = true;
            this.btn_AddtoDay.Click += new System.EventHandler(this.btn_AddtoDay_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(9, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(59, 13);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Versenyző:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szektor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Horgászhely";
            // 
            // AddVersenyzoToDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 107);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_AddtoDay);
            this.Controls.Add(this.dropdown_Ulohely);
            this.Controls.Add(this.dropdown_Szektor);
            this.Controls.Add(this.dropdown_Versenyzo);
            this.Name = "AddVersenyzoToDay";
            this.Text = "Versenyző felvétele a versenynapra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropdown_Versenyzo;
        private System.Windows.Forms.ComboBox dropdown_Szektor;
        private System.Windows.Forms.ComboBox dropdown_Ulohely;
        private System.Windows.Forms.Button btn_AddtoDay;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}