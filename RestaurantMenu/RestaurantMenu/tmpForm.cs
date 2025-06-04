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
    public partial class tmpForm : Form
    {
        public tmpForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel4 = new Panel();
            PanelForDeleteButton = new Panel();
            DeleteMealButton = new Button();
            PanelForMealDesc = new Panel();
            MealPrice = new Label();
            MealType = new Label();
            MealName = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            AddButton = new Button();
            comboBoxMealType = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            textBoxMealName = new TextBox();
            textPanel = new Panel();
            TypeMeal = new Label();
            label1 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            SaveButton = new Button();
            ChooseFileType = new ComboBox();
            label6 = new Label();
            panel4.SuspendLayout();
            PanelForDeleteButton.SuspendLayout();
            PanelForMealDesc.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            textPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(PanelForDeleteButton);
            panel4.Controls.Add(PanelForMealDesc);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(660, 84);
            panel4.TabIndex = 3;
            // 
            // PanelForDeleteButton
            // 
            PanelForDeleteButton.Controls.Add(DeleteMealButton);
            PanelForDeleteButton.Location = new Point(387, 3);
            PanelForDeleteButton.Name = "PanelForDeleteButton";
            PanelForDeleteButton.Size = new Size(268, 76);
            PanelForDeleteButton.TabIndex = 1;
            // 
            // DeleteMealButton
            // 
            DeleteMealButton.Font = new Font("Segoe UI", 10F);
            DeleteMealButton.Location = new Point(0, 0);
            DeleteMealButton.Name = "DeleteMealButton";
            DeleteMealButton.Size = new Size(268, 73);
            DeleteMealButton.TabIndex = 0;
            DeleteMealButton.Text = "Удалить из меню";
            DeleteMealButton.UseVisualStyleBackColor = true;
            // 
            // PanelForMealDesc
            // 
            PanelForMealDesc.Controls.Add(MealPrice);
            PanelForMealDesc.Controls.Add(MealType);
            PanelForMealDesc.Controls.Add(MealName);
            PanelForMealDesc.Location = new Point(3, 3);
            PanelForMealDesc.Name = "PanelForMealDesc";
            PanelForMealDesc.Size = new Size(378, 76);
            PanelForMealDesc.TabIndex = 0;
            // 
            // MealPrice
            // 
            MealPrice.Font = new Font("Segoe UI", 11F);
            MealPrice.Location = new Point(0, 50);
            MealPrice.Name = "MealPrice";
            MealPrice.Size = new Size(113, 25);
            MealPrice.TabIndex = 2;
            MealPrice.Text = "500 рублей";
            // 
            // MealType
            // 
            MealType.Font = new Font("Segoe UI", 10F);
            MealType.Location = new Point(0, 25);
            MealType.Name = "MealType";
            MealType.Size = new Size(260, 25);
            MealType.TabIndex = 1;
            MealType.Text = "Десерт";
            // 
            // MealName
            // 
            MealName.Dock = DockStyle.Top;
            MealName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            MealName.Location = new Point(0, 0);
            MealName.Name = "MealName";
            MealName.Size = new Size(378, 25);
            MealName.TabIndex = 0;
            MealName.Text = "Фирменный паштет от огузка";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(12, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(660, 84);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Location = new Point(387, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(268, 76);
            panel6.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(268, 73);
            button1.TabIndex = 0;
            button1.Text = "Удалить из меню";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(378, 76);
            panel7.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(0, 50);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 2;
            label2.Text = "700 рублей";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 25);
            label3.Name = "label3";
            label3.Size = new Size(260, 25);
            label3.TabIndex = 1;
            label3.Text = "Горячее блюдо";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(378, 25);
            label4.TabIndex = 0;
            label4.Text = "Буябес";
            // 
            // panel1
            // 
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(comboBoxMealType);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(textBoxMealName);
            panel1.Controls.Add(textPanel);
            panel1.Location = new Point(12, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 179);
            panel1.TabIndex = 5;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(245, 147);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(123, 29);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxMealType
            // 
            comboBoxMealType.FormattingEnabled = true;
            comboBoxMealType.Location = new Point(201, 106);
            comboBoxMealType.Name = "comboBoxMealType";
            comboBoxMealType.Size = new Size(204, 28);
            comboBoxMealType.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.HidePromptOnLeave = true;
            maskedTextBox1.Location = new Point(201, 66);
            maskedTextBox1.Mask = "0000000000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PromptChar = ' ';
            maskedTextBox1.Size = new Size(204, 27);
            maskedTextBox1.TabIndex = 3;
            // 
            // textBoxMealName
            // 
            textBoxMealName.Location = new Point(201, 29);
            textBoxMealName.MaxLength = 35;
            textBoxMealName.Name = "textBoxMealName";
            textBoxMealName.Size = new Size(204, 27);
            textBoxMealName.TabIndex = 1;
            // 
            // textPanel
            // 
            textPanel.Controls.Add(TypeMeal);
            textPanel.Controls.Add(label1);
            textPanel.Controls.Add(label5);
            textPanel.Location = new Point(15, 17);
            textPanel.Name = "textPanel";
            textPanel.Size = new Size(180, 146);
            textPanel.TabIndex = 0;
            // 
            // TypeMeal
            // 
            TypeMeal.Font = new Font("Segoe UI", 10F);
            TypeMeal.Location = new Point(15, 89);
            TypeMeal.Name = "TypeMeal";
            TypeMeal.Size = new Size(64, 28);
            TypeMeal.TabIndex = 2;
            TypeMeal.Text = "Тип:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(15, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Цена:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(15, 14);
            label5.Name = "label5";
            label5.Size = new Size(162, 25);
            label5.TabIndex = 0;
            label5.Text = "Название блюда:";
            // 
            // panel2
            // 
            panel2.Controls.Add(SaveButton);
            panel2.Controls.Add(ChooseFileType);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(17, 403);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 61);
            panel2.TabIndex = 6;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(340, 11);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(40, 29);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "✓";
            SaveButton.UseVisualStyleBackColor = true;
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
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 7);
            label6.Name = "label6";
            label6.Size = new Size(283, 41);
            label6.TabIndex = 0;
            label6.Text = "Сохранить меню в формате";
            // 
            // tmpForm
            // 
            ClientSize = new Size(948, 540);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "tmpForm";
            panel4.ResumeLayout(false);
            PanelForDeleteButton.ResumeLayout(false);
            PanelForMealDesc.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            textPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel4;
        private Panel PanelForDeleteButton;
        private Button DeleteMealButton;
        private Panel PanelForMealDesc;
        private Label MealPrice;
        private Label MealType;
        private Label MealName;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
        private Panel panel7;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button AddButton;
        private ComboBox comboBoxMealType;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBoxMealName;
        private Panel textPanel;
        private Label TypeMeal;
        private Label label1;
        private Label label5;
        private Panel panel2;
        private Button SaveButton;
        private ComboBox ChooseFileType;
        private Label label6;
        private Label label4;

        private void ChooseFileType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
