namespace Transorm_Color_Image_In_Gray
{
    partial class Form1
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
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.download_image = new System.Windows.Forms.Button();
            this.convert_image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInput.InitialImage = null;
            this.pictureBoxInput.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(617, 695);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutput.Location = new System.Drawing.Point(663, 13);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(617, 695);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutput.TabIndex = 1;
            this.pictureBoxOutput.TabStop = false;
            // 
            // download_image
            // 
            this.download_image.Location = new System.Drawing.Point(127, 714);
            this.download_image.Name = "download_image";
            this.download_image.Size = new System.Drawing.Size(384, 49);
            this.download_image.TabIndex = 2;
            this.download_image.Text = "Загрузить изображение";
            this.download_image.UseVisualStyleBackColor = true;
            this.download_image.Click += new System.EventHandler(this.download_image_Click);
            // 
            // convert_image
            // 
            this.convert_image.Location = new System.Drawing.Point(781, 714);
            this.convert_image.Name = "convert_image";
            this.convert_image.Size = new System.Drawing.Size(384, 49);
            this.convert_image.TabIndex = 3;
            this.convert_image.Text = "Преобразовать изображение";
            this.convert_image.UseVisualStyleBackColor = true;
            this.convert_image.Click += new System.EventHandler(this.convert_image_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1299, 776);
            this.Controls.Add(this.convert_image);
            this.Controls.Add(this.download_image);
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.pictureBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Преобразование изображения из цветного в ЧБ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.Button download_image;
        private System.Windows.Forms.Button convert_image;
    }
}

