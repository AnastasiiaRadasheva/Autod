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
            label4 = new Label();
            Töötaja = new Label();
            workCOMBO = new ComboBox();
            timePicker = new DateTimePicker();
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
            label1.Location = new Point(34, 21);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Auto:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 153);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Aeg:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 71);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Hooldus:";
            label3.Click += label3_Click;
            // 
            // formkoik
            // 
            formkoik.Location = new Point(322, 349);
            formkoik.Margin = new Padding(3, 4, 3, 4);
            formkoik.Name = "formkoik";
            formkoik.Size = new Size(86, 31);
            formkoik.TabIndex = 4;
            formkoik.Text = "Kõik";
            formkoik.UseVisualStyleBackColor = true;
            formkoik.Click += formkoik_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Töötaja);
            panel1.Controls.Add(workCOMBO);
            panel1.Controls.Add(timePicker);
            panel1.Controls.Add(durationUpDown);
            panel1.Controls.Add(startPicker);
            panel1.Controls.Add(paev);
            panel1.Controls.Add(serviceCombo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(autoCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(29, 67);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 275);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 192);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 17;
            label4.Text = "Tunt:";
            // 
            // Töötaja
            // 
            Töötaja.AutoSize = true;
            Töötaja.Location = new Point(34, 235);
            Töötaja.Name = "Töötaja";
            Töötaja.Size = new Size(62, 20);
            Töötaja.TabIndex = 16;
            Töötaja.Text = "Töötaja:";
            // 
            // workCOMBO
            // 
            workCOMBO.FormattingEnabled = true;
            workCOMBO.Location = new Point(98, 231);
            workCOMBO.Margin = new Padding(3, 4, 3, 4);
            workCOMBO.Name = "workCOMBO";
            workCOMBO.Size = new Size(239, 28);
            workCOMBO.TabIndex = 15;
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(98, 153);
            timePicker.Margin = new Padding(3, 4, 3, 4);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(239, 27);
            timePicker.TabIndex = 14;
            timePicker.Value = new DateTime(2025, 12, 11, 12, 0, 0, 0);
            // 
            // durationUpDown
            // 
            durationUpDown.Location = new Point(98, 192);
            durationUpDown.Margin = new Padding(3, 4, 3, 4);
            durationUpDown.Name = "durationUpDown";
            durationUpDown.Size = new Size(240, 27);
            durationUpDown.TabIndex = 13;
            // 
            // startPicker
            // 
            startPicker.Format = DateTimePickerFormat.Short;
            startPicker.Location = new Point(98, 115);
            startPicker.Margin = new Padding(3, 4, 3, 4);
            startPicker.Name = "startPicker";
            startPicker.Size = new Size(239, 27);
            startPicker.TabIndex = 12;
            // 
            // paev
            // 
            paev.AutoSize = true;
            paev.Location = new Point(34, 115);
            paev.Name = "paev";
            paev.Size = new Size(39, 20);
            paev.TabIndex = 8;
            paev.Text = "Paev";
            // 
            // serviceCombo
            // 
            serviceCombo.FormattingEnabled = true;
            serviceCombo.Location = new Point(98, 71);
            serviceCombo.Margin = new Padding(3, 4, 3, 4);
            serviceCombo.Name = "serviceCombo";
            serviceCombo.Size = new Size(239, 28);
            serviceCombo.TabIndex = 11;
            // 
            // autoCombo
            // 
            autoCombo.FormattingEnabled = true;
            autoCombo.Location = new Point(98, 21);
            autoCombo.Margin = new Padding(3, 4, 3, 4);
            autoCombo.Name = "autoCombo";
            autoCombo.Size = new Size(239, 28);
            autoCombo.TabIndex = 10;
            // 
            // Lisa
            // 
            Lisa.AutoSize = true;
            Lisa.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            Lisa.Location = new Point(178, 21);
            Lisa.Name = "Lisa";
            Lisa.Size = new Size(94, 39);
            Lisa.TabIndex = 9;
            Lisa.Text = "Lisa";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(441, 428);
            Controls.Add(Lisa);
            Controls.Add(panel1);
            Controls.Add(formkoik);
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
        private DateTimePicker timePicker;
        private Label label4;
        private Label Töötaja;
        private ComboBox workCOMBO;
    }
}