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
            CloseButton = new Label();
            ClassicMenuButton = new Button();
            MainPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(210, 57);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(122, 48);
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
            MainPanel.Margin = new Padding(2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(550, 414);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // AddSeasonMenu
            // 
            AddSeasonMenu.Location = new Point(327, 361);
            AddSeasonMenu.Margin = new Padding(2);
            AddSeasonMenu.Name = "AddSeasonMenu";
            AddSeasonMenu.Size = new Size(210, 29);
            AddSeasonMenu.TabIndex = 10;
            AddSeasonMenu.Text = "Добавить сезонное меню";
            AddSeasonMenu.UseVisualStyleBackColor = true;
            AddSeasonMenu.Click += AddSeasonMenu_Click;
            // 
            // SeasonMenuButton
            // 
            SeasonMenuButton.Location = new Point(371, 140);
            SeasonMenuButton.Margin = new Padding(2);
            SeasonMenuButton.Name = "SeasonMenuButton";
            SeasonMenuButton.Size = new Size(140, 68);
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
            flowLayoutPanel1.Location = new Point(0, 57);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(306, 357);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // ButtonFastFood2
            // 
            ButtonFastFood2.Location = new Point(2, 2);
            ButtonFastFood2.Margin = new Padding(2);
            ButtonFastFood2.Name = "ButtonFastFood2";
            ButtonFastFood2.Size = new Size(237, 29);
            ButtonFastFood2.TabIndex = 6;
            ButtonFastFood2.Text = "button5";
            ButtonFastFood2.UseVisualStyleBackColor = true;
            // 
            // ButtonCafe2
            // 
            ButtonCafe2.Location = new Point(2, 35);
            ButtonCafe2.Margin = new Padding(2);
            ButtonCafe2.Name = "ButtonCafe2";
            ButtonCafe2.Size = new Size(273, 29);
            ButtonCafe2.TabIndex = 4;
            ButtonCafe2.Text = "button5";
            ButtonCafe2.UseVisualStyleBackColor = true;
            // 
            // ButtonRestaurant1
            // 
            ButtonRestaurant1.Location = new Point(2, 68);
            ButtonRestaurant1.Margin = new Padding(2);
            ButtonRestaurant1.Name = "ButtonRestaurant1";
            ButtonRestaurant1.Size = new Size(258, 38);
            ButtonRestaurant1.TabIndex = 1;
            ButtonRestaurant1.Text = "button2";
            ButtonRestaurant1.UseVisualStyleBackColor = true;
            ButtonRestaurant1.Click += ButtonRestaurant1_Click;
            // 
            // ButtonRestaurant2
            // 
            ButtonRestaurant2.Location = new Point(2, 110);
            ButtonRestaurant2.Margin = new Padding(2);
            ButtonRestaurant2.Name = "ButtonRestaurant2";
            ButtonRestaurant2.Size = new Size(292, 29);
            ButtonRestaurant2.TabIndex = 2;
            ButtonRestaurant2.Text = "button3";
            ButtonRestaurant2.UseVisualStyleBackColor = true;
            // 
            // ButtonCafe1
            // 
            ButtonCafe1.Location = new Point(2, 143);
            ButtonCafe1.Margin = new Padding(2);
            ButtonCafe1.Name = "ButtonCafe1";
            ButtonCafe1.Size = new Size(263, 29);
            ButtonCafe1.TabIndex = 3;
            ButtonCafe1.Text = "button4";
            ButtonCafe1.UseVisualStyleBackColor = true;
            ButtonCafe1.Click += ButtonCafe1_Click;
            // 
            // ButtonFastFood1
            // 
            ButtonFastFood1.Location = new Point(2, 176);
            ButtonFastFood1.Margin = new Padding(2);
            ButtonFastFood1.Name = "ButtonFastFood1";
            ButtonFastFood1.Size = new Size(273, 29);
            ButtonFastFood1.TabIndex = 5;
            ButtonFastFood1.Text = "button4";
            ButtonFastFood1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(chooseMenu);
            panel2.Controls.Add(comboRestaurant);
            panel2.Controls.Add(CloseButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 53);
            panel2.TabIndex = 0;
            // 
            // chooseMenu
            // 
            chooseMenu.FormattingEnabled = true;
            chooseMenu.Location = new Point(361, 13);
            chooseMenu.Margin = new Padding(2);
            chooseMenu.Name = "chooseMenu";
            chooseMenu.Size = new Size(150, 28);
            chooseMenu.TabIndex = 9;
            chooseMenu.SelectedIndexChanged += chooseMenu_SelectedIndexChanged_1;
            // 
            // comboRestaurant
            // 
            comboRestaurant.FormattingEnabled = true;
            comboRestaurant.Location = new Point(23, 13);
            comboRestaurant.Margin = new Padding(2);
            comboRestaurant.Name = "comboRestaurant";
            comboRestaurant.Size = new Size(150, 28);
            comboRestaurant.TabIndex = 8;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.BackColor = SystemColors.ActiveCaption;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Location = new Point(532, 0);
            CloseButton.Margin = new Padding(2, 0, 2, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(18, 20);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // ClassicMenuButton
            // 
            ClassicMenuButton.Location = new Point(371, 69);
            ClassicMenuButton.Margin = new Padding(2);
            ClassicMenuButton.Name = "ClassicMenuButton";
            ClassicMenuButton.Size = new Size(140, 63);
            ClassicMenuButton.TabIndex = 7;
            ClassicMenuButton.Text = "ClassicMenuButton";
            ClassicMenuButton.UseVisualStyleBackColor = true;
            ClassicMenuButton.Click += ClassicMenuButton_Click;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 414);
            Controls.Add(MainPanel);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MapForm";
            Text = "MapForm";
            Load += MapForm_Load;
            MainPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel MainPanel;
        private Panel panel2;
        private Label CloseButton;
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