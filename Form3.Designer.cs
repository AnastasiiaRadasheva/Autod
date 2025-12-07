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
            koikBTNteen = new Button();
            checkedListBoxTeenus = new CheckedListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // koikBTNteen
            // 
            koikBTNteen.Location = new Point(303, 542);
            koikBTNteen.Margin = new Padding(3, 4, 3, 4);
            koikBTNteen.Name = "koikBTNteen";
            koikBTNteen.Size = new Size(86, 31);
            koikBTNteen.TabIndex = 5;
            koikBTNteen.Text = "Kõik";
            koikBTNteen.UseVisualStyleBackColor = true;
            koikBTNteen.Click += koikBTNteen_Click;
            // 
            // checkedListBoxTeenus
            // 
            checkedListBoxTeenus.FormattingEnabled = true;
            checkedListBoxTeenus.Location = new Point(52, 35);
            checkedListBoxTeenus.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxTeenus.Name = "checkedListBoxTeenus";
            checkedListBoxTeenus.Size = new Size(337, 488);
            checkedListBoxTeenus.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Colonna MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 28);
            label1.TabIndex = 3;
            label1.Text = "Vali teie teenused!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 586);
            Controls.Add(koikBTNteen);
            Controls.Add(checkedListBoxTeenus);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button koikBTNteen;
        private CheckedListBox checkedListBoxTeenus;
        private Label label1;
    }
}