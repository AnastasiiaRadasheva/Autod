namespace Autod
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            checkedListBoxAutod = new CheckedListBox();
            koikBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // checkedListBoxAutod
            // 
            resources.ApplyResources(checkedListBoxAutod, "checkedListBoxAutod");
            checkedListBoxAutod.FormattingEnabled = true;
            checkedListBoxAutod.Name = "checkedListBoxAutod";
            // 
            // koikBTN
            // 
            resources.ApplyResources(koikBTN, "koikBTN");
            koikBTN.Name = "koikBTN";
            koikBTN.UseVisualStyleBackColor = true;
            koikBTN.Click += button1_Click;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(koikBTN);
            Controls.Add(checkedListBoxAutod);
            Controls.Add(label1);
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBoxAutod;
        private Button koikBTN;
    }
}