namespace RestaurantMenu
{
    partial class VenueForm
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
            sidebar = new Panel();
            MealTypeFinderLabel = new Label();
            ComboBoxMealType = new ComboBox();
            header = new Panel();
            MealsLabel = new Label();
            panel1 = new Panel();
            AddMealButton = new Button();
            panel2 = new Panel();
            SaveButton = new Button();
            ChooseFileType = new ComboBox();
            label1 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            sidebar.SuspendLayout();
            header.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BorderStyle = BorderStyle.FixedSingle;
            sidebar.Controls.Add(MealTypeFinderLabel);
            sidebar.Controls.Add(ComboBoxMealType);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(241, 753);
            sidebar.TabIndex = 1;
            // 
            // MealTypeFinderLabel
            // 
            MealTypeFinderLabel.Dock = DockStyle.Top;
            MealTypeFinderLabel.Font = new Font("Segoe UI", 14F);
            MealTypeFinderLabel.Location = new Point(0, 0);
            MealTypeFinderLabel.Name = "MealTypeFinderLabel";
            MealTypeFinderLabel.Size = new Size(239, 76);
            MealTypeFinderLabel.TabIndex = 1;
            MealTypeFinderLabel.Text = "Тип блюда";
            MealTypeFinderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComboBoxMealType
            // 
            ComboBoxMealType.DropDownHeight = 150;
            ComboBoxMealType.Font = new Font("Segoe UI", 12F);
            ComboBoxMealType.FormattingEnabled = true;
            ComboBoxMealType.IntegralHeight = false;
            ComboBoxMealType.Location = new Point(3, 76);
            ComboBoxMealType.Name = "ComboBoxMealType";
            ComboBoxMealType.Size = new Size(233, 36);
            ComboBoxMealType.Sorted = true;
            ComboBoxMealType.TabIndex = 0;
            ComboBoxMealType.SelectedIndexChanged += ComboBoxMealType_SelectedIndexChanged;
            // 
            // header
            // 
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(MealsLabel);
            header.Dock = DockStyle.Top;
            header.Location = new Point(241, 0);
            header.Name = "header";
            header.Size = new Size(741, 77);
            header.TabIndex = 2;
            header.Paint += header_Paint;
            // 
            // MealsLabel
            // 
            MealsLabel.Dock = DockStyle.Fill;
            MealsLabel.Font = new Font("Segoe UI", 28F);
            MealsLabel.Location = new Point(0, 0);
            MealsLabel.Name = "MealsLabel";
            MealsLabel.Size = new Size(739, 75);
            MealsLabel.TabIndex = 0;
            MealsLabel.Text = "Блюда";
            MealsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(AddMealButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(241, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 57);
            panel1.TabIndex = 3;
            // 
            // AddMealButton
            // 
            AddMealButton.Font = new Font("Segoe UI", 12F);
            AddMealButton.Location = new Point(419, 3);
            AddMealButton.Name = "AddMealButton";
            AddMealButton.Size = new Size(295, 48);
            AddMealButton.TabIndex = 4;
            AddMealButton.Text = "Добавить позицию в меню";
            AddMealButton.UseVisualStyleBackColor = true;
            AddMealButton.Click += AddMealButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(SaveButton);
            panel2.Controls.Add(ChooseFileType);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(5, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 61);
            panel2.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(340, 11);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(40, 29);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "✓";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ChooseFileType
            // 
            ChooseFileType.FormattingEnabled = true;
            ChooseFileType.Location = new Point(271, 11);
            ChooseFileType.Name = "ChooseFileType";
            ChooseFileType.Size = new Size(63, 28);
            ChooseFileType.TabIndex = 4;
            ChooseFileType.SelectedIndexChanged += ChooseFileType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(283, 41);
            label1.TabIndex = 0;
            label1.Text = "Сохранить меню в формате";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(241, 134);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(741, 619);
            flowLayoutPanel.TabIndex = 4;
            flowLayoutPanel.Paint += flowLayoutPanel_Paint;
            // 
            // VenueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panel1);
            Controls.Add(header);
            Controls.Add(sidebar);
            Name = "VenueForm";
            Text = "VenueForm";
            Load += VenueForm_Load;
            sidebar.ResumeLayout(false);
            header.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebar;
        private Panel header;
        private Panel panel1;
        private Label MealsLabel;
        private ComboBox ComboBoxMealType;
        private Label MealTypeFinderLabel;
        private Panel panel2;
        private Label label1;
        private ComboBox ChooseFileType;
        private Button SaveButton;
        private Button AddMealButton;
        private FlowLayoutPanel flowLayoutPanel;
    }
}