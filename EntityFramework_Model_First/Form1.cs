using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_Model_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities GetNorthwindEntities = new NorthwindEntities();


        public void AddCategorys()
        {
            Categories categories = new Categories();

          //  categories.CategoryID = Convert.ToInt32(txt_CategoryİD.Text);
            categories.CategoryName = txt_CategoryName.Text;
            categories.Description = txt_Description.Text;

            GetNorthwindEntities.Categories.Add(categories);

            // Command.Executenon... e denk geliyor
            GetNorthwindEntities.SaveChanges();
        }

        public void RemoveCategory(int İD)
        {
            Categories categories = GetNorthwindEntities.Categories.First(f => f.CategoryID == İD);

            GetNorthwindEntities.Categories.Remove(categories);
            GetNorthwindEntities.SaveChanges();
        
        }

        public void UpdateCategory(int İD)
        {
            Categories categories = GetNorthwindEntities.Categories.First(f => f.CategoryID == İD);

            categories.CategoryName = txt_CategoryName.Text;
            categories.Description = txt_Description.Text;

            GetNorthwindEntities.SaveChanges();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = GetNorthwindEntities.Categories.ToList();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            AddCategorys();
            bunifuCustomDataGrid1.DataSource = GetNorthwindEntities.Categories.ToList();
            MessageBox.Show("Categorys Addded");
            

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            RemoveCategory(Convert.ToInt32(txt_CategoryİD.Text));

            bunifuCustomDataGrid1.DataSource = GetNorthwindEntities.Categories.ToList();
            MessageBox.Show("Category Remove");

        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            UpdateCategory(Convert.ToInt32(txt_CategoryİD.Text));

            bunifuCustomDataGrid1.DataSource = GetNorthwindEntities.Categories.ToList();
            MessageBox.Show("Category Update");
        }
    }
}
