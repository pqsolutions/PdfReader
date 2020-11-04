namespace PDFReader
{
    partial class frmPdfReader
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
            System.Windows.Forms.Button btnSubmit;
            this.rtbPdfContent = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBlowse = new System.Windows.Forms.Button();
            btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSubmit.Location = new System.Drawing.Point(900, 27);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(100, 34);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbPdfContent
            // 
            this.rtbPdfContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPdfContent.Location = new System.Drawing.Point(12, 71);
            this.rtbPdfContent.Name = "rtbPdfContent";
            this.rtbPdfContent.Size = new System.Drawing.Size(1099, 607);
            this.rtbPdfContent.TabIndex = 0;
            this.rtbPdfContent.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(12, 31);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(767, 26);
            this.txtFileName.TabIndex = 1;
            // 
            // btnBlowse
            // 
            this.btnBlowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlowse.Location = new System.Drawing.Point(785, 27);
            this.btnBlowse.Name = "btnBlowse";
            this.btnBlowse.Size = new System.Drawing.Size(100, 34);
            this.btnBlowse.TabIndex = 2;
            this.btnBlowse.Text = "Browse";
            this.btnBlowse.UseVisualStyleBackColor = true;
            this.btnBlowse.Click += new System.EventHandler(this.btnBlowse_Click);
            // 
            // frmPdfReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 690);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(this.btnBlowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.rtbPdfContent);
            this.Name = "frmPdfReader";
            this.Text = "PDF Reader";
            this.Load += new System.EventHandler(this.frmPdfReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPdfContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBlowse;
    }
}

