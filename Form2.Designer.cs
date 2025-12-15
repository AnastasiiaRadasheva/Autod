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
            label1 = new Label();
            checkedListBoxAutod = new CheckedListBox();
            koikBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Colonna MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 13);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 0;
            label1.Text = "Vali teie autod!";
            // 
            // checkedListBoxAutod
            // 
            checkedListBoxAutod.FormattingEnabled = true;
            checkedListBoxAutod.Location = new Point(24, 45);
            checkedListBoxAutod.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxAutod.Name = "checkedListBoxAutod";
            checkedListBoxAutod.Size = new Size(337, 488);
            checkedListBoxAutod.TabIndex = 1;
            // 
            // koikBTN
            // 
            koikBTN.Location = new Point(275, 559);
            koikBTN.Margin = new Padding(3, 4, 3, 4);
            koikBTN.Name = "koikBTN";
            koikBTN.Size = new Size(86, 31);
            koikBTN.TabIndex = 2;
            koikBTN.Text = "Kõik";
            koikBTN.UseVisualStyleBackColor = true;
            koikBTN.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 605);
            Controls.Add(koikBTN);
            Controls.Add(checkedListBoxAutod);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
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