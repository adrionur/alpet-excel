namespace ExcelComparison
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
            btnExcel1 = new Button();
            btnExcel2 = new Button();
            txtFilePath1 = new TextBox();
            txtFilePath2 = new TextBox();
            btnCompare = new Button();
            SuspendLayout();
            // 
            // btnExcel1
            // 
            btnExcel1.Location = new Point(75, 36);
            btnExcel1.Name = "btnExcel1";
            btnExcel1.Size = new Size(94, 29);
            btnExcel1.TabIndex = 0;
            btnExcel1.Text = "Excel 1";
            btnExcel1.UseVisualStyleBackColor = true;
            btnExcel1.Click += buttonGetFile_Click;
            // 
            // btnExcel2
            // 
            btnExcel2.Location = new Point(75, 83);
            btnExcel2.Name = "btnExcel2";
            btnExcel2.Size = new Size(94, 29);
            btnExcel2.TabIndex = 1;
            btnExcel2.Text = "Excel 2";
            btnExcel2.UseVisualStyleBackColor = true;
            btnExcel2.Click += buttonGetFile_Click;
            // 
            // txtFilePath1
            // 
            txtFilePath1.Location = new Point(190, 36);
            txtFilePath1.Name = "txtFilePath1";
            txtFilePath1.Size = new Size(502, 27);
            txtFilePath1.TabIndex = 2;
            // 
            // txtFilePath2
            // 
            txtFilePath2.Location = new Point(190, 85);
            txtFilePath2.Name = "txtFilePath2";
            txtFilePath2.Size = new Size(502, 27);
            txtFilePath2.TabIndex = 3;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(75, 170);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(94, 29);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 267);
            Controls.Add(btnCompare);
            Controls.Add(txtFilePath2);
            Controls.Add(txtFilePath1);
            Controls.Add(btnExcel2);
            Controls.Add(btnExcel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcel1;
        private Button btnExcel2;
        private TextBox txtFilePath1;
        private TextBox txtFilePath2;
        private Button btnCompare;
    }
}