namespace Fishing
{
    partial class NewVersenyForm
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
            this.label_NapokSzama = new System.Windows.Forms.Label();
            this.label_SzektorokSzama = new System.Windows.Forms.Label();
            this.label_SzektorNevek = new System.Windows.Forms.Label();
            this.btn_SaveVersenyData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_NapokSzama = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SzektortokSzama = new System.Windows.Forms.NumericUpDown();
            this.label_SzektorNevekDinPrint = new System.Windows.Forms.Label();
            this.btn_MegseNewVerseny = new System.Windows.Forms.Button();
            this.numericUpDown_HelyekSzama = new System.Windows.Forms.NumericUpDown();
            this.label_helyekszama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NapokSzama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzektortokSzama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HelyekSzama)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NapokSzama
            // 
            this.label_NapokSzama.AutoSize = true;
            this.label_NapokSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NapokSzama.Location = new System.Drawing.Point(12, 18);
            this.label_NapokSzama.Name = "label_NapokSzama";
            this.label_NapokSzama.Size = new System.Drawing.Size(95, 16);
            this.label_NapokSzama.TabIndex = 0;
            this.label_NapokSzama.Text = "Napok száma:";
            // 
            // label_SzektorokSzama
            // 
            this.label_SzektorokSzama.AutoSize = true;
            this.label_SzektorokSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SzektorokSzama.Location = new System.Drawing.Point(12, 56);
            this.label_SzektorokSzama.Name = "label_SzektorokSzama";
            this.label_SzektorokSzama.Size = new System.Drawing.Size(114, 16);
            this.label_SzektorokSzama.TabIndex = 1;
            this.label_SzektorokSzama.Text = "Szektorok száma:";
            // 
            // label_SzektorNevek
            // 
            this.label_SzektorNevek.AutoSize = true;
            this.label_SzektorNevek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SzektorNevek.Location = new System.Drawing.Point(12, 97);
            this.label_SzektorNevek.Name = "label_SzektorNevek";
            this.label_SzektorNevek.Size = new System.Drawing.Size(96, 16);
            this.label_SzektorNevek.TabIndex = 2;
            this.label_SzektorNevek.Text = "Szektor nevek:";
            // 
            // btn_SaveVersenyData
            // 
            this.btn_SaveVersenyData.Location = new System.Drawing.Point(76, 180);
            this.btn_SaveVersenyData.Name = "btn_SaveVersenyData";
            this.btn_SaveVersenyData.Size = new System.Drawing.Size(124, 23);
            this.btn_SaveVersenyData.TabIndex = 3;
            this.btn_SaveVersenyData.Text = "Verseny létrehozása";
            this.btn_SaveVersenyData.UseVisualStyleBackColor = true;
            this.btn_SaveVersenyData.Click += new System.EventHandler(this.btn_SaveVersenyData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Figyelem!  Az itt megadott adatokat később már nem módosíthatja!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_NapokSzama
            // 
            this.numericUpDown_NapokSzama.Location = new System.Drawing.Point(134, 18);
            this.numericUpDown_NapokSzama.Name = "numericUpDown_NapokSzama";
            this.numericUpDown_NapokSzama.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_NapokSzama.TabIndex = 5;
            this.numericUpDown_NapokSzama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_SzektortokSzama
            // 
            this.numericUpDown_SzektortokSzama.Location = new System.Drawing.Point(134, 56);
            this.numericUpDown_SzektortokSzama.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_SzektortokSzama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SzektortokSzama.Name = "numericUpDown_SzektortokSzama";
            this.numericUpDown_SzektortokSzama.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_SzektortokSzama.TabIndex = 6;
            this.numericUpDown_SzektortokSzama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SzektortokSzama.ValueChanged += new System.EventHandler(this.numericUpDown_SzektortokSzama_ValueChanged);
            // 
            // label_SzektorNevekDinPrint
            // 
            this.label_SzektorNevekDinPrint.AutoSize = true;
            this.label_SzektorNevekDinPrint.Location = new System.Drawing.Point(160, 97);
            this.label_SzektorNevekDinPrint.Name = "label_SzektorNevekDinPrint";
            this.label_SzektorNevekDinPrint.Size = new System.Drawing.Size(14, 13);
            this.label_SzektorNevekDinPrint.TabIndex = 7;
            this.label_SzektorNevekDinPrint.Text = "A";
            // 
            // btn_MegseNewVerseny
            // 
            this.btn_MegseNewVerseny.Location = new System.Drawing.Point(215, 180);
            this.btn_MegseNewVerseny.Name = "btn_MegseNewVerseny";
            this.btn_MegseNewVerseny.Size = new System.Drawing.Size(124, 23);
            this.btn_MegseNewVerseny.TabIndex = 8;
            this.btn_MegseNewVerseny.Text = "Mégse";
            this.btn_MegseNewVerseny.UseVisualStyleBackColor = true;
            this.btn_MegseNewVerseny.Click += new System.EventHandler(this.btn_MegseNewVerseny_Click);
            // 
            // numericUpDown_HelyekSzama
            // 
            this.numericUpDown_HelyekSzama.Location = new System.Drawing.Point(356, 56);
            this.numericUpDown_HelyekSzama.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_HelyekSzama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_HelyekSzama.Name = "numericUpDown_HelyekSzama";
            this.numericUpDown_HelyekSzama.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_HelyekSzama.TabIndex = 9;
            this.numericUpDown_HelyekSzama.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label_helyekszama
            // 
            this.label_helyekszama.AutoSize = true;
            this.label_helyekszama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_helyekszama.Location = new System.Drawing.Point(194, 56);
            this.label_helyekszama.Name = "label_helyekszama";
            this.label_helyekszama.Size = new System.Drawing.Size(148, 16);
            this.label_helyekszama.TabIndex = 10;
            this.label_helyekszama.Text = "Helyek (szektoronként):";
            // 
            // NewVersenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 215);
            this.ControlBox = false;
            this.Controls.Add(this.label_helyekszama);
            this.Controls.Add(this.numericUpDown_HelyekSzama);
            this.Controls.Add(this.btn_MegseNewVerseny);
            this.Controls.Add(this.label_SzektorNevekDinPrint);
            this.Controls.Add(this.numericUpDown_SzektortokSzama);
            this.Controls.Add(this.numericUpDown_NapokSzama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SaveVersenyData);
            this.Controls.Add(this.label_SzektorNevek);
            this.Controls.Add(this.label_SzektorokSzama);
            this.Controls.Add(this.label_NapokSzama);
            this.Name = "NewVersenyForm";
            this.Text = "Verseny beállítása";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NapokSzama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzektortokSzama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HelyekSzama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NapokSzama;
        private System.Windows.Forms.Label label_SzektorokSzama;
        private System.Windows.Forms.Label label_SzektorNevek;
        private System.Windows.Forms.Button btn_SaveVersenyData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_NapokSzama;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzektortokSzama;
        private System.Windows.Forms.Label label_SzektorNevekDinPrint;
        private System.Windows.Forms.Button btn_MegseNewVerseny;
        private System.Windows.Forms.NumericUpDown numericUpDown_HelyekSzama;
        private System.Windows.Forms.Label label_helyekszama;
    }
}