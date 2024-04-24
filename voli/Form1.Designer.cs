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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblbudget = new System.Windows.Forms.Label();
            this.dtPartenza = new System.Windows.Forms.DateTimePicker();
            this.dtRitorno = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInformazioni = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.rbSpecifica = new System.Windows.Forms.RadioButton();
            this.rbIntervallo = new System.Windows.Forms.RadioButton();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.panelPartenza = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelPartenza.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 303);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 52);
            this.textBox2.Name = "textBox2";
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
            this.label2.Location = new System.Drawing.Point(374, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "A:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "20",
            "50",
            "60",
            "80",
            "100",
            "150"});
            this.comboBox1.Location = new System.Drawing.Point(544, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // lblbudget
            // 
            this.lblbudget.AutoSize = true;
            this.lblbudget.Location = new System.Drawing.Point(562, 36);
            this.lblbudget.Name = "lblbudget";
            this.lblbudget.Size = new System.Drawing.Size(52, 13);
            this.lblbudget.TabIndex = 10;
            this.lblbudget.Text = "BUDGET";
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
            this.label3.Location = new System.Drawing.Point(735, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "PARTI:";
            // 
            // btnInformazioni
            // 
            this.btnInformazioni.Location = new System.Drawing.Point(66, 607);
            this.btnInformazioni.Name = "btnInformazioni";
            this.btnInformazioni.Size = new System.Drawing.Size(159, 51);
            this.btnInformazioni.TabIndex = 16;
            this.btnInformazioni.Text = "FINALE";
            this.btnInformazioni.UseVisualStyleBackColor = true;
            this.btnInformazioni.Click += new System.EventHandler(this.btnInformazioni_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CITTA\'",
            "FAMIGLIA",
            "GOLF ",
            "VITA NOTTURNA",
            "ALL\'APERTO",
            "MARE"});
            this.comboBox2.Location = new System.Drawing.Point(966, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(982, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "CATEGORIA VIAGGIO:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(66, 420);
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
            this.txtPartenza.Location = new System.Drawing.Point(706, 52);
            this.txtPartenza.Name = "txtPartenza";
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
            this.panelPartenza.Location = new System.Drawing.Point(622, 90);
            this.panelPartenza.Name = "panelPartenza";
            this.panelPartenza.Size = new System.Drawing.Size(262, 83);
            this.panelPartenza.TabIndex = 23;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1325, 756);
            this.tabControl.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.panelPartenza);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.txtPartenza);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.txtLink);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btnInformazioni);
            this.tabPage1.Controls.Add(this.lblbudget);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1298, 748);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1298, 748);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 756);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
          
            this.panelPartenza.ResumeLayout(false);
            this.panelPartenza.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblbudget;
        private System.Windows.Forms.DateTimePicker dtPartenza;
        private System.Windows.Forms.DateTimePicker dtRitorno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInformazioni;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.RadioButton rbSpecifica;
        private System.Windows.Forms.RadioButton rbIntervallo;
        private System.Windows.Forms.TextBox txtPartenza;
        private System.Windows.Forms.Panel panelPartenza;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

