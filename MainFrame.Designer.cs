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
            this.signatureLabel = new System.Windows.Forms.Label();
            this.copySizeField = new System.Windows.Forms.TextBox();
            this.storageNumberField = new System.Windows.Forms.TextBox();
            this.storagePlaceField = new System.Windows.Forms.TextBox();
            this.personField = new System.Windows.Forms.TextBox();
            this.signatureField = new System.Windows.Forms.TextBox();
            this.copyContentField = new System.Windows.Forms.TextBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 451);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(106, 36);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Открыть";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
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
            this.writeButton.Location = new System.Drawing.Point(145, 451);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(99, 36);
            this.writeButton.TabIndex = 7;
            this.writeButton.Text = "Записать";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(793, 12);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(333, 419);
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
            this.copySizeLabel.Text = "Размер резервной копии (Мб)";
            // 
            // storageNumberLabel
            // 
            this.storageNumberLabel.Location = new System.Drawing.Point(18, 223);
            this.storageNumberLabel.Name = "storageNumberLabel";
            this.storageNumberLabel.Size = new System.Drawing.Size(431, 16);
            this.storageNumberLabel.TabIndex = 11;
            this.storageNumberLabel.Text = "Учетный номер носителя";
            // 
            // storagePlaceLabel
            // 
            this.storagePlaceLabel.Location = new System.Drawing.Point(18, 286);
            this.storagePlaceLabel.Name = "storagePlaceLabel";
            this.storagePlaceLabel.Size = new System.Drawing.Size(437, 16);
            this.storagePlaceLabel.TabIndex = 12;
            this.storagePlaceLabel.Text = "Место хранения носителя";
            // 
            // personLabel
            // 
            this.personLabel.Location = new System.Drawing.Point(18, 348);
            this.personLabel.Name = "personLabel";
            this.personLabel.Size = new System.Drawing.Size(437, 23);
            this.personLabel.TabIndex = 13;
            this.personLabel.Text = "ФИО, должность лица, осуществившего резервное копирование";
            // 
            // signatureLabel
            // 
            this.signatureLabel.Location = new System.Drawing.Point(18, 408);
            this.signatureLabel.Name = "signatureLabel";
            this.signatureLabel.Size = new System.Drawing.Size(437, 23);
            this.signatureLabel.TabIndex = 14;
            this.signatureLabel.Text = "Подпись должностного лица, осуществившего резервное копирование";
            this.signatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copySizeField
            // 
            this.copySizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copySizeField.Location = new System.Drawing.Point(473, 147);
            this.copySizeField.Name = "copySizeField";
            this.copySizeField.Size = new System.Drawing.Size(303, 30);
            this.copySizeField.TabIndex = 4;
            // 
            // storageNumberField
            // 
            this.storageNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storageNumberField.Location = new System.Drawing.Point(473, 213);
            this.storageNumberField.Name = "storageNumberField";
            this.storageNumberField.Size = new System.Drawing.Size(303, 30);
            this.storageNumberField.TabIndex = 5;
            // 
            // storagePlaceField
            // 
            this.storagePlaceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storagePlaceField.Location = new System.Drawing.Point(473, 276);
            this.storagePlaceField.Name = "storagePlaceField";
            this.storagePlaceField.Size = new System.Drawing.Size(303, 30);
            this.storagePlaceField.TabIndex = 6;
            // 
            // personField
            // 
            this.personField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personField.Location = new System.Drawing.Point(473, 338);
            this.personField.Name = "personField";
            this.personField.Size = new System.Drawing.Size(303, 30);
            this.personField.TabIndex = 7;
            // 
            // signatureField
            // 
            this.signatureField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signatureField.Location = new System.Drawing.Point(473, 401);
            this.signatureField.Name = "signatureField";
            this.signatureField.Size = new System.Drawing.Size(303, 30);
            this.signatureField.TabIndex = 8;
            // 
            // copyContentField
            // 
            this.copyContentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyContentField.Location = new System.Drawing.Point(473, 89);
            this.copyContentField.Name = "copyContentField";
            this.copyContentField.Size = new System.Drawing.Size(303, 30);
            this.copyContentField.TabIndex = 3;
            // 
            // dateField
            // 
            this.dateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.Location = new System.Drawing.Point(473, 32);
            this.dateField.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateField.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(303, 26);
            this.dateField.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 512);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.signatureField);
            this.Controls.Add(this.personField);
            this.Controls.Add(this.storagePlaceField);
            this.Controls.Add(this.storageNumberField);
            this.Controls.Add(this.copyContentField);
            this.Controls.Add(this.copySizeField);
            this.Controls.Add(this.signatureLabel);
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
        private System.Windows.Forms.Label signatureLabel;
        private System.Windows.Forms.TextBox copySizeField;
        private System.Windows.Forms.TextBox storageNumberField;
        private System.Windows.Forms.TextBox storagePlaceField;
        private System.Windows.Forms.TextBox personField;
        private System.Windows.Forms.TextBox signatureField;
        private System.Windows.Forms.TextBox copyContentField;
        private System.Windows.Forms.DateTimePicker dateField;
    }
}

