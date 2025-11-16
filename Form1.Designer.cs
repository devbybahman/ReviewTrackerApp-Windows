namespace PdfTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlTop = new Panel();
            btnAddPdf = new Button();
            txtNewPdfName = new TextBox();
            pnlPdfList = new Panel();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.WhiteSmoke;
            pnlTop.Controls.Add(btnAddPdf);
            pnlTop.Controls.Add(txtNewPdfName);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(720, 85);
            pnlTop.TabIndex = 0;
            // 
            // btnAddPdf
            // 
            btnAddPdf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddPdf.AutoSize = true;
            btnAddPdf.BackColor = SystemColors.ButtonFace;
            btnAddPdf.FlatStyle = FlatStyle.System;
            btnAddPdf.ForeColor = Color.Black;
            btnAddPdf.Location = new Point(542, 10);
            btnAddPdf.Margin = new Padding(3, 4, 3, 4);
            btnAddPdf.Name = "btnAddPdf";
            btnAddPdf.Size = new Size(169, 53);
            btnAddPdf.TabIndex = 1;
            btnAddPdf.Text = "Add New Item (+)";
            btnAddPdf.UseVisualStyleBackColor = false;
            btnAddPdf.Click += btnAddPdf_Click;
            // 
            // txtNewPdfName
            // 
            txtNewPdfName.BackColor = SystemColors.ControlLightLight;
            txtNewPdfName.Location = new Point(21, 13);
            txtNewPdfName.Margin = new Padding(3, 4, 3, 4);
            txtNewPdfName.Multiline = true;
            txtNewPdfName.Name = "txtNewPdfName";
            txtNewPdfName.Size = new Size(483, 53);
            txtNewPdfName.TabIndex = 0;
            // 
            // pnlPdfList
            // 
            pnlPdfList.AutoScroll = true;
            pnlPdfList.BackColor = Color.White;
            pnlPdfList.Dock = DockStyle.Fill;
            pnlPdfList.Location = new Point(0, 85);
            pnlPdfList.Name = "pnlPdfList";
            pnlPdfList.Size = new Size(720, 507);
            pnlPdfList.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(720, 592);
            Controls.Add(pnlPdfList);
            Controls.Add(pnlTop);
            Font = new Font("Arad", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Review Tracker";
            Load += Form1_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnAddPdf;
        private TextBox txtNewPdfName;
        private Panel pnlPdfList;
    }
}
