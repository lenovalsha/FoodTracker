using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodTracker.Model; //this is added

namespace FoodTracker
{
    public partial class Form1 : Form
    {
        private myDbContext myContext;
        public Form1()
        {
            InitializeComponent();
            myContext = new myDbContext();

            var meals = myContext.Meals.ToList();
            foreach(Meal m in meals)
            {
                cmbMeal.Items.Add(m);
            }
            RefreshData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(cmbMeal.SelectedItem !=null && txtFood.Text !=String.Empty)
            {
                var newTask = new Model.Food
                {
                    Name = txtFood.Text,
                    MealId = (cmbMeal.SelectedItem as Model.Meal).Id,
                    FoodDate = dtpDate.Value
                };

                myContext.Foods.Add(newTask); 
                myContext.SaveChanges(); //goes through the context class and looks through the pending changes to add to the database (update, creations, deletions)
                RefreshData();
            }
            else
            {
                MessageBox.Show("Enter all data necessary");
            }
        }

        private void RefreshData()
        {
            BindingSource binding = new BindingSource();

            //write a query
            var query = from t in myContext.Foods
                        orderby t.FoodDate
                        select new { t.Id, FoodName = t.Name, t.Meal.Name, t.FoodDate }; //we use FoodName = t.Name bc w/o it its giving us an error bc of ambigious

            dgvData.DataSource = query.ToList();
            dgvData.Refresh();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var f = myContext.Foods.Find((int)dgvData.SelectedCells[0].Value);
            if (f != null)
            {
                myContext.Foods.Remove(f);
                myContext.SaveChanges();
                RefreshData();
            }
        }
    }
}
