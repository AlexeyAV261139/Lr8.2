namespace Lr8._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelLenght = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelPointAffiliation = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.labelPointAffiliationForRing = new System.Windows.Forms.Label();
            this.textBoxExternalRadius = new System.Windows.Forms.TextBox();
            this.labelExternalRadius = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1011, 15);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 88);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Площадь и длинна окружности";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStat_Click);
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(881, 29);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(100, 29);
            this.textBoxRadius.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Радиус круга =";
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.Location = new System.Drawing.Point(664, 99);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(164, 24);
            this.labelSquare.TabIndex = 4;
            this.labelSquare.Text = "Площадь круга = ";
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Location = new System.Drawing.Point(618, 136);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(210, 24);
            this.labelLenght.TabIndex = 5;
            this.labelLenght.Text = "Длинна окружности = ";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(689, 219);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 29);
            this.textBoxX.TabIndex = 6;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(689, 254);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 29);
            this.textBoxY.TabIndex = 7;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(659, 219);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 24);
            this.labelX.TabIndex = 8;
            this.labelX.Text = "x";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(659, 259);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(19, 24);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "y";
            // 
            // labelPointAffiliation
            // 
            this.labelPointAffiliation.AutoSize = true;
            this.labelPointAffiliation.Location = new System.Drawing.Point(828, 219);
            this.labelPointAffiliation.Name = "labelPointAffiliation";
            this.labelPointAffiliation.Size = new System.Drawing.Size(272, 24);
            this.labelPointAffiliation.TabIndex = 10;
            this.labelPointAffiliation.Text = "принадлежность точки кругу";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(638, 340);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(190, 64);
            this.button.TabIndex = 11;
            this.button.Text = "попадание точки";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelPointAffiliationForRing
            // 
            this.labelPointAffiliationForRing.AutoSize = true;
            this.labelPointAffiliationForRing.Location = new System.Drawing.Point(828, 259);
            this.labelPointAffiliationForRing.Name = "labelPointAffiliationForRing";
            this.labelPointAffiliationForRing.Size = new System.Drawing.Size(286, 24);
            this.labelPointAffiliationForRing.TabIndex = 12;
            this.labelPointAffiliationForRing.Text = "принадлежность точки кольцу";
            // 
            // textBoxExternalRadius
            // 
            this.textBoxExternalRadius.Location = new System.Drawing.Point(881, 64);
            this.textBoxExternalRadius.Name = "textBoxExternalRadius";
            this.textBoxExternalRadius.Size = new System.Drawing.Size(100, 29);
            this.textBoxExternalRadius.TabIndex = 13;
            // 
            // labelExternalRadius
            // 
            this.labelExternalRadius.AutoSize = true;
            this.labelExternalRadius.Location = new System.Drawing.Point(623, 67);
            this.labelExternalRadius.Name = "labelExternalRadius";
            this.labelExternalRadius.Size = new System.Drawing.Size(237, 24);
            this.labelExternalRadius.TabIndex = 14;
            this.labelExternalRadius.Text = "Радиуc внешнего круга =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 618);
            this.Controls.Add(this.labelExternalRadius);
            this.Controls.Add(this.textBoxExternalRadius);
            this.Controls.Add(this.labelPointAffiliationForRing);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelPointAffiliation);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelLenght);
            this.Controls.Add(this.labelSquare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSquare;
        private System.Windows.Forms.Label labelLenght;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelPointAffiliation;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelPointAffiliationForRing;
        private System.Windows.Forms.TextBox textBoxExternalRadius;
        private System.Windows.Forms.Label labelExternalRadius;
    }
}

