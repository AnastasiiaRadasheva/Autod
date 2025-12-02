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
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            autotable = new TabPage();
            dataGridView3 = new DataGridView();
            KustutaBTN = new Button();
            lisaBTN = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            Autod.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(611, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Omanikud";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(599, 301);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            KustutaBTN.Location = new Point(39, 123);
            KustutaBTN.Name = "KustutaBTN";
            KustutaBTN.Size = new Size(75, 23);
            KustutaBTN.TabIndex = 3;
            KustutaBTN.Text = "Delete";
            KustutaBTN.UseVisualStyleBackColor = true;
            KustutaBTN.Click += KustutaBTN_Click;
            // 
            // lisaBTN
            // 
            lisaBTN.Location = new Point(39, 65);
            lisaBTN.Name = "lisaBTN";
            lisaBTN.Size = new Size(75, 23);
            lisaBTN.TabIndex = 1;
            lisaBTN.Text = "Lisa";
            lisaBTN.UseVisualStyleBackColor = true;
            lisaBTN.Click += lisaBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 94);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(Autod);
            Controls.Add(lisaBTN);
            Controls.Add(KustutaBTN);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Autod";
            Autod.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            autotable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Autod;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button lisaBTN;
        private Button button1;
        private Button KustutaBTN;
        private DataGridView dataGridView1;
        private TabPage autotable;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private ComboBox comboBox1;
    }
}
