namespace SerializeFolderStruct
{
    partial class MainForm
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
            this.btnSer = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDeser = new System.Windows.Forms.Button();
            this.lbDes = new System.Windows.Forms.Label();
            this.lbSer = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSer
            // 
            this.btnSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSer.Location = new System.Drawing.Point(177, 13);
            this.btnSer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSer.Name = "btnSer";
            this.btnSer.Size = new System.Drawing.Size(112, 68);
            this.btnSer.TabIndex = 0;
            this.btnSer.Text = "Select Folder";
            this.btnSer.UseVisualStyleBackColor = true;
            this.btnSer.Click += new System.EventHandler(this.btnSer_Click);
            // 
            // btnDeser
            // 
            this.btnDeser.Enabled = false;
            this.btnDeser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeser.Location = new System.Drawing.Point(177, 101);
            this.btnDeser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeser.Name = "btnDeser";
            this.btnDeser.Size = new System.Drawing.Size(112, 68);
            this.btnDeser.TabIndex = 2;
            this.btnDeser.Text = "Select Folder";
            this.btnDeser.UseVisualStyleBackColor = true;
            this.btnDeser.Click += new System.EventHandler(this.btnDeser_Click);
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDes.Location = new System.Drawing.Point(12, 126);
            this.lbDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(148, 18);
            this.lbDes.TabIndex = 3;
            this.lbDes.Text = "Folder to extract tree:";
            // 
            // lbSer
            // 
            this.lbSer.AutoSize = true;
            this.lbSer.Location = new System.Drawing.Point(12, 38);
            this.lbSer.Name = "lbSer";
            this.lbSer.Size = new System.Drawing.Size(139, 18);
            this.lbSer.TabIndex = 4;
            this.lbSer.Text = "File tree to serialize:";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.Location = new System.Drawing.Point(36, 183);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbStatus.Size = new System.Drawing.Size(244, 59);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 262);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbSer);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.btnDeser);
            this.Controls.Add(this.btnSer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "GL trial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnDeser;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label lbSer;
        private System.Windows.Forms.Label lbStatus;
    }
}

