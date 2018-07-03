using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Entity;
using HomeWork.Controller;

namespace HomeWork.View
{
    public partial class PostWindow : Form
    {
        public PostWindow()
        {
            InitializeComponent();
            FillAuthorCombo();
            FillCategoryCombo();
            postAdd.Click += addPost;
        }

       

        public void FillAuthorCombo()
        {
            foreach (var item in Db.authors)
            {
                idAuthor.Items.Add(item.Id);
            }
        }


        public void FillCategoryCombo()
        {
            foreach (var item in Db.categories)
            {
                idCategory.Items.Add(item.Id);
            }
        }


        private void addPost(object sender, EventArgs e)
        {

            var pName = postName.Text;
            DateTime pTime = Convert.ToDateTime(postPublish.Text);
            var pReadCount = int.Parse(postReadCount.Text);
            var slctdAut = Convert.ToInt32(idAuthor.SelectedItem);
            var slctdCut = Convert.ToInt32(idCategory.SelectedItem);
            PostController.Create(pName,pTime,pReadCount,slctdAut,slctdCut); 
        }

        
    }
}
