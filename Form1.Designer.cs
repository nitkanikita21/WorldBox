namespace WorldBox
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
            this.map = new System.Windows.Forms.PictureBox();
            this.btn_generateRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.Black;
            this.map.Location = new System.Drawing.Point(6, 6);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(438, 438);
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // btn_generateRun
            // 
            this.btn_generateRun.Location = new System.Drawing.Point(450, 6);
            this.btn_generateRun.Name = "btn_generateRun";
            this.btn_generateRun.Size = new System.Drawing.Size(344, 23);
            this.btn_generateRun.TabIndex = 1;
            this.btn_generateRun.Text = "Generate";
            this.btn_generateRun.UseVisualStyleBackColor = true;
            this.btn_generateRun.Click += new System.EventHandler(this.btn_generateRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_generateRun);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Button btn_generateRun;
    }
}

