namespace Buttons
{
    partial class Buttons
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
            this.CopyNameToComment = new System.Windows.Forms.Button();
            this.CopyCommentToProductWebSite = new System.Windows.Forms.Button();
            this.UpdateFields = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteFields = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CopyNameToComment
            // 
            this.CopyNameToComment.Location = new System.Drawing.Point(13, 12);
            this.CopyNameToComment.Name = "CopyNameToComment";
            this.CopyNameToComment.Size = new System.Drawing.Size(221, 45);
            this.CopyNameToComment.TabIndex = 0;
            this.CopyNameToComment.Text = "CopyNameToComment";
            this.CopyNameToComment.UseVisualStyleBackColor = true;
            this.CopyNameToComment.Click += new System.EventHandler(this.CopyNameToComment_Click);
            // 
            // CopyCommentToProductWebSite
            // 
            this.CopyCommentToProductWebSite.Location = new System.Drawing.Point(12, 63);
            this.CopyCommentToProductWebSite.Name = "CopyCommentToProductWebSite";
            this.CopyCommentToProductWebSite.Size = new System.Drawing.Size(221, 45);
            this.CopyCommentToProductWebSite.TabIndex = 1;
            this.CopyCommentToProductWebSite.Text = "CopyCommentToProductWebSite";
            this.CopyCommentToProductWebSite.UseVisualStyleBackColor = true;
            this.CopyCommentToProductWebSite.Click += new System.EventHandler(this.CopyCommentToProductWebSite_Click);
            // 
            // UpdateFields
            // 
            this.UpdateFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFields.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateFields.Location = new System.Drawing.Point(240, 12);
            this.UpdateFields.Name = "UpdateFields";
            this.UpdateFields.Size = new System.Drawing.Size(379, 96);
            this.UpdateFields.TabIndex = 2;
            this.UpdateFields.Text = "Update Fields";
            this.UpdateFields.UseVisualStyleBackColor = true;
            this.UpdateFields.Click += new System.EventHandler(this.UpdateFields_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(13, 114);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(991, 182);
            this.DataGridView.TabIndex = 3;
            // 
            // DeleteFields
            // 
            this.DeleteFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFields.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteFields.Location = new System.Drawing.Point(625, 12);
            this.DeleteFields.Name = "DeleteFields";
            this.DeleteFields.Size = new System.Drawing.Size(379, 96);
            this.DeleteFields.TabIndex = 4;
            this.DeleteFields.Text = "Delete Fields";
            this.DeleteFields.UseVisualStyleBackColor = true;
            this.DeleteFields.Click += new System.EventHandler(this.DeleteFields_Click);
            // 
            // Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 304);
            this.Controls.Add(this.DeleteFields);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.UpdateFields);
            this.Controls.Add(this.CopyCommentToProductWebSite);
            this.Controls.Add(this.CopyNameToComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Buttons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buttons";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Buttons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CopyNameToComment;
        private System.Windows.Forms.Button CopyCommentToProductWebSite;
        private System.Windows.Forms.Button UpdateFields;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button DeleteFields;
    }
}

