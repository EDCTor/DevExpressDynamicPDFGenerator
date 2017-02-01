namespace DevExpressDynamicPDFGenerator
{
    partial class frmMain
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
            this.btnDesigner = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesigner
            // 
            this.btnDesigner.Location = new System.Drawing.Point(202, 33);
            this.btnDesigner.Name = "btnDesigner";
            this.btnDesigner.Size = new System.Drawing.Size(163, 100);
            this.btnDesigner.TabIndex = 1;
            this.btnDesigner.Text = "View Designer";
            this.btnDesigner.UseVisualStyleBackColor = true;
            this.btnDesigner.Click += new System.EventHandler(this.btnDesigner_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(33, 33);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(163, 100);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(371, 33);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(163, 100);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "Save As PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 165);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDesigner);
            this.Name = "frmMain";
            this.Text = "Dynamic PDF Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesigner;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPDF;
    }
}

