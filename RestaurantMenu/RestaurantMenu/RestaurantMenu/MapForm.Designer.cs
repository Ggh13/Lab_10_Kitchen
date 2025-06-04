namespace RestaurantMenu.RestaurantMenu
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            button1 = new Button();
            MainPanel = new Panel();
            AddSeasonMenu = new Button();
            SeasonMenuButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ButtonFastFood2 = new Button();
            ButtonCafe2 = new Button();
            ButtonRestaurant1 = new Button();
            ButtonRestaurant2 = new Button();
            ButtonCafe1 = new Button();
            ButtonFastFood1 = new Button();
            panel2 = new Panel();
            chooseMenu = new ComboBox();
            comboRestaurant = new ComboBox();
            ClassicMenuButton = new Button();
            MainPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(341, 91);
            button1.Name = "button1";
            button1.Size = new Size(198, 77);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.MenuHighlight;
            MainPanel.BackgroundImage = (Image)resources.GetObject("MainPanel.BackgroundImage");
            MainPanel.Controls.Add(AddSeasonMenu);
            MainPanel.Controls.Add(SeasonMenuButton);
            MainPanel.Controls.Add(flowLayoutPanel1);
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(ClassicMenuButton);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(894, 662);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // AddSeasonMenu
            // 
            AddSeasonMenu.Location = new Point(531, 578);
            AddSeasonMenu.Name = "AddSeasonMenu";
            AddSeasonMenu.Size = new Size(341, 46);
            AddSeasonMenu.TabIndex = 10;
            AddSeasonMenu.Text = "Добавить сезонное меню";
            AddSeasonMenu.UseVisualStyleBackColor = true;
            AddSeasonMenu.Click += AddSeasonMenu_Click;
            // 
            // SeasonMenuButton
            // 
            SeasonMenuButton.Location = new Point(603, 224);
            SeasonMenuButton.Name = "SeasonMenuButton";
            SeasonMenuButton.Size = new Size(228, 109);
            SeasonMenuButton.TabIndex = 9;
            SeasonMenuButton.Text = "Season";
            SeasonMenuButton.UseVisualStyleBackColor = true;
            SeasonMenuButton.Click += SeasonMenuButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.Controls.Add(ButtonFastFood2);
            flowLayoutPanel1.Controls.Add(ButtonCafe2);
            flowLayoutPanel1.Controls.Add(ButtonRestaurant1);
            flowLayoutPanel1.Controls.Add(ButtonRestaurant2);
            flowLayoutPanel1.Controls.Add(ButtonCafe1);
            flowLayoutPanel1.Controls.Add(ButtonFastFood1);
            flowLayoutPanel1.Location = new Point(0, 91);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(497, 571);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // ButtonFastFood2
            // 
            ButtonFastFood2.Location = new Point(3, 3);
            ButtonFastFood2.Name = "ButtonFastFood2";
            ButtonFastFood2.Size = new Size(385, 46);
            ButtonFastFood2.TabIndex = 6;
            ButtonFastFood2.Text = "button5";
            ButtonFastFood2.UseVisualStyleBackColor = true;
            // 
            // ButtonCafe2
            // 
            ButtonCafe2.Location = new Point(3, 55);
            ButtonCafe2.Name = "ButtonCafe2";
            ButtonCafe2.Size = new Size(444, 46);
            ButtonCafe2.TabIndex = 4;
            ButtonCafe2.Text = "button5";
            ButtonCafe2.UseVisualStyleBackColor = true;
            // 
            // ButtonRestaurant1
            // 
            ButtonRestaurant1.Location = new Point(3, 107);
            ButtonRestaurant1.Name = "ButtonRestaurant1";
            ButtonRestaurant1.Size = new Size(419, 61);
            ButtonRestaurant1.TabIndex = 1;
            ButtonRestaurant1.Text = "button2";
            ButtonRestaurant1.UseVisualStyleBackColor = true;
            ButtonRestaurant1.Click += ButtonRestaurant1_Click;
            // 
            // ButtonRestaurant2
            // 
            ButtonRestaurant2.Location = new Point(3, 174);
            ButtonRestaurant2.Name = "ButtonRestaurant2";
            ButtonRestaurant2.Size = new Size(474, 46);
            ButtonRestaurant2.TabIndex = 2;
            ButtonRestaurant2.Text = "button3";
            ButtonRestaurant2.UseVisualStyleBackColor = true;
            // 
            // ButtonCafe1
            // 
            ButtonCafe1.Location = new Point(3, 226);
            ButtonCafe1.Name = "ButtonCafe1";
            ButtonCafe1.Size = new Size(427, 46);
            ButtonCafe1.TabIndex = 3;
            ButtonCafe1.Text = "button4";
            ButtonCafe1.UseVisualStyleBackColor = true;
            ButtonCafe1.Click += ButtonCafe1_Click;
            // 
            // ButtonFastFood1
            // 
            ButtonFastFood1.Location = new Point(3, 278);
            ButtonFastFood1.Name = "ButtonFastFood1";
            ButtonFastFood1.Size = new Size(444, 46);
            ButtonFastFood1.TabIndex = 5;
            ButtonFastFood1.Text = "button4";
            ButtonFastFood1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(chooseMenu);
            panel2.Controls.Add(comboRestaurant);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 85);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // chooseMenu
            // 
            chooseMenu.FormattingEnabled = true;
            chooseMenu.Location = new Point(587, 21);
            chooseMenu.Name = "chooseMenu";
            chooseMenu.Size = new Size(241, 40);
            chooseMenu.TabIndex = 9;
            chooseMenu.SelectedIndexChanged += chooseMenu_SelectedIndexChanged_1;
            // 
            // comboRestaurant
            // 
            comboRestaurant.FormattingEnabled = true;
            comboRestaurant.Location = new Point(37, 21);
            comboRestaurant.Name = "comboRestaurant";
            comboRestaurant.Size = new Size(241, 40);
            comboRestaurant.TabIndex = 8;
            // 
            // ClassicMenuButton
            // 
            ClassicMenuButton.Location = new Point(603, 110);
            ClassicMenuButton.Name = "ClassicMenuButton";
            ClassicMenuButton.Size = new Size(228, 101);
            ClassicMenuButton.TabIndex = 7;
            ClassicMenuButton.Text = "ClassicMenuButton";
            ClassicMenuButton.UseVisualStyleBackColor = true;
            ClassicMenuButton.Click += ClassicMenuButton_Click;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 662);
            Controls.Add(MainPanel);
            Controls.Add(button1);
            Name = "MapForm";
            Text = "MapForm";
            Load += MapForm_Load;
            MainPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel MainPanel;
        private Panel panel2;
        private Button ButtonRestaurant1;
        private Button ButtonCafe2;
        private Button ButtonCafe1;
        private Button ButtonRestaurant2;
        private Button ButtonFastFood2;
        private Button ButtonFastFood1;
        private ComboBox comboRestaurant;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SeasonMenuButton;
        private ComboBox chooseMenu;
        private Button ClassicMenuButton;
        private Button AddSeasonMenu;
    }
}