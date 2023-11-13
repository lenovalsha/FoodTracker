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

            }
            else
            {
                MessageBox.Show("Enter all data necessary");
            }
        }
    }
}
