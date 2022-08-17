namespace DB_With_Images
{
    partial class Images
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
            this.groupBoxAddLoadImages = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBoxAddLoad = new System.Windows.Forms.PictureBox();
            this.groupBoxFetchImages = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.pictureBoxFetch = new System.Windows.Forms.PictureBox();
            this.groupBoxAddLoadImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddLoad)).BeginInit();
            this.groupBoxFetchImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFetch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddLoadImages
            // 
            this.groupBoxAddLoadImages.Controls.Add(this.btnSave);
            this.groupBoxAddLoadImages.Controls.Add(this.btnLoad);
            this.groupBoxAddLoadImages.Controls.Add(this.pictureBoxAddLoad);
            this.groupBoxAddLoadImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddLoadImages.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddLoadImages.Name = "groupBoxAddLoadImages";
            this.groupBoxAddLoadImages.Size = new System.Drawing.Size(318, 372);
            this.groupBoxAddLoadImages.TabIndex = 0;
            this.groupBoxAddLoadImages.TabStop = false;
            this.groupBoxAddLoadImages.Text = "Add / Load Images";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(31, 265);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 34);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBoxAddLoad
            // 
            this.pictureBoxAddLoad.Location = new System.Drawing.Point(31, 41);
            this.pictureBoxAddLoad.Name = "pictureBoxAddLoad";
            this.pictureBoxAddLoad.Size = new System.Drawing.Size(257, 203);
            this.pictureBoxAddLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAddLoad.TabIndex = 0;
            this.pictureBoxAddLoad.TabStop = false;
            // 
            // groupBoxFetchImages
            // 
            this.groupBoxFetchImages.Controls.Add(this.textBoxID);
            this.groupBoxFetchImages.Controls.Add(this.labelID);
            this.groupBoxFetchImages.Controls.Add(this.btnFetch);
            this.groupBoxFetchImages.Controls.Add(this.pictureBoxFetch);
            this.groupBoxFetchImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFetchImages.Location = new System.Drawing.Point(356, 12);
            this.groupBoxFetchImages.Name = "groupBoxFetchImages";
            this.groupBoxFetchImages.Size = new System.Drawing.Size(318, 372);
            this.groupBoxFetchImages.TabIndex = 3;
            this.groupBoxFetchImages.TabStop = false;
            this.groupBoxFetchImages.Text = "Fetch Images";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(71, 265);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PasswordChar = '$';
            this.textBoxID.Size = new System.Drawing.Size(222, 26);
            this.textBoxID.TabIndex = 4;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(32, 268);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(33, 20);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID:";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(36, 317);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(106, 34);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // pictureBoxFetch
            // 
            this.pictureBoxFetch.Location = new System.Drawing.Point(36, 38);
            this.pictureBoxFetch.Name = "pictureBoxFetch";
            this.pictureBoxFetch.Size = new System.Drawing.Size(257, 203);
            this.pictureBoxFetch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFetch.TabIndex = 0;
            this.pictureBoxFetch.TabStop = false;
            // 
            // Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 405);
            this.Controls.Add(this.groupBoxFetchImages);
            this.Controls.Add(this.groupBoxAddLoadImages);
            this.Name = "Images";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Images_Load);
            this.groupBoxAddLoadImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddLoad)).EndInit();
            this.groupBoxFetchImages.ResumeLayout(false);
            this.groupBoxFetchImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFetch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddLoadImages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pictureBoxAddLoad;
        private System.Windows.Forms.GroupBox groupBoxFetchImages;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.PictureBox pictureBoxFetch;
    }
}

