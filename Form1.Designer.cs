namespace Autod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Autod = new TabControl();
            tabPage1 = new TabPage();
            textOTS = new TextBox();
            label3 = new Label();
            dataGridViewOmanik = new DataGridView();
            tabPage2 = new TabPage();
            textBox2 = new TextBox();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            autotable = new TabPage();
            textBox1 = new TextBox();
            label5 = new Label();
            dataGridView3 = new DataGridView();
            label2 = new Label();
            nimi = new Label();
            KustutaBTN = new Button();
            textlisa = new TextBox();
            uuendaBTN = new Button();
            texttelefon = new TextBox();
            lisaBTN = new Button();
            comboBox1 = new ComboBox();
            naitaBTN = new Button();
            label1 = new Label();
            panel1 = new Panel();
            listBoxAuto = new ListBox();
            AutoVali = new Button();
            label6 = new Label();
            label7 = new Label();
            Autod.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanik).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            autotable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Autod
            // 
            Autod.Controls.Add(tabPage1);
            Autod.Controls.Add(tabPage2);
            Autod.Controls.Add(autotable);
            Autod.Location = new Point(12, 45);
            Autod.Name = "Autod";
            Autod.SelectedIndex = 0;
            Autod.Size = new Size(619, 345);
            Autod.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(textOTS);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dataGridViewOmanik);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(611, 317);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Omanikud";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textOTS
            // 
            textOTS.Location = new Point(442, 218);
            textOTS.Name = "textOTS";
            textOTS.Size = new Size(144, 23);
            textOTS.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 221);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Otsi Nimi/Autod";
            // 
            // dataGridViewOmanik
            // 
            dataGridViewOmanik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOmanik.Location = new Point(6, 6);
            dataGridViewOmanik.Name = "dataGridViewOmanik";
            dataGridViewOmanik.Size = new Size(330, 301);
            dataGridViewOmanik.TabIndex = 4;
            dataGridViewOmanik.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(611, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Autod";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(38, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 340);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 1;
            label4.Text = "otsi";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(599, 301);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // autotable
            // 
            autotable.Controls.Add(textBox1);
            autotable.Controls.Add(label5);
            autotable.Controls.Add(dataGridView3);
            autotable.Location = new Point(4, 24);
            autotable.Name = "autotable";
            autotable.Padding = new Padding(3);
            autotable.Size = new Size(611, 388);
            autotable.TabIndex = 2;
            autotable.Text = "Hooldus ja Teenused";
            autotable.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 332);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 340);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 1;
            label5.Text = "otsi : ";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 6);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(599, 301);
            dataGridView3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 32);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Telefon :";
            label2.Click += label2_Click;
            // 
            // nimi
            // 
            nimi.AutoSize = true;
            nimi.Location = new Point(18, 9);
            nimi.Name = "nimi";
            nimi.Size = new Size(39, 15);
            nimi.TabIndex = 10;
            nimi.Text = "Nimi :";
            // 
            // KustutaBTN
            // 
            KustutaBTN.BackColor = Color.Firebrick;
            KustutaBTN.FlatStyle = FlatStyle.Popup;
            KustutaBTN.ForeColor = Color.White;
            KustutaBTN.Location = new Point(7, 113);
            KustutaBTN.Name = "KustutaBTN";
            KustutaBTN.Size = new Size(75, 23);
            KustutaBTN.TabIndex = 3;
            KustutaBTN.Text = "Kustuta";
            KustutaBTN.UseVisualStyleBackColor = false;
            KustutaBTN.Click += KustutaBTN_Click;
            // 
            // textlisa
            // 
            textlisa.Location = new Point(83, 6);
            textlisa.Name = "textlisa";
            textlisa.Size = new Size(173, 23);
            textlisa.TabIndex = 7;
            // 
            // uuendaBTN
            // 
            uuendaBTN.FlatStyle = FlatStyle.Flat;
            uuendaBTN.ForeColor = SystemColors.ActiveCaption;
            uuendaBTN.Location = new Point(118, 113);
            uuendaBTN.Name = "uuendaBTN";
            uuendaBTN.Size = new Size(74, 23);
            uuendaBTN.TabIndex = 2;
            uuendaBTN.Text = "Uuenda";
            uuendaBTN.UseVisualStyleBackColor = true;
            uuendaBTN.Click += uuendaBTN_Click;
            // 
            // texttelefon
            // 
            texttelefon.Location = new Point(83, 32);
            texttelefon.Name = "texttelefon";
            texttelefon.Size = new Size(173, 23);
            texttelefon.TabIndex = 8;
            texttelefon.TextChanged += texttelefon_TextChanged;
            // 
            // lisaBTN
            // 
            lisaBTN.FlatStyle = FlatStyle.Flat;
            lisaBTN.ForeColor = Color.DarkGreen;
            lisaBTN.Location = new Point(198, 113);
            lisaBTN.Name = "lisaBTN";
            lisaBTN.Size = new Size(58, 23);
            lisaBTN.TabIndex = 1;
            lisaBTN.Text = "Lisa";
            lisaBTN.UseVisualStyleBackColor = true;
            lisaBTN.Click += lisaBTN_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(578, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(53, 23);
            comboBox1.TabIndex = 5;
            // 
            // naitaBTN
            // 
            naitaBTN.Location = new Point(637, 111);
            naitaBTN.Name = "naitaBTN";
            naitaBTN.Size = new Size(93, 37);
            naitaBTN.TabIndex = 6;
            naitaBTN.Text = "Näita kõik";
            naitaBTN.UseVisualStyleBackColor = true;
            naitaBTN.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 16);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 12;
            label1.Text = "Keel:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(listBoxAuto);
            panel1.Controls.Add(AutoVali);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textlisa);
            panel1.Controls.Add(uuendaBTN);
            panel1.Controls.Add(texttelefon);
            panel1.Controls.Add(KustutaBTN);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lisaBTN);
            panel1.Controls.Add(nimi);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(341, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 146);
            panel1.TabIndex = 13;
            // 
            // listBoxAuto
            // 
            listBoxAuto.FormattingEnabled = true;
            listBoxAuto.ItemHeight = 15;
            listBoxAuto.Location = new Point(83, 58);
            listBoxAuto.Name = "listBoxAuto";
            listBoxAuto.Size = new Size(173, 49);
            listBoxAuto.TabIndex = 14;
            // 
            // AutoVali
            // 
            AutoVali.Location = new Point(5, 76);
            AutoVali.Name = "AutoVali";
            AutoVali.Size = new Size(49, 23);
            AutoVali.TabIndex = 13;
            AutoVali.Text = "Vali";
            AutoVali.UseVisualStyleBackColor = true;
            AutoVali.Click += AutoVali_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 58);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 12;
            label6.Text = "Auto :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(348, 6);
            label7.Name = "label7";
            label7.Size = new Size(251, 31);
            label7.TabIndex = 14;
            label7.Text = "OMANIK TABEL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 409);
            Controls.Add(label1);
            Controls.Add(naitaBTN);
            Controls.Add(comboBox1);
            Controls.Add(Autod);
            Name = "Form1";
            Text = "Autod";
            Autod.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanik).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            autotable.ResumeLayout(false);
            autotable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl Autod;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button lisaBTN;
        private Button uuendaBTN;
        private Button KustutaBTN;
        private DataGridView dataGridViewOmanik;
        private TabPage autotable;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private ComboBox comboBox1;
        private Button naitaBTN;
        private TextBox textlisa;
        private TextBox texttelefon;
        private Label nimi;
        private Label label2;
        private TextBox textOTS;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Panel panel1;
        private Label label6;
        private Button AutoVali;
        private ListBox listBoxAuto;
        private Label label7;
    }
}
