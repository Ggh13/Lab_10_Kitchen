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
            button1 = new Button();
            MainPanel = new Panel();
            ButtonFastFood2 = new Button();
            ButtonFastFood1 = new Button();
            ButtonCafe2 = new Button();
            ButtonCafe1 = new Button();
            ButtonRestaurant2 = new Button();
            ButtonRestaurant1 = new Button();
            panel2 = new Panel();
            FastFoodCheckBox = new CheckBox();
            CafeCheckBox = new CheckBox();
            RestaurantCheckBox = new CheckBox();
            CloseButton = new Label();
            label1 = new Label();
            MainPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(341, 91);
            button1.Name = "button1";
            button1.Size = new Size(198, 76);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.MenuHighlight;
            MainPanel.Controls.Add(ButtonFastFood2);
            MainPanel.Controls.Add(ButtonFastFood1);
            MainPanel.Controls.Add(ButtonCafe2);
            MainPanel.Controls.Add(ButtonCafe1);
            MainPanel.Controls.Add(ButtonRestaurant2);
            MainPanel.Controls.Add(ButtonRestaurant1);
            MainPanel.Controls.Add(panel2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(894, 662);
            MainPanel.TabIndex = 1;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // ButtonFastFood2
            // 
            ButtonFastFood2.Location = new Point(582, 516);
            ButtonFastFood2.Name = "ButtonFastFood2";
            ButtonFastFood2.Size = new Size(150, 46);
            ButtonFastFood2.TabIndex = 6;
            ButtonFastFood2.Text = "button5";
            ButtonFastFood2.UseVisualStyleBackColor = true;
            // 
            // ButtonFastFood1
            // 
            ButtonFastFood1.Location = new Point(142, 516);
            ButtonFastFood1.Name = "ButtonFastFood1";
            ButtonFastFood1.Size = new Size(150, 46);
            ButtonFastFood1.TabIndex = 5;
            ButtonFastFood1.Text = "button4";
            ButtonFastFood1.UseVisualStyleBackColor = true;
            // 
            // ButtonCafe2
            // 
            ButtonCafe2.Location = new Point(582, 393);
            ButtonCafe2.Name = "ButtonCafe2";
            ButtonCafe2.Size = new Size(150, 46);
            ButtonCafe2.TabIndex = 4;
            ButtonCafe2.Text = "button5";
            ButtonCafe2.UseVisualStyleBackColor = true;
            // 
            // ButtonCafe1
            // 
            ButtonCafe1.Location = new Point(142, 378);
            ButtonCafe1.Name = "ButtonCafe1";
            ButtonCafe1.Size = new Size(150, 46);
            ButtonCafe1.TabIndex = 3;
            ButtonCafe1.Text = "button4";
            ButtonCafe1.UseVisualStyleBackColor = true;
            ButtonCafe1.Click += ButtonCafe1_Click;
            // 
            // ButtonRestaurant2
            // 
            ButtonRestaurant2.Location = new Point(582, 198);
            ButtonRestaurant2.Name = "ButtonRestaurant2";
            ButtonRestaurant2.Size = new Size(150, 46);
            ButtonRestaurant2.TabIndex = 2;
            ButtonRestaurant2.Text = "button3";
            ButtonRestaurant2.UseVisualStyleBackColor = true;
            // 
            // ButtonRestaurant1
            // 
            ButtonRestaurant1.Location = new Point(110, 252);
            ButtonRestaurant1.Name = "ButtonRestaurant1";
            ButtonRestaurant1.Size = new Size(213, 61);
            ButtonRestaurant1.TabIndex = 1;
            ButtonRestaurant1.Text = "button2";
            ButtonRestaurant1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(FastFoodCheckBox);
            panel2.Controls.Add(CafeCheckBox);
            panel2.Controls.Add(RestaurantCheckBox);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 85);
            panel2.TabIndex = 0;
            // 
            // FastFoodCheckBox
            // 
            FastFoodCheckBox.AutoSize = true;
            FastFoodCheckBox.Location = new Point(654, 26);
            FastFoodCheckBox.Name = "FastFoodCheckBox";
            FastFoodCheckBox.Size = new Size(138, 36);
            FastFoodCheckBox.TabIndex = 4;
            FastFoodCheckBox.Text = "ФастФуд";
            FastFoodCheckBox.UseVisualStyleBackColor = true;
            FastFoodCheckBox.CheckedChanged += FastFoodCheckBox_CheckedChanged;
            // 
            // CafeCheckBox
            // 
            CafeCheckBox.AutoSize = true;
            CafeCheckBox.Location = new Point(484, 26);
            CafeCheckBox.Name = "CafeCheckBox";
            CafeCheckBox.Size = new Size(101, 36);
            CafeCheckBox.TabIndex = 3;
            CafeCheckBox.Text = "Кафе";
            CafeCheckBox.UseVisualStyleBackColor = true;
            CafeCheckBox.CheckedChanged += FastFoodCheckBox_CheckedChanged;
            // 
            // RestaurantCheckBox
            // 
            RestaurantCheckBox.AutoSize = true;
            RestaurantCheckBox.Location = new Point(314, 26);
            RestaurantCheckBox.Name = "RestaurantCheckBox";
            RestaurantCheckBox.Size = new Size(164, 36);
            RestaurantCheckBox.TabIndex = 2;
            RestaurantCheckBox.Text = "Рестораны";
            RestaurantCheckBox.UseVisualStyleBackColor = true;
            RestaurantCheckBox.CheckedChanged += RestaurantCheckBox_CheckedChanged;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.BackColor = SystemColors.ActiveCaption;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Location = new Point(863, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(28, 32);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 7);
            label1.Name = "label1";
            label1.Size = new Size(323, 78);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 662);
            Controls.Add(MainPanel);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MapForm";
            Text = "MapForm";
            MainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel MainPanel;
        private Panel panel2;
        private Label label1;
        private Label CloseButton;
        private CheckBox RestaurantCheckBox;
        private Button ButtonRestaurant1;
        private Button ButtonCafe2;
        private Button ButtonCafe1;
        private Button ButtonRestaurant2;
        private Button ButtonFastFood2;
        private Button ButtonFastFood1;
        private CheckBox FastFoodCheckBox;
        private CheckBox CafeCheckBox;
    }
}