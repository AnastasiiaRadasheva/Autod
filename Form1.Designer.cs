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
            tabPage2 = new TabPage();
            lisaBTN = new Button();
            button1 = new Button();
            KustutaBTN = new Button();
            dataGridView1 = new DataGridView();
            Autod.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Autod
            // 
            Autod.Controls.Add(tabPage1);
            Autod.Controls.Add(tabPage2);
            Autod.Location = new Point(169, 12);
            Autod.Name = "Autod";
            Autod.SelectedIndex = 0;
            Autod.Size = new Size(619, 426);
            Autod.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(KustutaBTN);
            tabPage1.Controls.Add(lisaBTN);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(611, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(611, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lisaBTN
            // 
            lisaBTN.Location = new Point(84, 224);
            lisaBTN.Name = "lisaBTN";
            lisaBTN.Size = new Size(75, 23);
            lisaBTN.TabIndex = 1;
            lisaBTN.Text = "Lisa";
            lisaBTN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 224);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // KustutaBTN
            // 
            KustutaBTN.Location = new Point(165, 224);
            KustutaBTN.Name = "KustutaBTN";
            KustutaBTN.Size = new Size(75, 23);
            KustutaBTN.TabIndex = 3;
            KustutaBTN.Text = "button2";
            KustutaBTN.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(459, 212);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Autod);
            Name = "Form1";
            Text = "Autod";
            Autod.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
