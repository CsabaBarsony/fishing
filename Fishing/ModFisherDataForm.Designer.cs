namespace Fishing
{
    partial class ModFisherDataForm
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
            this.label_Rajtszam = new System.Windows.Forms.Label();
            this.label_Nev = new System.Windows.Forms.Label();
            this.label_Lakhely = new System.Windows.Forms.Label();
            this.label_SzulDatum = new System.Windows.Forms.Label();
            this.label_Megjegyzes = new System.Windows.Forms.Label();
            this.btn_ModFisherData = new System.Windows.Forms.Button();
            this.btn_CancelModFisher = new System.Windows.Forms.Button();
            this.txt_Rajtszam = new System.Windows.Forms.TextBox();
            this.txt_Nev = new System.Windows.Forms.TextBox();
            this.txt_Lakhely = new System.Windows.Forms.TextBox();
            this.date_SzulDatum = new System.Windows.Forms.DateTimePicker();
            this.txt_Megjegyzes = new System.Windows.Forms.TextBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Rajtszam
            // 
            this.label_Rajtszam.AutoSize = true;
            this.label_Rajtszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Rajtszam.Location = new System.Drawing.Point(12, 9);
            this.label_Rajtszam.Name = "label_Rajtszam";
            this.label_Rajtszam.Size = new System.Drawing.Size(80, 20);
            this.label_Rajtszam.TabIndex = 0;
            this.label_Rajtszam.Text = "Rajtszám:";
            this.label_Rajtszam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Nev.Location = new System.Drawing.Point(12, 48);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(40, 20);
            this.label_Nev.TabIndex = 1;
            this.label_Nev.Text = "Név:";
            this.label_Nev.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Lakhely
            // 
            this.label_Lakhely.AutoSize = true;
            this.label_Lakhely.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Lakhely.Location = new System.Drawing.Point(12, 86);
            this.label_Lakhely.Name = "label_Lakhely";
            this.label_Lakhely.Size = new System.Drawing.Size(67, 20);
            this.label_Lakhely.TabIndex = 2;
            this.label_Lakhely.Text = "Lakhely:";
            this.label_Lakhely.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_SzulDatum
            // 
            this.label_SzulDatum.AutoSize = true;
            this.label_SzulDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SzulDatum.Location = new System.Drawing.Point(12, 128);
            this.label_SzulDatum.Name = "label_SzulDatum";
            this.label_SzulDatum.Size = new System.Drawing.Size(103, 20);
            this.label_SzulDatum.TabIndex = 3;
            this.label_SzulDatum.Text = "Születési idő:";
            this.label_SzulDatum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Megjegyzes
            // 
            this.label_Megjegyzes.AutoSize = true;
            this.label_Megjegyzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Megjegyzes.Location = new System.Drawing.Point(12, 170);
            this.label_Megjegyzes.Name = "label_Megjegyzes";
            this.label_Megjegyzes.Size = new System.Drawing.Size(97, 20);
            this.label_Megjegyzes.TabIndex = 4;
            this.label_Megjegyzes.Text = "Megjegyzés:";
            this.label_Megjegyzes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_ModFisherData
            // 
            this.btn_ModFisherData.Location = new System.Drawing.Point(162, 273);
            this.btn_ModFisherData.Name = "btn_ModFisherData";
            this.btn_ModFisherData.Size = new System.Drawing.Size(75, 23);
            this.btn_ModFisherData.TabIndex = 5;
            this.btn_ModFisherData.Text = "Mentés";
            this.btn_ModFisherData.UseVisualStyleBackColor = true;
            this.btn_ModFisherData.Click += new System.EventHandler(this.btn_ModFisherData_Click);

            // 
            // btn_CancelModFisher
            // 
            this.btn_CancelModFisher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_CancelModFisher.Location = new System.Drawing.Point(243, 273);
            this.btn_CancelModFisher.Name = "btn_CancelModFisher";
            this.btn_CancelModFisher.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelModFisher.TabIndex = 6;
            this.btn_CancelModFisher.Text = "Mégse";
            this.btn_CancelModFisher.UseVisualStyleBackColor = true;
            this.btn_CancelModFisher.Click += new System.EventHandler(this.btn_CancelModFisher_Click);
            // 
            // txt_Rajtszam
            // 
            this.txt_Rajtszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Rajtszam.Location = new System.Drawing.Point(100, 9);
            this.txt_Rajtszam.Name = "txt_Rajtszam";
            this.txt_Rajtszam.ReadOnly = true;
            this.txt_Rajtszam.Size = new System.Drawing.Size(37, 22);
            this.txt_Rajtszam.TabIndex = 7;
            // 
            // txt_Nev
            // 
            this.txt_Nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Nev.Location = new System.Drawing.Point(100, 48);
            this.txt_Nev.Name = "txt_Nev";
            this.txt_Nev.Size = new System.Drawing.Size(218, 22);
            this.txt_Nev.TabIndex = 8;
            // 
            // txt_Lakhely
            // 
            this.txt_Lakhely.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Lakhely.Location = new System.Drawing.Point(100, 86);
            this.txt_Lakhely.Name = "txt_Lakhely";
            this.txt_Lakhely.Size = new System.Drawing.Size(218, 22);
            this.txt_Lakhely.TabIndex = 9;
            // 
            // date_SzulDatum
            // 
            this.date_SzulDatum.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date_SzulDatum.Location = new System.Drawing.Point(121, 128);
            this.date_SzulDatum.Name = "date_SzulDatum";
            this.date_SzulDatum.Size = new System.Drawing.Size(197, 20);
            this.date_SzulDatum.TabIndex = 10;
            // 
            // txt_Megjegyzes
            // 
            this.txt_Megjegyzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Megjegyzes.Location = new System.Drawing.Point(16, 193);
            this.txt_Megjegyzes.Multiline = true;
            this.txt_Megjegyzes.Name = "txt_Megjegyzes";
            this.txt_Megjegyzes.Size = new System.Drawing.Size(302, 74);
            this.txt_Megjegyzes.TabIndex = 11;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Status.Location = new System.Drawing.Point(13, 314);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 13);
            this.label_Status.TabIndex = 12;
            // 
            // ModFisherDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_CancelModFisher;
            this.ClientSize = new System.Drawing.Size(334, 336);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.txt_Megjegyzes);
            this.Controls.Add(this.date_SzulDatum);
            this.Controls.Add(this.txt_Lakhely);
            this.Controls.Add(this.txt_Nev);
            this.Controls.Add(this.txt_Rajtszam);
            this.Controls.Add(this.btn_CancelModFisher);
            this.Controls.Add(this.btn_ModFisherData);
            this.Controls.Add(this.label_Megjegyzes);
            this.Controls.Add(this.label_SzulDatum);
            this.Controls.Add(this.label_Lakhely);
            this.Controls.Add(this.label_Nev);
            this.Controls.Add(this.label_Rajtszam);
            this.MaximumSize = new System.Drawing.Size(350, 375);
            this.MinimumSize = this.MaximumSize;
            this.Name = "ModFisherDataForm";
            this.Text = "Versenyző módosítása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Rajtszam;
        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.Label label_Lakhely;
        private System.Windows.Forms.Label label_SzulDatum;
        private System.Windows.Forms.Label label_Megjegyzes;
        private System.Windows.Forms.Button btn_ModFisherData;
        private System.Windows.Forms.Button btn_CancelModFisher;
        private System.Windows.Forms.TextBox txt_Rajtszam;
        private System.Windows.Forms.TextBox txt_Nev;
        private System.Windows.Forms.TextBox txt_Lakhely;
        private System.Windows.Forms.TextBox txt_Megjegyzes;
        private System.Windows.Forms.DateTimePicker date_SzulDatum;
        private System.Windows.Forms.Label label_Status;
    }


    
}