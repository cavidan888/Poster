namespace HomeWork.View
{
    partial class AuthorWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authName = new System.Windows.Forms.TextBox();
            this.authSurName = new System.Windows.Forms.TextBox();
            this.addAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author Email";
            // 
            // authName
            // 
            this.authName.Location = new System.Drawing.Point(171, 18);
            this.authName.Name = "authName";
            this.authName.Size = new System.Drawing.Size(127, 20);
            this.authName.TabIndex = 2;
            // 
            // authSurName
            // 
            this.authSurName.Location = new System.Drawing.Point(171, 58);
            this.authSurName.Name = "authSurName";
            this.authSurName.Size = new System.Drawing.Size(127, 20);
            this.authSurName.TabIndex = 3;
            // 
            // addAuthor
            // 
            this.addAuthor.Location = new System.Drawing.Point(86, 116);
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.Size = new System.Drawing.Size(154, 28);
            this.addAuthor.TabIndex = 4;
            this.addAuthor.Text = "Add  Author";
            this.addAuthor.UseVisualStyleBackColor = true;
            // 
            // AuthorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 185);
            this.Controls.Add(this.addAuthor);
            this.Controls.Add(this.authSurName);
            this.Controls.Add(this.authName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthorWindow";
            this.Text = "AuthorWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authName;
        private System.Windows.Forms.TextBox authSurName;
        private System.Windows.Forms.Button addAuthor;
    }
}