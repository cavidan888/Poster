namespace HomeWork.View
{
    partial class PostWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.postName = new System.Windows.Forms.TextBox();
            this.postPublish = new System.Windows.Forms.TextBox();
            this.postReadCount = new System.Windows.Forms.TextBox();
            this.postAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idCategory = new System.Windows.Forms.ComboBox();
            this.idAuthor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Post Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post Publish Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Post ReadCount";
            // 
            // postName
            // 
            this.postName.Location = new System.Drawing.Point(228, 26);
            this.postName.Name = "postName";
            this.postName.Size = new System.Drawing.Size(116, 20);
            this.postName.TabIndex = 3;
            // 
            // postPublish
            // 
            this.postPublish.Location = new System.Drawing.Point(228, 58);
            this.postPublish.Name = "postPublish";
            this.postPublish.Size = new System.Drawing.Size(116, 20);
            this.postPublish.TabIndex = 4;
            // 
            // postReadCount
            // 
            this.postReadCount.Location = new System.Drawing.Point(228, 87);
            this.postReadCount.Name = "postReadCount";
            this.postReadCount.Size = new System.Drawing.Size(116, 20);
            this.postReadCount.TabIndex = 5;
            
            // 
            // postAdd
            // 
            this.postAdd.Location = new System.Drawing.Point(114, 196);
            this.postAdd.Name = "postAdd";
            this.postAdd.Size = new System.Drawing.Size(119, 30);
            this.postAdd.TabIndex = 6;
            this.postAdd.Text = "Add Post";
            this.postAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Author Id";
            // 
            // idCategory
            // 
            this.idCategory.FormattingEnabled = true;
            this.idCategory.Location = new System.Drawing.Point(228, 144);
            this.idCategory.Name = "idCategory";
            this.idCategory.Size = new System.Drawing.Size(116, 21);
            this.idCategory.TabIndex = 9;
            // 
            // idAuthor
            // 
            this.idAuthor.FormattingEnabled = true;
            this.idAuthor.Location = new System.Drawing.Point(228, 116);
            this.idAuthor.Name = "idAuthor";
            this.idAuthor.Size = new System.Drawing.Size(116, 21);
            this.idAuthor.TabIndex = 10;
            // 
            // PostWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 243);
            this.Controls.Add(this.idAuthor);
            this.Controls.Add(this.idCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postAdd);
            this.Controls.Add(this.postReadCount);
            this.Controls.Add(this.postPublish);
            this.Controls.Add(this.postName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PostWindow";
            this.Text = "Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox postName;
        private System.Windows.Forms.TextBox postPublish;
        private System.Windows.Forms.TextBox postReadCount;
        private System.Windows.Forms.Button postAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox idCategory;
        private System.Windows.Forms.ComboBox idAuthor;
    }
}