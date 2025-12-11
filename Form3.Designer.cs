namespace Autod
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            formkoik = new Button();
            panel1 = new Panel();
            durationUpDown = new NumericUpDown();
            startPicker = new DateTimePicker();
            paev = new Label();
            serviceCombo = new ComboBox();
            autoCombo = new ComboBox();
            Lisa = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)durationUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Auto:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 121);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Aeg:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 53);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Hooldus:";
            label3.Click += label3_Click;
            // 
            // formkoik
            // 
            formkoik.Location = new Point(282, 224);
            formkoik.Name = "formkoik";
            formkoik.Size = new Size(75, 23);
            formkoik.TabIndex = 4;
            formkoik.Text = "Kõik";
            formkoik.UseVisualStyleBackColor = true;
            formkoik.Click += formkoik_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(durationUpDown);
            panel1.Controls.Add(startPicker);
            panel1.Controls.Add(paev);
            panel1.Controls.Add(serviceCombo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(autoCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(25, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 157);
            panel1.TabIndex = 8;
            // 
            // durationUpDown
            // 
            durationUpDown.Location = new Point(86, 118);
            durationUpDown.Name = "durationUpDown";
            durationUpDown.Size = new Size(210, 23);
            durationUpDown.TabIndex = 13;
            // 
            // startPicker
            // 
            startPicker.Location = new Point(86, 86);
            startPicker.Name = "startPicker";
            startPicker.Size = new Size(210, 23);
            startPicker.TabIndex = 12;
            // 
            // paev
            // 
            paev.AutoSize = true;
            paev.Location = new Point(30, 86);
            paev.Name = "paev";
            paev.Size = new Size(32, 15);
            paev.TabIndex = 8;
            paev.Text = "Paev";
            // 
            // serviceCombo
            // 
            serviceCombo.FormattingEnabled = true;
            serviceCombo.Location = new Point(86, 53);
            serviceCombo.Name = "serviceCombo";
            serviceCombo.Size = new Size(210, 23);
            serviceCombo.TabIndex = 11;
            // 
            // autoCombo
            // 
            autoCombo.FormattingEnabled = true;
            autoCombo.Location = new Point(86, 16);
            autoCombo.Name = "autoCombo";
            autoCombo.Size = new Size(210, 23);
            autoCombo.TabIndex = 10;
            // 
            // Lisa
            // 
            Lisa.AutoSize = true;
            Lisa.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            Lisa.Location = new Point(156, 16);
            Lisa.Name = "Lisa";
            Lisa.Size = new Size(76, 31);
            Lisa.TabIndex = 9;
            Lisa.Text = "Lisa";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(387, 283);
            Controls.Add(Lisa);
            Controls.Add(panel1);
            Controls.Add(formkoik);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Lisa ";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)durationUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button formkoik;
        private Panel panel1;
        private Label Lisa;
        private ComboBox autoCombo;
        private ComboBox serviceCombo;
        private NumericUpDown durationUpDown;
        private DateTimePicker startPicker;
        private Label paev;
    }
}