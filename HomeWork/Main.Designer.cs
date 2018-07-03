namespace HomeWork
{
    partial class Main
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
            this.authorAdder = new System.Windows.Forms.Button();
            this.categoryAdder = new System.Windows.Forms.Button();
            this.postAdder = new System.Windows.Forms.Button();
            this.authorShower = new System.Windows.Forms.Button();
            this.categoryShower = new System.Windows.Forms.Button();
            this.postShower = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.authorResultBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryResultBox = new System.Windows.Forms.RichTextBox();
            this.postBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // authorAdder
            // 
            this.authorAdder.Location = new System.Drawing.Point(15, 9);
            this.authorAdder.Name = "authorAdder";
            this.authorAdder.Size = new System.Drawing.Size(166, 32);
            this.authorAdder.TabIndex = 0;
            this.authorAdder.Text = "Add Author";
            this.authorAdder.UseVisualStyleBackColor = true;
            // 
            // categoryAdder
            // 
            this.categoryAdder.Location = new System.Drawing.Point(246, 9);
            this.categoryAdder.Name = "categoryAdder";
            this.categoryAdder.Size = new System.Drawing.Size(162, 32);
            this.categoryAdder.TabIndex = 1;
            this.categoryAdder.Text = "Add Category";
            this.categoryAdder.UseVisualStyleBackColor = true;
            // 
            // postAdder
            // 
            this.postAdder.Location = new System.Drawing.Point(467, 9);
            this.postAdder.Name = "postAdder";
            this.postAdder.Size = new System.Drawing.Size(162, 32);
            this.postAdder.TabIndex = 2;
            this.postAdder.Text = "Add Post";
            this.postAdder.UseVisualStyleBackColor = true;
            // 
            // authorShower
            // 
            this.authorShower.Location = new System.Drawing.Point(15, 64);
            this.authorShower.Name = "authorShower";
            this.authorShower.Size = new System.Drawing.Size(166, 32);
            this.authorShower.TabIndex = 3;
            this.authorShower.Text = "Show Author";
            this.authorShower.UseVisualStyleBackColor = true;
            // 
            // categoryShower
            // 
            this.categoryShower.Location = new System.Drawing.Point(246, 64);
            this.categoryShower.Name = "categoryShower";
            this.categoryShower.Size = new System.Drawing.Size(162, 32);
            this.categoryShower.TabIndex = 4;
            this.categoryShower.Text = "Show Category";
            this.categoryShower.UseVisualStyleBackColor = true;
            // 
            // postShower
            // 
            this.postShower.Location = new System.Drawing.Point(467, 64);
            this.postShower.Name = "postShower";
            this.postShower.Size = new System.Drawing.Size(162, 32);
            this.postShower.TabIndex = 5;
            this.postShower.Text = "Show Post";
            this.postShower.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Author Result";
            // 
            // authorResultBox
            // 
            this.authorResultBox.Location = new System.Drawing.Point(15, 161);
            this.authorResultBox.Name = "authorResultBox";
            this.authorResultBox.Size = new System.Drawing.Size(292, 148);
            this.authorResultBox.TabIndex = 7;
            this.authorResultBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category Result";
            // 
            // CategoryResultBox
            // 
            this.CategoryResultBox.Location = new System.Drawing.Point(369, 161);
            this.CategoryResultBox.Name = "CategoryResultBox";
            this.CategoryResultBox.Size = new System.Drawing.Size(260, 148);
            this.CategoryResultBox.TabIndex = 8;
            this.CategoryResultBox.Text = "";
            // 
            // postBox
            // 
            this.postBox.Location = new System.Drawing.Point(15, 340);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(614, 145);
            this.postBox.TabIndex = 9;
            this.postBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 523);
            this.Controls.Add(this.postBox);
            this.Controls.Add(this.CategoryResultBox);
            this.Controls.Add(this.authorResultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postShower);
            this.Controls.Add(this.categoryShower);
            this.Controls.Add(this.authorShower);
            this.Controls.Add(this.postAdder);
            this.Controls.Add(this.categoryAdder);
            this.Controls.Add(this.authorAdder);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorAdder;
        private System.Windows.Forms.Button categoryAdder;
        private System.Windows.Forms.Button postAdder;
        private System.Windows.Forms.Button authorShower;
        private System.Windows.Forms.Button categoryShower;
        private System.Windows.Forms.Button postShower;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox authorResultBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox CategoryResultBox;
        public System.Windows.Forms.RichTextBox postBox;
    }
}

