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
            this.contextBox = new System.Windows.Forms.RichTextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // contextBox
            // 
            this.contextBox.Location = new System.Drawing.Point(12, 12);
            this.contextBox.Name = "contextBox";
            this.contextBox.Size = new System.Drawing.Size(664, 247);
            this.contextBox.TabIndex = 0;
            this.contextBox.Text = "";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 276);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 335);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.contextBox);
            this.Name = "MainForm";
            this.Text = "Word Table Writer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox contextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

