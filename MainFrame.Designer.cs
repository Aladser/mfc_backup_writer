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
            this.numberLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.numberField = new System.Windows.Forms.TextBox();
            this.dateField = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(915, 356);
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
            // numberLabel
            // 
            this.numberLabel.Location = new System.Drawing.Point(18, 12);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(431, 23);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "№ п/п";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(18, 50);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(431, 23);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Дата создания резервной";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberField
            // 
            this.numberField.Location = new System.Drawing.Point(473, 12);
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(303, 22);
            this.numberField.TabIndex = 4;
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(473, 50);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(303, 22);
            this.dateField.TabIndex = 6;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(1027, 356);
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
            this.contentTextBox.Size = new System.Drawing.Size(333, 329);
            this.contentTextBox.TabIndex = 8;
            this.contentTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Содержание резервной копии";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Размер резервной копии (Мб)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Учетный номер носителя";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Место хранения носителя";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "ФИО, должность лица, осуществившего резервное копирование";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Подпись должностного лица, осуществившего резервное копирование";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(473, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(473, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(303, 22);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(473, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(303, 22);
            this.textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(473, 268);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(303, 22);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(473, 319);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(303, 22);
            this.textBox6.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 404);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.numberField);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.openFileButton);
            this.Name = "MainForm";
            this.Text = "Word Table Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox numberField;
        private System.Windows.Forms.TextBox dateField;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

