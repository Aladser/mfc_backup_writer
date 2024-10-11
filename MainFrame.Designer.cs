namespace ms_word_writer
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateLabel = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.copyContentLabel = new System.Windows.Forms.Label();
            this.copySizeLabel = new System.Windows.Forms.Label();
            this.storageNumberLabel = new System.Windows.Forms.Label();
            this.storagePlaceLabel = new System.Windows.Forms.Label();
            this.personLabel = new System.Windows.Forms.Label();
            this.copySizeField = new System.Windows.Forms.TextBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.copyContentField = new System.Windows.Forms.ComboBox();
            this.storageNumberField = new System.Windows.Forms.ComboBox();
            this.storagePlaceField = new System.Windows.Forms.ComboBox();
            this.personField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(21, 402);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(106, 36);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Открыть";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(18, 32);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(431, 23);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Дата создания резервной";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(158, 402);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(99, 36);
            this.writeButton.TabIndex = 7;
            this.writeButton.Text = "Записать";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(911, 12);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(333, 435);
            this.contentTextBox.TabIndex = 8;
            this.contentTextBox.Text = "";
            // 
            // copyContentLabel
            // 
            this.copyContentLabel.Location = new System.Drawing.Point(18, 99);
            this.copyContentLabel.Name = "copyContentLabel";
            this.copyContentLabel.Size = new System.Drawing.Size(431, 16);
            this.copyContentLabel.TabIndex = 9;
            this.copyContentLabel.Text = "Содержание резервной копии";
            // 
            // copySizeLabel
            // 
            this.copySizeLabel.Location = new System.Drawing.Point(18, 157);
            this.copySizeLabel.Name = "copySizeLabel";
            this.copySizeLabel.Size = new System.Drawing.Size(431, 23);
            this.copySizeLabel.TabIndex = 10;
            this.copySizeLabel.Text = "Размер резервной копии (Гб)";
            // 
            // storageNumberLabel
            // 
            this.storageNumberLabel.Location = new System.Drawing.Point(18, 217);
            this.storageNumberLabel.Name = "storageNumberLabel";
            this.storageNumberLabel.Size = new System.Drawing.Size(431, 16);
            this.storageNumberLabel.TabIndex = 11;
            this.storageNumberLabel.Text = "Учетный номер носителя";
            // 
            // storagePlaceLabel
            // 
            this.storagePlaceLabel.Location = new System.Drawing.Point(18, 280);
            this.storagePlaceLabel.Name = "storagePlaceLabel";
            this.storagePlaceLabel.Size = new System.Drawing.Size(437, 16);
            this.storagePlaceLabel.TabIndex = 12;
            this.storagePlaceLabel.Text = "Место хранения носителя";
            // 
            // personLabel
            // 
            this.personLabel.Location = new System.Drawing.Point(18, 343);
            this.personLabel.Name = "personLabel";
            this.personLabel.Size = new System.Drawing.Size(437, 23);
            this.personLabel.TabIndex = 13;
            this.personLabel.Text = "ФИО, должность лица, осуществившего резервное копирование";
            // 
            // copySizeField
            // 
            this.copySizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copySizeField.Location = new System.Drawing.Point(473, 147);
            this.copySizeField.Name = "copySizeField";
            this.copySizeField.Size = new System.Drawing.Size(423, 28);
            this.copySizeField.TabIndex = 4;
            // 
            // dateField
            // 
            this.dateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.Location = new System.Drawing.Point(473, 32);
            this.dateField.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateField.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(423, 28);
            this.dateField.TabIndex = 2;
            // 
            // copyContentField
            // 
            this.copyContentField.DisplayMember = "0";
            this.copyContentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.copyContentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyContentField.FormattingEnabled = true;
            this.copyContentField.Items.AddRange(new object[] {
            "Database MFC",
            "Database 1C/Intep",
            "Database 1C",
            "Database Intep"});
            this.copyContentField.SelectedIndex = 0;
            this.copyContentField.Location = new System.Drawing.Point(473, 93);
            this.copyContentField.Name = "copyContentField";
            this.copyContentField.Size = new System.Drawing.Size(423, 30);
            this.copyContentField.TabIndex = 15;
            // 
            // storageNumberField
            // 
            this.storageNumberField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storageNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storageNumberField.FormattingEnabled = true;
            this.storageNumberField.Items.AddRange(new object[] {
            "NA9NLF36",
            "WXF1CC1C8000"});
            this.storageNumberField.SelectedIndex = 0;
            this.storageNumberField.Location = new System.Drawing.Point(473, 209);
            this.storageNumberField.Name = "storageNumberField";
            this.storageNumberField.Size = new System.Drawing.Size(423, 30);
            this.storageNumberField.TabIndex = 16;
            // 
            // storagePlaceField
            // 
            this.storagePlaceField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storagePlaceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storagePlaceField.FormattingEnabled = true;
            this.storagePlaceField.Items.AddRange(new object[] {
            "Серверная 50 лет Октября 4/2",
            "Кабинет 101",
            "Кабинет 105"});
            this.storagePlaceField.SelectedIndex = 0;
            this.storagePlaceField.Location = new System.Drawing.Point(473, 272);
            this.storagePlaceField.Name = "storagePlaceField";
            this.storagePlaceField.Size = new System.Drawing.Size(423, 30);
            this.storagePlaceField.TabIndex = 17;
            // 
            // personField
            // 
            this.personField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personField.FormattingEnabled = true;
            this.personField.Items.AddRange(new object[] {
            "Авраменко А.С., инженер-программист",
            "Тихонов В.Г., ведущий программист",
            "Хлобыстов И.В., .ведущий программист",
            "Андрущенко А.В., ведущий программист",
            "Гаманец В.Г., начальник отдела"});
            this.personField.SelectedIndex = 0;
            this.personField.Location = new System.Drawing.Point(473, 333);
            this.personField.Name = "personField";
            this.personField.Size = new System.Drawing.Size(423, 33);
            this.personField.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 464);
            this.Controls.Add(this.personField);
            this.Controls.Add(this.storagePlaceField);
            this.Controls.Add(this.storageNumberField);
            this.Controls.Add(this.copyContentField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.copySizeField);
            this.Controls.Add(this.personLabel);
            this.Controls.Add(this.storagePlaceLabel);
            this.Controls.Add(this.storageNumberLabel);
            this.Controls.Add(this.copySizeLabel);
            this.Controls.Add(this.copyContentLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.openFileButton);
            this.Name = "MainForm";
            this.Text = "Запись бэкапов в DOCX-файл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Label copyContentLabel;
        private System.Windows.Forms.Label copySizeLabel;
        private System.Windows.Forms.Label storageNumberLabel;
        private System.Windows.Forms.Label storagePlaceLabel;
        private System.Windows.Forms.Label personLabel;
        private System.Windows.Forms.TextBox copySizeField;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.ComboBox copyContentField;
        private System.Windows.Forms.ComboBox storageNumberField;
        private System.Windows.Forms.ComboBox storagePlaceField;
        private System.Windows.Forms.ComboBox personField;
    }
}

