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
            // Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 115);
            this.Controls.Add(this.CopyCommentToProductWebSite);
            this.Controls.Add(this.CopyNameToComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Buttons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CopyNameToComment;
        private System.Windows.Forms.Button CopyCommentToProductWebSite;
    }
}

