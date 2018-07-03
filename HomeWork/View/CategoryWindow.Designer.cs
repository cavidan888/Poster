namespace HomeWork.View
{
    partial class CategoryWindow
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
            this.addCat = new System.Windows.Forms.Button();
            this.catName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCat
            // 
            this.addCat.Location = new System.Drawing.Point(75, 107);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(154, 28);
            this.addCat.TabIndex = 9;
            this.addCat.Text = "Add Category";
            this.addCat.UseVisualStyleBackColor = true;
            // 
            // catName
            // 
            this.catName.Location = new System.Drawing.Point(87, 65);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(127, 20);
            this.catName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category Name";
            // 
            // CategoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 172);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.catName);
            this.Controls.Add(this.label1);
            this.Name = "CategoryWindow";
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.TextBox catName;
        private System.Windows.Forms.Label label1;
    }
}