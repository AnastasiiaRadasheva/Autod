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
            dataGridViewOmanik = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            autotable = new TabPage();
            dataGridView3 = new DataGridView();
            KustutaBTN = new Button();
            lisaBTN = new Button();
            uuendaBTN = new Button();
            comboBox1 = new ComboBox();
            naitaBTN = new Button();
            textlisa = new TextBox();
            texttelefon = new TextBox();
            textkustuta = new TextBox();
            nimi = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textOTS = new TextBox();
            Autod.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanik).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            autotable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // Autod
            // 
            Autod.Controls.Add(tabPage1);
            Autod.Controls.Add(tabPage2);
            Autod.Controls.Add(autotable);
            Autod.Location = new Point(169, 12);
            Autod.Name = "Autod";
            Autod.SelectedIndex = 0;
            Autod.Size = new Size(619, 426);
            Autod.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textOTS);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dataGridViewOmanik);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(611, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Omanikud";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOmanik
            // 
            dataGridViewOmanik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOmanik.Location = new Point(6, 6);
            dataGridViewOmanik.Name = "dataGridViewOmanik";
            dataGridViewOmanik.Size = new Size(599, 301);
            dataGridViewOmanik.TabIndex = 4;
            dataGridViewOmanik.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(611, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Autod";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(599, 301);
            dataGridView2.TabIndex = 0;
            // 
            // autotable
            // 
            autotable.Controls.Add(dataGridView3);
            autotable.Location = new Point(4, 24);
            autotable.Name = "autotable";
            autotable.Padding = new Padding(3);
            autotable.Size = new Size(611, 398);
            autotable.TabIndex = 2;
            autotable.Text = "Hooldus ja Teenused";
            autotable.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 6);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(599, 301);
            dataGridView3.TabIndex = 0;
            // 
            // KustutaBTN
            // 
            KustutaBTN.Location = new Point(88, 214);
            KustutaBTN.Name = "KustutaBTN";
            KustutaBTN.Size = new Size(75, 23);
            KustutaBTN.TabIndex = 3;
            KustutaBTN.Text = "Kustuta";
            KustutaBTN.UseVisualStyleBackColor = true;
            KustutaBTN.Click += KustutaBTN_Click;
            // 
            // lisaBTN
            // 
            lisaBTN.Location = new Point(88, 143);
            lisaBTN.Name = "lisaBTN";
            lisaBTN.Size = new Size(75, 23);
            lisaBTN.TabIndex = 1;
            lisaBTN.Text = "Lisa";
            lisaBTN.UseVisualStyleBackColor = true;
            lisaBTN.Click += lisaBTN_Click;
            // 
            // uuendaBTN
            // 
            uuendaBTN.Location = new Point(88, 185);
            uuendaBTN.Name = "uuendaBTN";
            uuendaBTN.Size = new Size(75, 23);
            uuendaBTN.TabIndex = 2;
            uuendaBTN.Text = "Uuenda";
            uuendaBTN.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 411);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(53, 23);
            comboBox1.TabIndex = 5;
            // 
            // naitaBTN
            // 
            naitaBTN.Location = new Point(88, 36);
            naitaBTN.Name = "naitaBTN";
            naitaBTN.Size = new Size(75, 23);
            naitaBTN.TabIndex = 6;
            naitaBTN.Text = "Näita kõik";
            naitaBTN.UseVisualStyleBackColor = true;
            naitaBTN.Click += button2_Click;
            // 
            // textlisa
            // 
            textlisa.Location = new Point(63, 85);
            textlisa.Name = "textlisa";
            textlisa.Size = new Size(100, 23);
            textlisa.TabIndex = 7;
            // 
            // texttelefon
            // 
            texttelefon.Location = new Point(63, 114);
            texttelefon.Name = "texttelefon";
            texttelefon.Size = new Size(100, 23);
            texttelefon.TabIndex = 8;
            // 
            // textkustuta
            // 
            textkustuta.Location = new Point(63, 320);
            textkustuta.Name = "textkustuta";
            textkustuta.Size = new Size(100, 23);
            textkustuta.TabIndex = 9;
            // 
            // nimi
            // 
            nimi.AutoSize = true;
            nimi.Location = new Point(12, 85);
            nimi.Name = "nimi";
            nimi.Size = new Size(36, 15);
            nimi.TabIndex = 10;
            nimi.Text = "Nimi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 11;
            label2.Text = "Telefon:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 376);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 336);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Otsi Nimi/Autod";
            // 
            // textOTS
            // 
            textOTS.Location = new Point(107, 333);
            textOTS.Name = "textOTS";
            textOTS.Size = new Size(144, 23);
            textOTS.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(nimi);
            Controls.Add(textkustuta);
            Controls.Add(texttelefon);
            Controls.Add(textlisa);
            Controls.Add(naitaBTN);
            Controls.Add(comboBox1);
            Controls.Add(Autod);
            Controls.Add(lisaBTN);
            Controls.Add(KustutaBTN);
            Controls.Add(uuendaBTN);
            Name = "Form1";
            Text = "Autod";
            Autod.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanik).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            autotable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
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
        private TextBox textkustuta;
        private Label nimi;
        private Label label2;
        private TextBox textOTS;
        private Label label3;
        private Label label1;
    }
}
