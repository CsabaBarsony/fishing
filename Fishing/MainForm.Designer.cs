using System;
using System.Data;
using System.Data.SQLite;

namespace Fishing
{
    partial class MainForm
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
            this.btn_NewFisher = new System.Windows.Forms.Button();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tab_Versenyzok = new System.Windows.Forms.TabPage();
            this.dataGrid_Versenyzok = new System.Windows.Forms.DataGridView();
            this.tab_1nap = new System.Windows.Forms.TabPage();
            this.tab_szektorok = new System.Windows.Forms.TabControl();
            this.btn_scoringDay1 = new System.Windows.Forms.Button();
            this.btn_addtoDay1 = new System.Windows.Forms.Button();
            this.tab_main.SuspendLayout();
            this.tab_Versenyzok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Versenyzok)).BeginInit();
            this.tab_1nap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NewFisher
            // 
            this.btn_NewFisher.Location = new System.Drawing.Point(12, 12);
            this.btn_NewFisher.Name = "btn_NewFisher";
            this.btn_NewFisher.Size = new System.Drawing.Size(116, 33);
            this.btn_NewFisher.TabIndex = 0;
            this.btn_NewFisher.Text = "Új versenyző";
            this.btn_NewFisher.UseVisualStyleBackColor = true;
            this.btn_NewFisher.Click += new System.EventHandler(this.btn_NewFisher_Click);
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tab_Versenyzok);
            this.tab_main.Controls.Add(this.tab_1nap);
            this.tab_main.Location = new System.Drawing.Point(12, 61);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(760, 488);
            this.tab_main.TabIndex = 1;
            this.tab_main.Tag = "";
            // 
            // tab_Versenyzok
            // 
            this.tab_Versenyzok.Controls.Add(this.dataGrid_Versenyzok);
            this.tab_Versenyzok.Location = new System.Drawing.Point(4, 22);
            this.tab_Versenyzok.Name = "tab_Versenyzok";
            this.tab_Versenyzok.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Versenyzok.Size = new System.Drawing.Size(752, 462);
            this.tab_Versenyzok.TabIndex = 0;
            this.tab_Versenyzok.Text = "Versenyzők";
            this.tab_Versenyzok.UseVisualStyleBackColor = true;
            this.tab_Versenyzok.Enter += new System.EventHandler(this.tab_Versenyzok_Enter);
            // 
            // dataGrid_Versenyzok
            // 
            this.dataGrid_Versenyzok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Versenyzok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Versenyzok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGrid_Versenyzok.Location = new System.Drawing.Point(6, 6);
            this.dataGrid_Versenyzok.Name = "dataGrid_Versenyzok";
            this.dataGrid_Versenyzok.ReadOnly = true;
            this.dataGrid_Versenyzok.Size = new System.Drawing.Size(740, 450);
            this.dataGrid_Versenyzok.TabIndex = 0;
            this.dataGrid_Versenyzok.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Versenyzok_CellContentDoubleClick);
            // 
            // tab_1nap
            // 
            this.tab_1nap.Controls.Add(this.tab_szektorok);
            this.tab_1nap.Controls.Add(this.btn_scoringDay1);
            this.tab_1nap.Controls.Add(this.btn_addtoDay1);
            this.tab_1nap.Location = new System.Drawing.Point(4, 22);
            this.tab_1nap.Name = "tab_1nap";
            this.tab_1nap.Padding = new System.Windows.Forms.Padding(3);
            this.tab_1nap.Size = new System.Drawing.Size(752, 462);
            this.tab_1nap.TabIndex = 1;
            this.tab_1nap.Tag = "1nap";
            this.tab_1nap.Text = "1. versenynap";
            this.tab_1nap.UseVisualStyleBackColor = true;
            // 
            // tab_szektorok
            // 
            this.tab_szektorok.Location = new System.Drawing.Point(-4, 42);
            this.tab_szektorok.Name = "tab_szektorok";
            this.tab_szektorok.SelectedIndex = 0;
            this.tab_szektorok.Size = new System.Drawing.Size(760, 424);
            this.tab_szektorok.TabIndex = 2;
            this.tab_szektorok.Tag = "";
            // 
            // btn_scoringDay1
            // 
            this.btn_scoringDay1.Location = new System.Drawing.Point(148, 6);
            this.btn_scoringDay1.Name = "btn_scoringDay1";
            this.btn_scoringDay1.Size = new System.Drawing.Size(136, 30);
            this.btn_scoringDay1.TabIndex = 1;
            this.btn_scoringDay1.Text = "Pontozás";
            this.btn_scoringDay1.UseVisualStyleBackColor = true;
            // 
            // btn_addtoDay1
            // 
            this.btn_addtoDay1.Location = new System.Drawing.Point(6, 6);
            this.btn_addtoDay1.Name = "btn_addtoDay1";
            this.btn_addtoDay1.Size = new System.Drawing.Size(136, 30);
            this.btn_addtoDay1.TabIndex = 0;
            this.btn_addtoDay1.Text = "Versenyző felvétele";
            this.btn_addtoDay1.UseVisualStyleBackColor = true;
            this.btn_addtoDay1.Click += new System.EventHandler(this.btn_addtoDay1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tab_main);
            this.Controls.Add(this.btn_NewFisher);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Fishing 1.0";
            this.tab_main.ResumeLayout(false);
            this.tab_Versenyzok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Versenyzok)).EndInit();
            this.tab_1nap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewFisher;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tab_Versenyzok;
        private System.Windows.Forms.TabPage tab_1nap;
        private System.Windows.Forms.DataGridView dataGrid_Versenyzok;
        private System.Windows.Forms.Button btn_scoringDay1;
        private System.Windows.Forms.Button btn_addtoDay1;
        private System.Windows.Forms.TabControl tab_szektorok;
    }
}

