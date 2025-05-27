using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMenu.RestaurantMenu
{

    public partial class MapForm : Form
    {
        private Button[] VenueButtons = new Button[6];
        public MapForm()
        {
            InitializeComponent();
            VenueButtons[0] = ButtonRestaurant1;
            VenueButtons[1] = ButtonRestaurant2;
            VenueButtons[2] = ButtonCafe1;
            VenueButtons[3] = ButtonCafe2;
            VenueButtons[4] = ButtonFastFood1;
            VenueButtons[5] = ButtonFastFood2;

            RestaurantCheckBox.Checked = true;
            CafeCheckBox.Checked = true;
            FastFoodCheckBox.Checked = true;
            label1.Text = "Aboba";
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void RestaurantCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RestaurantCheckBox.Checked)
            {
                ButtonRestaurant1.Visible = true;
                ButtonRestaurant2.Visible = true;
            }
            else
            {
                ButtonRestaurant1.Visible = false;
                ButtonRestaurant2.Visible = false;
            }
        }

        private void CafeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CafeCheckBox.Checked)
            {
                ButtonCafe1.Visible = true;
                ButtonCafe2.Visible = true;
            }
            else
            {
                ButtonCafe1.Visible = false;
                ButtonCafe2.Visible = false;
            }
        }

        private void FastFoodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FastFoodCheckBox.Checked)
            {
                ButtonFastFood1.Visible = true;
                ButtonFastFood2.Visible = true;
            }
            else
            {
                ButtonFastFood1.Visible = false;
                ButtonFastFood2.Visible = false;
            }
        }

        private void ButtonCafe1_Click(object sender, EventArgs e)
        {

        }
    }
}
