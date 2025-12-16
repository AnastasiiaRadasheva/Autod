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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            formkoik = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            // formkoik
            // 
            resources.ApplyResources(formkoik, "formkoik");
            formkoik.Name = "formkoik";
            formkoik.Click += formkoik_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Töötaja);
            panel1.Controls.Add(workCOMBO);
            panel1.Controls.Add(timePicker);
            panel1.Controls.Add(durationUpDown);
            panel1.Controls.Add(startPicker);
            panel1.Controls.Add(paev);
            panel1.Controls.Add(serviceCombo);
            panel1.Controls.Add(autoCombo);
            panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // Töötaja
            // 
            resources.ApplyResources(Töötaja, "Töötaja");
            Töötaja.Name = "Töötaja";
            // 
            // workCOMBO
            // 
            resources.ApplyResources(workCOMBO, "workCOMBO");
            workCOMBO.Name = "workCOMBO";
            // 
            // timePicker
            // 
            resources.ApplyResources(timePicker, "timePicker");
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Value = new DateTime(2025, 12, 11, 12, 0, 0, 0);
            // 
            // durationUpDown
            // 
            resources.ApplyResources(durationUpDown, "durationUpDown");
            durationUpDown.Name = "durationUpDown";
            // 
            // startPicker
            // 
            resources.ApplyResources(startPicker, "startPicker");
            startPicker.Format = DateTimePickerFormat.Short;
            startPicker.Name = "startPicker";
            // 
            // paev
            // 
            resources.ApplyResources(paev, "paev");
            paev.Name = "paev";
            // 
            // serviceCombo
            // 
            resources.ApplyResources(serviceCombo, "serviceCombo");
            serviceCombo.FormattingEnabled = true;
            serviceCombo.Name = "serviceCombo";
            // 
            // autoCombo
            // 
            resources.ApplyResources(autoCombo, "autoCombo");
            autoCombo.FormattingEnabled = true;
            autoCombo.Name = "autoCombo";
            // 
            // Lisa
            // 
            resources.ApplyResources(Lisa, "Lisa");
            Lisa.Name = "Lisa";
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(Lisa);
            Controls.Add(panel1);
            Controls.Add(formkoik);
            Name = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)durationUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label3;
        private Label label2;
        private Label label1;
    }
}