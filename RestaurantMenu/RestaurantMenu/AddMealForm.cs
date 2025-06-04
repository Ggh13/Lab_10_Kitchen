using Model.Core.MealDir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Core.MenuDir;
using Model.Data;

namespace RestaurantMenu
{
    public partial class AddMealForm : Form
    {
        Menu menu;
        public AddMealForm(Menu menu_peredali)
        {
            InitializeComponent();

            this.Size = new Size(450, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            menu = menu_peredali;

            InitComboBoxMealType();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Добавить блюдо";
            this.Size = new Size(400, 250);

            var reqName = new Label { Text = "Название блюда:", Location = new Point(20, 20) };
            var mealName = new TextBox { Location = new Point(150, 20), Width = 200 };

            var reqPrice = new Label { Text = "Цена:", Location = new Point(20, 60) };
            var mealPrice = new NumericUpDown
            {
                Location = new Point(150, 60),
                Width = 200,
                Minimum = 0,
                Maximum = 10000,
                DecimalPlaces = 2
            };

            var reqType = new Label { Text = "Тип:", Location = new Point(20, 100) };
            var mealType = new ComboBox
            {
                Location = new Point(150, 100),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            mealType.Items.AddRange(new[] { "Салаты", "Десерты", "Горячие блюда", "Напитки" });
            mealType.SelectedIndex = 0;

            var btnAdd = new Button
            {
                Text = "Добавить",
                Location = new Point(150, 150),
                Size = new Size(100, 30)
            };
            btnAdd.Click += (sender, e) => AddMeal(mealName.Text, (int)mealPrice.Value, mealType.SelectedItem.ToString());

            this.Controls.AddRange(new Control[] { reqName, mealName, reqPrice, mealPrice, reqType, mealType, btnAdd });
        }

        private void AddMeal(string name, int price, string type)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название блюда");
                return;
            }
            Meal addedMeal = null;
            switch (type)
            {
                case "Салаты":
                    addedMeal = new Salad(name, price);
                    break;
                case "Десерты":
                    addedMeal = new Dessert(name, price);
                    break;
                case "Горячие блюда":
                    addedMeal = new HotDish(name, price);
                    break;
                case "Напитки":
                    addedMeal = new Drink(name, price);
                    break;
            }
            menu.AddMeal(addedMeal);
            MainSerialializer.SaveMenu(menu);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitComboBoxMealType()
        {
            //comboBoxMealType.DropDownStyle = ComboBoxStyle.DropDownList;
            //string[] mealTypes = { "Салаты", "Десерты", "Горячие блюда", "Напитки" };
            //comboBoxMealType.Items.AddRange(mealTypes);

            //comboBoxMealType.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMealForm_Load(object sender, EventArgs e)
        {

        }
    }
}
