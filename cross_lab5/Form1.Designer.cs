namespace Lab5
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
            this.tb_interval = new System.Windows.Forms.TrackBar();
            this.label_interval = new System.Windows.Forms.Label();
            this.label_tripleClicks = new System.Windows.Forms.Label();
            this.customButton = new Lab5.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.tb_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_interval
            // 
            this.tb_interval.LargeChange = 50;
            this.tb_interval.Location = new System.Drawing.Point(128, 34);
            this.tb_interval.Maximum = 300;
            this.tb_interval.Minimum = 100;
            this.tb_interval.Name = "tb_interval";
            this.tb_interval.Size = new System.Drawing.Size(104, 45);
            this.tb_interval.SmallChange = 10;
            this.tb_interval.TabIndex = 1;
            this.tb_interval.Value = 200;
            this.tb_interval.ValueChanged += new System.EventHandler(this.tb_interval_ValueChanged);
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.Location = new System.Drawing.Point(128, 15);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(62, 13);
            this.label_interval.TabIndex = 2;
            this.label_interval.Text = "Интервал: ";
            // 
            // label_tripleClicks
            // 
            this.label_tripleClicks.AutoSize = true;
            this.label_tripleClicks.Location = new System.Drawing.Point(20, 15);
            this.label_tripleClicks.Name = "label_tripleClicks";
            this.label_tripleClicks.Size = new System.Drawing.Size(67, 13);
            this.label_tripleClicks.TabIndex = 3;
            this.label_tripleClicks.Text = "TripleClicks: ";
            // 
            // customButton
            // 
            this.customButton.Location = new System.Drawing.Point(12, 45);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(99, 57);
            this.customButton.TabIndex = 0;
            this.customButton.Text = "Трижды быстро нажмите сюда";
            this.customButton.Timing = 200;
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.TripleClick += new System.EventHandler(this.customButton_TripleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 114);
            this.Controls.Add(this.label_tripleClicks);
            this.Controls.Add(this.label_interval);
            this.Controls.Add(this.tb_interval);
            this.Controls.Add(this.customButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tb_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton customButton;
        private System.Windows.Forms.TrackBar tb_interval;
        private System.Windows.Forms.Label label_interval;
        private System.Windows.Forms.Label label_tripleClicks;
    }
}

