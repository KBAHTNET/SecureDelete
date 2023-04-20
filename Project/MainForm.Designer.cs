namespace Project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChoseFileButton = new CustomDesign.CustomButton();
            this.DeleteFileButton = new CustomDesign.CustomButton();
            this.pathToFile = new CustomDesign.CustomTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.text1Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.countRewriteTextBox = new CustomDesign.CustomTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DriversComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.RewriteDriveButton = new CustomDesign.CustomButton();
            this.egoldsProgressBar1 = new CustomDesign.EgoldsProgressBar();
            this.customFormStyle = new CustomDesign.Components.CustomFormStyle(this.components);
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.mainPanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.mainPanel.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 40);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(794, 557);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ChoseFileButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteFileButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pathToFile, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ChoseFileButton
            // 
            this.ChoseFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.ChoseFileButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.ChoseFileButton.BackColorGradientEnabled = false;
            this.ChoseFileButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ChoseFileButton.BorderColor = System.Drawing.Color.Red;
            this.ChoseFileButton.BorderColorEnabled = true;
            this.ChoseFileButton.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.ChoseFileButton.BorderColorOnHoverEnabled = true;
            this.ChoseFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoseFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoseFileButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ChoseFileButton.ForeColor = System.Drawing.Color.White;
            this.ChoseFileButton.Location = new System.Drawing.Point(1, 1);
            this.ChoseFileButton.Margin = new System.Windows.Forms.Padding(1);
            this.ChoseFileButton.Name = "ChoseFileButton";
            this.ChoseFileButton.RippleColor = System.Drawing.Color.Black;
            this.ChoseFileButton.RoundingEnable = false;
            this.ChoseFileButton.Size = new System.Drawing.Size(262, 48);
            this.ChoseFileButton.TabIndex = 0;
            this.ChoseFileButton.Text = "Выбрать файл";
            this.ChoseFileButton.TextHover = "Открыть проводник для выбора файла для безопасного удаления";
            this.ChoseFileButton.UseDownPressEffectOnClick = false;
            this.ChoseFileButton.UseRippleEffect = true;
            this.ChoseFileButton.UseZoomEffectOnHover = false;
            this.ChoseFileButton.Click += new System.EventHandler(this.ChoseFileButton_Click);
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.DeleteFileButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.DeleteFileButton.BackColorGradientEnabled = false;
            this.DeleteFileButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.DeleteFileButton.BorderColor = System.Drawing.Color.Tomato;
            this.DeleteFileButton.BorderColorEnabled = false;
            this.DeleteFileButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.DeleteFileButton.BorderColorOnHoverEnabled = false;
            this.DeleteFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteFileButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.DeleteFileButton.ForeColor = System.Drawing.Color.White;
            this.DeleteFileButton.Location = new System.Drawing.Point(529, 1);
            this.DeleteFileButton.Margin = new System.Windows.Forms.Padding(1);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.RippleColor = System.Drawing.Color.Black;
            this.DeleteFileButton.RoundingEnable = false;
            this.DeleteFileButton.Size = new System.Drawing.Size(264, 48);
            this.DeleteFileButton.TabIndex = 1;
            this.DeleteFileButton.Text = "Удалить файл";
            this.DeleteFileButton.TextHover = "Безопасное удаление файла с текущими настройками";
            this.DeleteFileButton.UseDownPressEffectOnClick = false;
            this.DeleteFileButton.UseRippleEffect = true;
            this.DeleteFileButton.UseZoomEffectOnHover = false;
            this.DeleteFileButton.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // pathToFile
            // 
            this.pathToFile.BackColor = System.Drawing.Color.Black;
            this.pathToFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.pathToFile.BorderColorNotActive = System.Drawing.Color.White;
            this.pathToFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathToFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathToFile.Font = new System.Drawing.Font("Arial", 11.25F);
            this.pathToFile.FontTextPreview = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathToFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.pathToFile.Location = new System.Drawing.Point(267, 3);
            this.pathToFile.Name = "pathToFile";
            this.pathToFile.Size = new System.Drawing.Size(258, 44);
            this.pathToFile.TabIndex = 2;
            this.pathToFile.TextInput = "";
            this.pathToFile.TextPreview = "Путь к файлу";
            this.pathToFile.UseSystemPasswordChar = false;
            this.pathToFile.TextChanged += new System.EventHandler(this.pathToFile_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.SettingsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.text1Label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.countRewriteTextBox, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 90);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.SettingsLabel.Location = new System.Drawing.Point(3, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(258, 21);
            this.SettingsLabel.TabIndex = 4;
            this.SettingsLabel.Text = "Настройка удаления:";
            // 
            // text1Label
            // 
            this.text1Label.AutoSize = true;
            this.text1Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.text1Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.text1Label.Location = new System.Drawing.Point(3, 45);
            this.text1Label.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.text1Label.Name = "text1Label";
            this.text1Label.Size = new System.Drawing.Size(258, 21);
            this.text1Label.TabIndex = 0;
            this.text1Label.Text = "Перезаписать при удалении";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0x00",
            "0xFF",
            "Random bytes"});
            this.comboBox1.Location = new System.Drawing.Point(267, 45);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // countRewriteTextBox
            // 
            this.countRewriteTextBox.BackColor = System.Drawing.Color.Black;
            this.countRewriteTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.countRewriteTextBox.BorderColorNotActive = System.Drawing.Color.White;
            this.countRewriteTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countRewriteTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countRewriteTextBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.countRewriteTextBox.FontTextPreview = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countRewriteTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.countRewriteTextBox.Location = new System.Drawing.Point(531, 33);
            this.countRewriteTextBox.Name = "countRewriteTextBox";
            this.countRewriteTextBox.Size = new System.Drawing.Size(260, 44);
            this.countRewriteTextBox.TabIndex = 3;
            this.countRewriteTextBox.TextInput = "";
            this.countRewriteTextBox.TextPreview = "раз";
            this.countRewriteTextBox.UseSystemPasswordChar = false;
            this.countRewriteTextBox.TextChanged += new System.EventHandler(this.countRewriteTextBox_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DriversComboBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.90749F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.09251F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 227);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // DriversComboBox
            // 
            this.DriversComboBox.BackColor = System.Drawing.Color.Black;
            this.DriversComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriversComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.DriversComboBox.FormattingEnabled = true;
            this.DriversComboBox.Location = new System.Drawing.Point(3, 3);
            this.DriversComboBox.Name = "DriversComboBox";
            this.DriversComboBox.Size = new System.Drawing.Size(259, 29);
            this.DriversComboBox.TabIndex = 2;
            this.DriversComboBox.SelectedIndexChanged += new System.EventHandler(this.DriversComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.textBox5, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox4, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(782, 169);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.textBox5.Location = new System.Drawing.Point(627, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 26);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.textBox4.Location = new System.Drawing.Point(471, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 26);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.textBox3.Location = new System.Drawing.Point(315, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 26);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.textBox2.Location = new System.Drawing.Point(159, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 26);
            this.textBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(627, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Всего места";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(471, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Всего свободного места";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(315, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Доступно места";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(159, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Файловая система";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.textBox1.Location = new System.Drawing.Point(3, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.RewriteDriveButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.egoldsProgressBar1, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 386);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(659, 168);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // RewriteDriveButton
            // 
            this.RewriteDriveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.RewriteDriveButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.RewriteDriveButton.BackColorGradientEnabled = false;
            this.RewriteDriveButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.RewriteDriveButton.BorderColor = System.Drawing.Color.Tomato;
            this.RewriteDriveButton.BorderColorEnabled = false;
            this.RewriteDriveButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.RewriteDriveButton.BorderColorOnHoverEnabled = false;
            this.RewriteDriveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RewriteDriveButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.RewriteDriveButton.ForeColor = System.Drawing.Color.White;
            this.RewriteDriveButton.Location = new System.Drawing.Point(3, 3);
            this.RewriteDriveButton.Name = "RewriteDriveButton";
            this.RewriteDriveButton.RippleColor = System.Drawing.Color.Black;
            this.RewriteDriveButton.RoundingEnable = false;
            this.RewriteDriveButton.Size = new System.Drawing.Size(241, 67);
            this.RewriteDriveButton.TabIndex = 4;
            this.RewriteDriveButton.Text = "Перезаписать";
            this.RewriteDriveButton.TextHover = "Перезаписать свободное место на выбранном диске с текущими настройками для удален" +
    "ия";
            this.RewriteDriveButton.UseDownPressEffectOnClick = false;
            this.RewriteDriveButton.UseRippleEffect = true;
            this.RewriteDriveButton.UseZoomEffectOnHover = false;
            this.RewriteDriveButton.Click += new System.EventHandler(this.RewriteDriveButton_Click);
            // 
            // egoldsProgressBar1
            // 
            this.egoldsProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.egoldsProgressBar1.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.egoldsProgressBar1.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.egoldsProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.egoldsProgressBar1.Location = new System.Drawing.Point(3, 87);
            this.egoldsProgressBar1.Name = "egoldsProgressBar1";
            this.egoldsProgressBar1.Size = new System.Drawing.Size(241, 44);
            this.egoldsProgressBar1.Step = 10;
            this.egoldsProgressBar1.TabIndex = 5;
            this.egoldsProgressBar1.Text = "egoldsProgressBar1";
            this.egoldsProgressBar1.Value = 50;
            this.egoldsProgressBar1.ValueMaximum = 100;
            this.egoldsProgressBar1.ValueMinimum = 0;
            // 
            // customFormStyle
            // 
            this.customFormStyle.AllowUserResize = true;
            this.customFormStyle.BackColor = System.Drawing.Color.Black;
            this.customFormStyle.ContextMenuForm = null;
            this.customFormStyle.ControlBoxButtonsWidth = 28;
            this.customFormStyle.EnableControlBoxIconsLight = true;
            this.customFormStyle.EnableControlBoxMouseLight = true;
            this.customFormStyle.Form = this;
            this.customFormStyle.FormBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.customFormStyle.FormStyle = CustomDesign.Components.CustomFormStyle.fStyle.UserStyle;
            this.customFormStyle.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.customFormStyle.HeaderColorAdditional = System.Drawing.Color.White;
            this.customFormStyle.HeaderColorGradientEnable = false;
            this.customFormStyle.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.customFormStyle.HeaderHeight = 38;
            this.customFormStyle.HeaderImage = null;
            this.customFormStyle.HeaderTextColor = System.Drawing.Color.Black;
            this.customFormStyle.HeaderTextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecureDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private CustomDesign.Components.CustomFormStyle customFormStyle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomDesign.CustomButton ChoseFileButton;
        private CustomDesign.CustomButton DeleteFileButton;
        private CustomDesign.CustomTextBox pathToFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label text1Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private CustomDesign.CustomTextBox countRewriteTextBox;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox DriversComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private CustomDesign.CustomButton RewriteDriveButton;
        private CustomDesign.EgoldsProgressBar egoldsProgressBar1;
    }
}

