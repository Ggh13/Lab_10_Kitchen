﻿using Model.Core.Map;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace RestaurantMenu.RestaurantMenu
{

    public partial class MapForm : Form
    {
        private BackgroundMusicPlayer musicPlayer;

        private System.Windows.Forms.Button[] VenueButtons = new System.Windows.Forms.Button[6];
        private int choosenVen = -1;  // айдишник выбранного ресторана

        Dictionary<string, int> RestToId = new Dictionary<string, int>
        {
            { "ButtonRestaurant1", 0 },
            { "ButtonRestaurant2", 1 },
            { "ButtonCafe1", 2 },
            { "ButtonCafe2", 3 },
            { "ButtonFastFood1", 4 },
            { "ButtonFastFood2", 5 }
        };
        public MapForm()
        {
            InitializeComponent();
            VenueButtons[0] = ButtonRestaurant1;
            VenueButtons[1] = ButtonRestaurant2;
            VenueButtons[2] = ButtonCafe1;
            VenueButtons[3] = ButtonCafe2;
            VenueButtons[4] = ButtonFastFood1;
            VenueButtons[5] = ButtonFastFood2;

            foreach (var item in VenueButtons)
            {

                item.Click += CommonBtn_Click;

            }

            for (int i = 0; i < 6; i++)
            {
                VenueButtons[i].Text = Map.Venues[i].Name;
                VenueButtons[i].Size = new Size(250, 100);
            }

            musicPlayer = new BackgroundMusicPlayer();

            string musicPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Audio", "music.mp3");
            try
            {
                musicPlayer.Play(musicPath, volume: 0.3f, loop: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить музыку: {ex.Message}");
            }
            ClassicMenuButton.Visible = false;
            SeasonMenuButton.Visible = false;

            AddSeasonMenu.Visible = false;

            comboRestaurant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRestaurant.SelectedIndexChanged += comboRestaurant_SelectedIndexChanged;
            comboRestaurant.Items.AddRange(new string[] { "Все", "Рестораны", "Кафе", "ФастФуд" });
            comboRestaurant.SelectedIndex = 0;
            chooseMenu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            musicPlayer.Dispose();
            base.OnFormClosing(e);
        }


        private void CommonBtn_Click(object sender, EventArgs e)
        {
            string msg = ((System.Windows.Forms.Button)sender).Name.ToString();
            ClassicMenuButton.Visible = false;
            SeasonMenuButton.Visible = false;
            chooseMenu.Items.Clear();
            choosenVen = RestToId[msg];
            AddSeasonMenu.Visible = false;
            if (Map.Venues[RestToId[msg]].HaveSeasonMenu)
            {
                chooseMenu.Items.AddRange(new string[] { "Сезонное", "Классическое" });
                MainPanel.BackgroundImage = Image.FromFile(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "image", "BACK_OGUZOK.jpg"));
            }
            else
            {
                MainPanel.BackgroundImage = Image.FromFile(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "image", "BACK_VIKA.jpg"));
                chooseMenu.Items.AddRange(new string[] { "Классическое" });
                AddSeasonMenu.Visible = true;
            }
            chooseMenu.SelectedIndex = 0;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        private void ButtonCafe1_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboRestaurant.SelectedItem.ToString();
            if (selectedState == null)
            {
                ButtonFastFood1.Visible = true;
                ButtonFastFood2.Visible = true;
                ButtonCafe1.Visible = true;
                ButtonCafe2.Visible = true;
                ButtonRestaurant1.Visible = true;
                ButtonRestaurant2.Visible = true;

            }
            else
            {
                vizOffAll();
                if (selectedState == "Рестораны")
                {
                    ButtonRestaurant1.Visible = true;
                    ButtonRestaurant2.Visible = true;
                }
                else if (selectedState == "Кафе")
                {
                    ButtonCafe1.Visible = true;
                    ButtonCafe2.Visible = true;
                }
                else if (selectedState == "ФастФуд")
                {
                    ButtonFastFood1.Visible = true;
                    ButtonFastFood2.Visible = true;
                }
                else
                {
                    ButtonRestaurant1.Visible = true;
                    ButtonRestaurant2.Visible = true;
                    ButtonCafe1.Visible = true;
                    ButtonCafe2.Visible = true;
                    ButtonFastFood1.Visible = true;
                    ButtonFastFood2.Visible = true;
                }
            };
        }

        private void vizOffAll()
        {
            ButtonFastFood1.Visible = false;
            ButtonFastFood2.Visible = false;
            ButtonCafe1.Visible = false;
            ButtonCafe2.Visible = false;
            ButtonRestaurant1.Visible = false;
            ButtonRestaurant2.Visible = false;
        }

        private void ButtonRestaurant1_Click(object sender, EventArgs e)
        {

        }

        private void chooseMenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedState = chooseMenu.SelectedItem.ToString();
            ClassicMenuButton.Visible = false;
            SeasonMenuButton.Visible = false;
            if (selectedState != null)
            {
                if (selectedState == "Сезонное")
                {
                    SeasonMenuButton.Visible = true;
                }
                else
                {
                    ClassicMenuButton.Visible = true;
                }

            }
        }

        private void ClassicMenuButton_Click(object sender, EventArgs e)
        {
            VenueForm venueForm = new VenueForm(Map.Venues[choosenVen].Menus[0].MyId, Map.Venues[choosenVen].Menus[0].NameOfVen);
            venueForm.Show();
        }

        private void SeasonMenuButton_Click(object sender, EventArgs e)
        {
            VenueForm venueForm = new VenueForm(Map.Venues[choosenVen].Menus[1].MyId, Map.Venues[choosenVen].Menus[0].NameOfVen);
            venueForm.Show();
        }

        private void AddSeasonMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сезонное меню успешно добавлено".ToString());
            MainPanel.BackgroundImage = Image.FromFile(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "image", "BACK_OGUZOK.jpg"));
            Map.Venues[choosenVen].AddSeasonMenu();

            AddSeasonMenu.Visible = false;
            chooseMenu.Items.AddRange(new string[] { "Сезонное" });
        }

        private void MapForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

    }
}
