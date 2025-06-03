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

namespace RestaurantMenu
{
    public partial class AddMealForm : Form
    {
        public AddMealForm()
        {
            InitializeComponent();

            this.Size = new Size(450, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitComboBoxMealType();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Настройка формы
            this.Text = "Добавить блюдо";
            this.Size = new Size(400, 250);

            // Поле для названия
            var lblName = new Label { Text = "Название блюда:", Location = new Point(20, 20) };
            var txtName = new TextBox { Location = new Point(150, 20), Width = 200 };

            // Поле для цены
            var lblPrice = new Label { Text = "Цена:", Location = new Point(20, 60) };
            var txtPrice = new NumericUpDown
            {
                Location = new Point(150, 60),
                Width = 200,
                Minimum = 0,
                Maximum = 10000,
                DecimalPlaces = 2
            };

            // ComboBox для типа блюда
            var lblType = new Label { Text = "Тип:", Location = new Point(20, 100) };
            var cmbType = new ComboBox
            {
                Location = new Point(150, 100),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbType.Items.AddRange(new[] { "Салаты", "Десерты", "Горячие блюда", "Напитки" });
            cmbType.SelectedIndex = 0;

            // Кнопка добавления
            var btnAdd = new Button
            {
                Text = "Добавить",
                Location = new Point(150, 150),
                Size = new Size(100, 30)
            };
            btnAdd.Click += (sender, e) => AddMeal(txtName.Text, (int)txtPrice.Value, cmbType.SelectedItem.ToString());

            // Добавляем элементы на форму
            this.Controls.AddRange(new Control[] { lblName, txtName, lblPrice, txtPrice, lblType, cmbType, btnAdd });
        }

        private void AddMeal(string name, int price, string type)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название блюда");
                return;
            }
            Meal addedMeal;
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

        private void AddMealForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
