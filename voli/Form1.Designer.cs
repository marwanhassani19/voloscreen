namespace voli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPartenza = new System.Windows.Forms.DateTimePicker();
            this.dtRitorno = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInformazioni = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.rbSpecifica = new System.Windows.Forms.RadioButton();
            this.rbIntervallo = new System.Windows.Forms.RadioButton();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.panelPartenza = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbErroreData = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureVolo = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtMeteo = new System.Windows.Forms.TextBox();
            this.pictureBoxMeteo = new System.Windows.Forms.PictureBox();
            this.btnMeteo = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBoxCartina = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnCartina = new System.Windows.Forms.Button();
            this.panelPartenza.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVolo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeteo)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartina)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 325);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "OVUNQUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 36);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "A:";
            // 
            // dtPartenza
            // 
            this.dtPartenza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPartenza.Location = new System.Drawing.Point(150, 12);
            this.dtPartenza.Name = "dtPartenza";
            this.dtPartenza.Size = new System.Drawing.Size(82, 20);
            this.dtPartenza.TabIndex = 11;
            this.dtPartenza.ValueChanged += new System.EventHandler(this.dtPartenza_ValueChanged);
            // 
            // dtRitorno
            // 
            this.dtRitorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRitorno.Location = new System.Drawing.Point(150, 42);
            this.dtRitorno.Name = "dtRitorno";
            this.dtRitorno.Size = new System.Drawing.Size(82, 20);
            this.dtRitorno.TabIndex = 12;
            this.dtRitorno.ValueChanged += new System.EventHandler(this.dtRitorno_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "PARTI:";
            // 
            // btnInformazioni
            // 
            this.btnInformazioni.BackColor = System.Drawing.Color.Gray;
            this.btnInformazioni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformazioni.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformazioni.Location = new System.Drawing.Point(896, 36);
            this.btnInformazioni.Name = "btnInformazioni";
            this.btnInformazioni.Size = new System.Drawing.Size(181, 69);
            this.btnInformazioni.TabIndex = 16;
            this.btnInformazioni.Text = "FINALE";
            this.btnInformazioni.UseVisualStyleBackColor = false;
            this.btnInformazioni.Click += new System.EventHandler(this.btnInformazioni_Click_1);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(28, 420);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 20);
            this.txtLink.TabIndex = 19;
            this.txtLink.Visible = false;
            // 
            // rbSpecifica
            // 
            this.rbSpecifica.AutoSize = true;
            this.rbSpecifica.Location = new System.Drawing.Point(12, 15);
            this.rbSpecifica.Name = "rbSpecifica";
            this.rbSpecifica.Size = new System.Drawing.Size(98, 17);
            this.rbSpecifica.TabIndex = 20;
            this.rbSpecifica.TabStop = true;
            this.rbSpecifica.Text = "Data Specifica ";
            this.rbSpecifica.UseVisualStyleBackColor = true;
            // 
            // rbIntervallo
            // 
            this.rbIntervallo.AutoSize = true;
            this.rbIntervallo.Location = new System.Drawing.Point(12, 45);
            this.rbIntervallo.Name = "rbIntervallo";
            this.rbIntervallo.Size = new System.Drawing.Size(92, 17);
            this.rbIntervallo.TabIndex = 21;
            this.rbIntervallo.TabStop = true;
            this.rbIntervallo.Text = "Intervallo date";
            this.rbIntervallo.UseVisualStyleBackColor = true;
            // 
            // txtPartenza
            // 
            this.txtPartenza.Location = new System.Drawing.Point(574, 51);
            this.txtPartenza.Name = "txtPartenza";
            this.txtPartenza.ReadOnly = true;
            this.txtPartenza.Size = new System.Drawing.Size(100, 20);
            this.txtPartenza.TabIndex = 22;
            // 
            // panelPartenza
            // 
            this.panelPartenza.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPartenza.Controls.Add(this.rbIntervallo);
            this.panelPartenza.Controls.Add(this.rbSpecifica);
            this.panelPartenza.Controls.Add(this.dtPartenza);
            this.panelPartenza.Controls.Add(this.dtRitorno);
            this.panelPartenza.Location = new System.Drawing.Point(490, 89);
            this.panelPartenza.Name = "panelPartenza";
            this.panelPartenza.Size = new System.Drawing.Size(262, 83);
            this.panelPartenza.TabIndex = 23;
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1475, 813);
            this.tabControl.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbErroreData);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.panelPartenza);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.txtPartenza);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.txtLink);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnInformazioni);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1467, 787);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VOLO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbErroreData
            // 
            this.lbErroreData.AutoSize = true;
            this.lbErroreData.Location = new System.Drawing.Point(636, 189);
            this.lbErroreData.Name = "lbErroreData";
            this.lbErroreData.Size = new System.Drawing.Size(0, 13);
            this.lbErroreData.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureVolo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1467, 787);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SCREEN VOLO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureVolo
            // 
            this.pictureVolo.Location = new System.Drawing.Point(3, 0);
            this.pictureVolo.Name = "pictureVolo";
            this.pictureVolo.Size = new System.Drawing.Size(1456, 779);
            this.pictureVolo.TabIndex = 26;
            this.pictureVolo.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCartina);
            this.tabPage3.Controls.Add(this.txtMeteo);
            this.tabPage3.Controls.Add(this.pictureBoxMeteo);
            this.tabPage3.Controls.Add(this.btnMeteo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1467, 787);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "METEO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtMeteo
            // 
            this.txtMeteo.Location = new System.Drawing.Point(38, 52);
            this.txtMeteo.Name = "txtMeteo";
            this.txtMeteo.Size = new System.Drawing.Size(179, 20);
            this.txtMeteo.TabIndex = 2;
            // 
            // pictureBoxMeteo
            // 
            this.pictureBoxMeteo.Location = new System.Drawing.Point(20, 164);
            this.pictureBoxMeteo.Name = "pictureBoxMeteo";
            this.pictureBoxMeteo.Size = new System.Drawing.Size(1451, 599);
            this.pictureBoxMeteo.TabIndex = 1;
            this.pictureBoxMeteo.TabStop = false;
            // 
            // btnMeteo
            // 
            this.btnMeteo.Location = new System.Drawing.Point(283, 52);
            this.btnMeteo.Name = "btnMeteo";
            this.btnMeteo.Size = new System.Drawing.Size(148, 42);
            this.btnMeteo.TabIndex = 0;
            this.btnMeteo.Text = "METEO";
            this.btnMeteo.UseVisualStyleBackColor = true;
            this.btnMeteo.Click += new System.EventHandler(this.btnMeteo_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBoxCartina);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1467, 787);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CARTINA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCartina
            // 
            this.pictureBoxCartina.Location = new System.Drawing.Point(36, 66);
            this.pictureBoxCartina.Name = "pictureBoxCartina";
            this.pictureBoxCartina.Size = new System.Drawing.Size(1370, 600);
            this.pictureBoxCartina.TabIndex = 1;
            this.pictureBoxCartina.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1467, 787);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1467, 787);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnCartina
            // 
            this.btnCartina.Location = new System.Drawing.Point(582, 66);
            this.btnCartina.Name = "btnCartina";
            this.btnCartina.Size = new System.Drawing.Size(197, 45);
            this.btnCartina.TabIndex = 3;
            this.btnCartina.Text = "button1";
            this.btnCartina.UseVisualStyleBackColor = true;
            this.btnCartina.Click += new System.EventHandler(this.btnCartina_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 813);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPartenza.ResumeLayout(false);
            this.panelPartenza.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureVolo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeteo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPartenza;
        private System.Windows.Forms.DateTimePicker dtRitorno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInformazioni;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.RadioButton rbSpecifica;
        private System.Windows.Forms.RadioButton rbIntervallo;
        private System.Windows.Forms.TextBox txtPartenza;
        private System.Windows.Forms.Panel panelPartenza;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbErroreData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureVolo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMeteo;
        private System.Windows.Forms.TextBox txtMeteo;
        private System.Windows.Forms.PictureBox pictureBoxMeteo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pictureBoxCartina;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnCartina;
    }
}

