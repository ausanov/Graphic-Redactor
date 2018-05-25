namespace graphic_redactor
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadImage = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.frame = new System.Windows.Forms.Button();
            this.property = new System.Windows.Forms.Button();
            this.inversion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Sync = new System.Windows.Forms.Button();
            this.canalGreen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioBW = new System.Windows.Forms.RadioButton();
            this.radioRW = new System.Windows.Forms.RadioButton();
            this.radioBG = new System.Windows.Forms.RadioButton();
            this.radioBY = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.callBackImage = new System.Windows.Forms.Button();
            this.Histogramm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.blur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarBlur = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.emboss = new System.Windows.Forms.Button();
            this.blurGauss = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.borderline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadImage
            // 
            this.loadImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadImage.Location = new System.Drawing.Point(12, 364);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(305, 54);
            this.loadImage.TabIndex = 1;
            this.loadImage.Text = "Загрузить изображение";
            this.loadImage.UseVisualStyleBackColor = false;
            this.loadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveImage.Location = new System.Drawing.Point(339, 364);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(305, 54);
            this.saveImage.TabIndex = 2;
            this.saveImage.Text = "Сохранить изображение";
            this.saveImage.UseVisualStyleBackColor = false;
            this.saveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.frame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.frame.Location = new System.Drawing.Point(669, 54);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(376, 36);
            this.frame.TabIndex = 3;
            this.frame.Text = "Добавить рамку";
            this.frame.UseVisualStyleBackColor = false;
            this.frame.Click += new System.EventHandler(this.Frame_Click);
            // 
            // property
            // 
            this.property.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.property.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.property.Location = new System.Drawing.Point(669, 12);
            this.property.Name = "property";
            this.property.Size = new System.Drawing.Size(376, 36);
            this.property.TabIndex = 6;
            this.property.Text = "Считать данные";
            this.property.UseVisualStyleBackColor = false;
            this.property.Click += new System.EventHandler(this.Property_Click);
            // 
            // inversion
            // 
            this.inversion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inversion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inversion.Location = new System.Drawing.Point(669, 96);
            this.inversion.Name = "inversion";
            this.inversion.Size = new System.Drawing.Size(376, 36);
            this.inversion.TabIndex = 7;
            this.inversion.Text = "Инверсия изображения";
            this.inversion.UseVisualStyleBackColor = false;
            this.inversion.Click += new System.EventHandler(this.Inversion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(669, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Поканальное изменение яркости (красный оттенок)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CanalRed_Click);
            // 
            // Sync
            // 
            this.Sync.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sync.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sync.Location = new System.Drawing.Point(669, 263);
            this.Sync.Name = "Sync";
            this.Sync.Size = new System.Drawing.Size(376, 36);
            this.Sync.TabIndex = 9;
            this.Sync.Text = "Синхронное изменение яркости";
            this.Sync.UseVisualStyleBackColor = false;
            this.Sync.Click += new System.EventHandler(this.Sync_Click);
            // 
            // canalGreen
            // 
            this.canalGreen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.canalGreen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.canalGreen.Location = new System.Drawing.Point(669, 180);
            this.canalGreen.Name = "canalGreen";
            this.canalGreen.Size = new System.Drawing.Size(376, 36);
            this.canalGreen.TabIndex = 10;
            this.canalGreen.Text = "Поканальное изменение яркости (зеленый оттенок)";
            this.canalGreen.UseVisualStyleBackColor = false;
            this.canalGreen.Click += new System.EventHandler(this.CanalGreen_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(669, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Поканальное изменение яркости (синий оттенок)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CanalBlue_Click);
            // 
            // radioBW
            // 
            this.radioBW.AutoSize = true;
            this.radioBW.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBW.Location = new System.Drawing.Point(7, 102);
            this.radioBW.Name = "radioBW";
            this.radioBW.Size = new System.Drawing.Size(128, 22);
            this.radioBW.TabIndex = 13;
            this.radioBW.TabStop = true;
            this.radioBW.Text = "черно-белое";
            this.radioBW.UseVisualStyleBackColor = true;
            this.radioBW.CheckedChanged += new System.EventHandler(this.RadioBW_CheckedChanged);
            // 
            // radioRW
            // 
            this.radioRW.AutoSize = true;
            this.radioRW.ForeColor = System.Drawing.SystemColors.Control;
            this.radioRW.Location = new System.Drawing.Point(7, 75);
            this.radioRW.Name = "radioRW";
            this.radioRW.Size = new System.Drawing.Size(136, 22);
            this.radioRW.TabIndex = 14;
            this.radioRW.TabStop = true;
            this.radioRW.Text = "красно-белое";
            this.radioRW.UseVisualStyleBackColor = true;
            this.radioRW.CheckedChanged += new System.EventHandler(this.RadioRW_CheckedChanged);
            // 
            // radioBG
            // 
            this.radioBG.AutoSize = true;
            this.radioBG.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBG.Location = new System.Drawing.Point(7, 21);
            this.radioBG.Name = "radioBG";
            this.radioBG.Size = new System.Drawing.Size(145, 22);
            this.radioBG.TabIndex = 15;
            this.radioBG.Text = "черно-зеленое";
            this.radioBG.UseVisualStyleBackColor = true;
            this.radioBG.CheckedChanged += new System.EventHandler(this.RadioBG_CheckedChanged);
            // 
            // radioBY
            // 
            this.radioBY.AutoSize = true;
            this.radioBY.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBY.Location = new System.Drawing.Point(7, 48);
            this.radioBY.Name = "radioBY";
            this.radioBY.Size = new System.Drawing.Size(128, 22);
            this.radioBY.TabIndex = 16;
            this.radioBY.TabStop = true;
            this.radioBY.Text = "сине-желтое";
            this.radioBY.UseVisualStyleBackColor = true;
            this.radioBY.CheckedChanged += new System.EventHandler(this.RadioBY_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.radioBG);
            this.groupBox1.Controls.Add(this.radioBW);
            this.groupBox1.Controls.Add(this.radioRW);
            this.groupBox1.Controls.Add(this.radioBY);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(669, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 133);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Полутоновое преобразование";
            // 
            // callBackImage
            // 
            this.callBackImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.callBackImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callBackImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.callBackImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.callBackImage.Location = new System.Drawing.Point(12, 428);
            this.callBackImage.Name = "callBackImage";
            this.callBackImage.Size = new System.Drawing.Size(305, 53);
            this.callBackImage.TabIndex = 19;
            this.callBackImage.Text = "Вернуть исходное изображение";
            this.callBackImage.UseVisualStyleBackColor = false;
            this.callBackImage.Click += new System.EventHandler(this.CallBackImage_Click);
            // 
            // Histogramm
            // 
            this.Histogramm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Histogramm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Histogramm.Location = new System.Drawing.Point(1051, 353);
            this.Histogramm.Name = "Histogramm";
            this.Histogramm.Size = new System.Drawing.Size(488, 36);
            this.Histogramm.TabIndex = 17;
            this.Histogramm.Text = "Гистограмма";
            this.Histogramm.UseVisualStyleBackColor = false;
            this.Histogramm.Click += new System.EventHandler(this.Histogramm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(1051, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(488, 335);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // blur
            // 
            this.blur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.blur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blur.Location = new System.Drawing.Point(1051, 395);
            this.blur.Name = "blur";
            this.blur.Size = new System.Drawing.Size(488, 36);
            this.blur.TabIndex = 21;
            this.blur.Text = "Усредненный фильтр размытия";
            this.blur.UseVisualStyleBackColor = false;
            this.blur.Click += new System.EventHandler(this.Blur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1048, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Величина размытия";
            // 
            // trackBarBlur
            // 
            this.trackBarBlur.Location = new System.Drawing.Point(1215, 437);
            this.trackBarBlur.Name = "trackBarBlur";
            this.trackBarBlur.Size = new System.Drawing.Size(324, 56);
            this.trackBarBlur.TabIndex = 7;
            this.trackBarBlur.Value = 1;
            this.trackBarBlur.Scroll += new System.EventHandler(this.UpdateBlur);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1048, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Яркость";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.LargeChange = 10;
            this.trackBarBrightness.Location = new System.Drawing.Point(1215, 476);
            this.trackBarBrightness.Maximum = 600;
            this.trackBarBrightness.Minimum = 20;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(293, 56);
            this.trackBarBrightness.SmallChange = 10;
            this.trackBarBrightness.TabIndex = 7;
            this.trackBarBrightness.TickFrequency = 20;
            this.trackBarBrightness.Value = 20;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.TrackBarBrightness_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1514, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1048, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Контрастность №1";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.LargeChange = 99;
            this.trackBarContrast.Location = new System.Drawing.Point(1215, 514);
            this.trackBarContrast.Maximum = 99;
            this.trackBarContrast.Minimum = 5;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(293, 56);
            this.trackBarContrast.SmallChange = 5;
            this.trackBarContrast.TabIndex = 7;
            this.trackBarContrast.TickFrequency = 10;
            this.trackBarContrast.Value = 5;
            this.trackBarContrast.Scroll += new System.EventHandler(this.TrackBarContrast_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1514, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "0";
            // 
            // emboss
            // 
            this.emboss.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emboss.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emboss.Location = new System.Drawing.Point(669, 446);
            this.emboss.Name = "emboss";
            this.emboss.Size = new System.Drawing.Size(376, 47);
            this.emboss.TabIndex = 28;
            this.emboss.Text = "Высокочастотный фильтр подчеркивания границ";
            this.emboss.UseVisualStyleBackColor = false;
            this.emboss.Click += new System.EventHandler(this.Emboss_Click);
            // 
            // blurGauss
            // 
            this.blurGauss.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.blurGauss.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blurGauss.Location = new System.Drawing.Point(669, 496);
            this.blurGauss.Name = "blurGauss";
            this.blurGauss.Size = new System.Drawing.Size(376, 36);
            this.blurGauss.TabIndex = 29;
            this.blurGauss.Text = "Однородный линейный фильтр размытия";
            this.blurGauss.UseVisualStyleBackColor = false;
            this.blurGauss.Click += new System.EventHandler(this.BlurGauss_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1048, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Контрастность №2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1514, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(1215, 553);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(293, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBarContrast2Scroll);
            // 
            // borderline
            // 
            this.borderline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.borderline.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.borderline.Location = new System.Drawing.Point(669, 538);
            this.borderline.Name = "borderline";
            this.borderline.Size = new System.Drawing.Size(376, 36);
            this.borderline.TabIndex = 33;
            this.borderline.Text = "Подчеркивание границ";
            this.borderline.UseVisualStyleBackColor = false;
            this.borderline.Click += new System.EventHandler(this.Borderline_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1601, 613);
            this.Controls.Add(this.borderline);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.blurGauss);
            this.Controls.Add(this.emboss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarBlur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Histogramm);
            this.Controls.Add(this.callBackImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.canalGreen);
            this.Controls.Add(this.Sync);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inversion);
            this.Controls.Add(this.property);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button frame;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button property;
        private System.Windows.Forms.Button inversion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Sync;
        private System.Windows.Forms.Button canalGreen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioBW;
        private System.Windows.Forms.RadioButton radioRW;
        private System.Windows.Forms.RadioButton radioBG;
        private System.Windows.Forms.RadioButton radioBY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button callBackImage;
        private System.Windows.Forms.Button Histogramm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button blur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarBlur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button emboss;
        private System.Windows.Forms.Button blurGauss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button borderline;
    }
}

