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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateLabel = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.copyContentLabel = new System.Windows.Forms.Label();
            this.copySizeLabel = new System.Windows.Forms.Label();
            this.workerLabel = new System.Windows.Forms.Label();
            this.backupSizeField = new System.Windows.Forms.TextBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.backupContentField = new System.Windows.Forms.ComboBox();
            this.workerField = new System.Windows.Forms.ComboBox();
            this.backupNameLabel = new System.Windows.Forms.Label();
            this.backupNameField = new System.Windows.Forms.Label();
            this.contentField = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(21, 355);
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
            this.dateLabel.Size = new System.Drawing.Size(284, 26);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Дата создания резервной копии";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // writeButton
            // 
            this.writeButton.Enabled = false;
            this.writeButton.Location = new System.Drawing.Point(150, 355);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(99, 36);
            this.writeButton.TabIndex = 7;
            this.writeButton.Text = "Записать";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // copyContentLabel
            // 
            this.copyContentLabel.Location = new System.Drawing.Point(18, 99);
            this.copyContentLabel.Name = "copyContentLabel";
            this.copyContentLabel.Size = new System.Drawing.Size(284, 16);
            this.copyContentLabel.TabIndex = 9;
            this.copyContentLabel.Text = "Содержание резервной копии";
            // 
            // copySizeLabel
            // 
            this.copySizeLabel.Location = new System.Drawing.Point(18, 157);
            this.copySizeLabel.Name = "copySizeLabel";
            this.copySizeLabel.Size = new System.Drawing.Size(284, 23);
            this.copySizeLabel.TabIndex = 10;
            this.copySizeLabel.Text = "Размер резервной копии (Гб)";
            // 
            // workerLabel
            // 
            this.workerLabel.Location = new System.Drawing.Point(18, 208);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(284, 38);
            this.workerLabel.TabIndex = 13;
            this.workerLabel.Text = "ФИО, должность лица, осуществившего резервное копирование";
            // 
            // backupSizeField
            // 
            this.backupSizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backupSizeField.Location = new System.Drawing.Point(308, 149);
            this.backupSizeField.Name = "backupSizeField";
            this.backupSizeField.Size = new System.Drawing.Size(423, 28);
            this.backupSizeField.TabIndex = 4;
            // 
            // dateField
            // 
            this.dateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.Location = new System.Drawing.Point(308, 32);
            this.dateField.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateField.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(423, 26);
            this.dateField.TabIndex = 2;
            // 
            // backupContentField
            // 
            this.backupContentField.DisplayMember = "0";
            this.backupContentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backupContentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backupContentField.FormattingEnabled = true;
            this.backupContentField.Items.AddRange(new object[] {
            "Database MFC",
            "Database 1C/Intep"});
            this.backupContentField.Location = new System.Drawing.Point(308, 93);
            this.backupContentField.Name = "backupContentField";
            this.backupContentField.Size = new System.Drawing.Size(423, 28);
            this.backupContentField.TabIndex = 15;
            // 
            // workerField
            // 
            this.workerField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerField.FormattingEnabled = true;
            this.workerField.Items.AddRange(new object[] {
            "Авраменко А.С., инженер-программист",
            "Тихонов В.Г., ведущий программист",
            "Хлобыстов И.В., .ведущий программист",
            "Андрущенко А.В., ведущий программист",
            "Гаманец В.Г., начальник отдела"});
            this.workerField.Location = new System.Drawing.Point(308, 208);
            this.workerField.Name = "workerField";
            this.workerField.Size = new System.Drawing.Size(423, 28);
            this.workerField.TabIndex = 18;
            // 
            // backupNameLabel
            // 
            this.backupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backupNameLabel.Location = new System.Drawing.Point(17, 284);
            this.backupNameLabel.Name = "backupNameLabel";
            this.backupNameLabel.Size = new System.Drawing.Size(284, 23);
            this.backupNameLabel.TabIndex = 19;
            this.backupNameLabel.Text = "Бэкап";
            // 
            // backupNameField
            // 
            this.backupNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backupNameField.Location = new System.Drawing.Point(17, 307);
            this.backupNameField.Name = "backupNameField";
            this.backupNameField.Size = new System.Drawing.Size(714, 27);
            this.backupNameField.TabIndex = 20;
            // 
            // contentField
            // 
            this.contentField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentField.Location = new System.Drawing.Point(755, 32);
            this.contentField.Name = "contentField";
            this.contentField.ReadOnly = true;
            this.contentField.Size = new System.Drawing.Size(489, 359);
            this.contentField.TabIndex = 8;
            this.contentField.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ms_word_writer.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(703, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 21);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "MFC Backup Writer 1.0\r\nAladser (c)\r\n2024");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backupNameField);
            this.Controls.Add(this.backupNameLabel);
            this.Controls.Add(this.workerField);
            this.Controls.Add(this.backupContentField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.backupSizeField);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.copySizeLabel);
            this.Controls.Add(this.copyContentLabel);
            this.Controls.Add(this.contentField);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.openFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "МФЦ: Запись бэкапов в DOCX-файл 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Label copyContentLabel;
        private System.Windows.Forms.Label copySizeLabel;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.TextBox backupSizeField;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.ComboBox backupContentField;
        private System.Windows.Forms.ComboBox workerField;
        private System.Windows.Forms.Label backupNameLabel;
        private System.Windows.Forms.Label backupNameField;
        private System.Windows.Forms.RichTextBox contentField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

