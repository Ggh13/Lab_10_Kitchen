using Model.Core.MealDir;
using Model.Core.MenuDir;
using Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantMenu
{
    public partial class VenueForm : Form
    {
        private Menu menu = default(Menu);
        private string typeToSave = "Json";

        public VenueForm(int id, string venue_name)
        {
            menu = MainSerialializer.LoadMenu(id, venue_name);
            //menu = new SeasonMenu("Arcabaene");
            InitializeComponent();
            this.Size = new Size(1000, 800);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitComboBoxMealType();
            InitComboBoxChooseFileType();
            DisplayMeals();
        }
        private void InitComboBoxChooseFileType()
        {
            ChooseFileType.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] fileTypes = { "JSON", "XML" };
            ChooseFileType.Items.AddRange(fileTypes);

            ChooseFileType.SelectedIndex = 0;
        }

        private void InitComboBoxMealType()
        {
            ComboBoxMealType.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] mealTypes = { "Все", "Салаты", "Десерты", "Горячие блюда", "Напитки" };
            ComboBoxMealType.Items.AddRange(mealTypes);

            ComboBoxMealType.SelectedIndex = 0;

            ComboBoxMealType.SelectedIndexChanged += ComboBoxMealType_SelectedIndexChanged;
        }

        private void ComboBoxMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMealsByType();
        }

        private void FilterMealsByType()
        {
            string selectedType = ComboBoxMealType.SelectedItem.ToString();
            flowLayoutPanel.Controls.Clear();

            Meal[] filteredMeals;
            if (selectedType == "Все")
                filteredMeals = menu.Meals;
            else
                filteredMeals = menu.Meals.Where(m => GetMealTypeDisplayName(m.Type) == selectedType).ToArray();

            foreach (var meal in filteredMeals)
            {
                flowLayoutPanel.Controls.Add(CreateMealCard(meal));
            }

        }

        private string GetMealTypeDisplayName(string type)
        {
            switch (type)
            {
                case "Salad":
                    return "Салаты";
                case "Dessert":
                    return "Десерты";
                case "HotDish":
                    return "Горячие блюда";
                case "Drink":
                    return "Напитки";
                default:
                    return type.ToString();
            }
        }

        private void DisplayMeals()
        {

            flowLayoutPanel.Controls.Clear();

            foreach (var meal in menu.Meals)
            {
                var card = CreateMealCard(meal);
                flowLayoutPanel.Controls.Add(card);
            }
        }

        private Panel CreateMealCard(Meal meal)
        {
            Dictionary<string, string> type_translation = new Dictionary<string, string>()
            {
                { "HotDish", "Горячее блюдо" },
                { "Salad", "Салат"},
                { "Dessert", "Десерт"},
                { "Drink", "Напиток"}
            };

            var mainPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = 320,
                Height = 150,
                Margin = new Padding(10),
                Padding = new Padding(5)
            };

            var mealName = new Label
            {
                Text = meal.Name,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 30
            };

            var mealType = new Label
            {
                Text = type_translation[meal.Type],
                Dock = DockStyle.Top,
                Height = 25
            };

            var mealPrice = new Label
            {
                Text = $"{meal.Price} рублей",
                Dock = DockStyle.Top,
                Height = 25
            };

            var btnDelete = new Button
            {
                Text = "Удалить из меню",
                Dock = DockStyle.Bottom,
                Height = 30,
                Tag = meal
            };
            btnDelete.Click += DeleteMealButton_Click;

            mainPanel.Controls.AddRange(new Control[] { mealName, mealType, mealPrice, btnDelete });

            return mainPanel;
        }

        private void VenueForm_Load(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChooseFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ChooseFileType.SelectedItem.ToString();
            typeToSave = selectedValue;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /* 
               Привет антоние, я пришел скушать ватрушку с медом  маслом, еще я любю жевать воск из под сот. Он как жевачка и прям с медом, я рекомендую шефу добавить это людо в апитайзеры, чтобы огузок ходил и разносил критикам, и у них попа слиплась от меда.
            */
            if (typeToSave == "JSON")
            {
                MainSerialializer.ChangeFormat("json");
            }
            else
            {
                MainSerialializer.ChangeFormat("xml");
            }
        }

        private void AddMealButton_Click(object sender, EventArgs e)
        {
            AddMealForm form = new AddMealForm(menu);
            form.Show();
            menu = MainSerialializer.LoadMenu(menu.MyId, menu.NameOfVen);
        }

        private void vScrollBarForMeals_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void DeleteMealButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Meal mealToDelete = (Meal)button.Tag;
            menu.DeleteMeal(mealToDelete);
            DisplayMeals();
        }

        private void ShowMealsButton_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
