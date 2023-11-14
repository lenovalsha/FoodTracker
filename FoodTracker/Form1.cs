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
            foreach (Meal m in meals)
            {
                cmbMeal.Items.Add(m);
            }
            ShowAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbMeal.SelectedItem != null && txtFood.Text != String.Empty)
            {

                myContext.Foods.Add(MakeNewFood());
                myContext.SaveChanges(); //goes through the context class and looks through the pending changes to add to the database (update, creations, deletions)
                if(MakeNewFood().FoodDate >= DateTime.Today && MakeNewFood().FoodDate < DateTime.Today.AddDays(1))
                {
                    ShowToday();
                }
                else
                ShowAll();

            }
            else
            {
                MessageBox.Show("Enter all data necessary");
            }
        }

        private void ShowAll()
        {
            BindingSource binding = new BindingSource();

            //write a query
            var query = from t in myContext.Foods
                        orderby t.FoodDate descending
                        select new { t.Id,FoodName = t.Name, t.Meal.Name, t.FoodDate }; //we use FoodName = t.Name bc w/o it its giving us an error bc of ambigious

            dgvData.DataSource = query.ToList();
            dgvData.Columns[0].Visible = false;
            dgvData.Refresh();
            txtFood.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
        }
        private Model.Food MakeNewFood()
        {
            var newFood = new Model.Food
            {
                Name = txtFood.Text,
                MealId = (cmbMeal.SelectedItem as Model.Meal).Id,
                FoodDate = dtpDate.Value
            };
            
            return newFood;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //this is so that we can select anything from the row and we can delete it
            var selectedRowIndex = (int)dgvData.SelectedCells[0].RowIndex;
            int selectedFood = (int)dgvData.Rows[selectedRowIndex].Cells[0].Value;
            var f = myContext.Foods.Find(selectedFood);
            if (f != null)
            {
                myContext.Foods.Remove(f);
                myContext.SaveChanges();
                ShowAll();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = (int)dgvData.SelectedCells[0].RowIndex;
            int selectedFood = (int)dgvData.Rows[selectedRowIndex].Cells[0].Value;
            var f = myContext.Foods.Find(selectedFood);
            if (btnUpdate.Text == "Update")
            {
                if (f != null)
                {
                    txtFood.Text = f.Name;
                    dtpDate.Value = f.FoodDate.Value;
                    cmbMeal.Text = f.Meal.Name;
                }
                btnUpdate.Text = "Save Changes";
            }
            else
            {
                f.Name = txtFood.Text;
                f.MealId = (cmbMeal.SelectedItem as Meal).Id;
                f.FoodDate = dtpDate.Value;
                myContext.SaveChanges();
                btnUpdate.Text = "Update";
                ShowAll();
            }
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
           ShowToday();
        }

        private void grpFood_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //show the 
            ShowCertainDate(dtDisplayToDGV.Value);
        }
        private void ShowToday()
        {
            BindingSource binding = new BindingSource();
            DateTime endDate = DateTime.Today.AddDays(1);
            //write a query
            var query = from t in myContext.Foods
                        where t.FoodDate >= DateTime.Today && t.FoodDate < endDate
                        orderby t.MealId
                        select new { t.Id, FoodName = t.Name, t.Meal.Name, t.FoodDate }; //we use FoodName = t.Name bc w/o it its giving us an error bc of ambigious

            dgvData.DataSource = query.ToList();
            dgvData.Refresh();
            dgvData.Columns[0].Visible = false;

            txtFood.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
        }
        private void ShowCertainDate(DateTime date)
        {
            BindingSource binding = new BindingSource();
            DateTime startDate = date.AddDays(-1);
            DateTime endDate = date.AddDays(1);

            //write a query
            var query = from t in myContext.Foods
                        where t.FoodDate >= startDate && t.FoodDate < endDate
                        orderby t.MealId
                        select new { t.Id, FoodName = t.Name, t.Meal.Name, t.FoodDate }; //we use FoodName = t.Name bc w/o it its giving us an error bc of ambigious

            dgvData.DataSource = query.ToList();
            dgvData.Refresh();
            dgvData.Columns[0].Visible = false;

            txtFood.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
        }
        private void Refresh()
        {
            txtFood.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            cmbMeal.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           Refresh();
        }
    }
}
