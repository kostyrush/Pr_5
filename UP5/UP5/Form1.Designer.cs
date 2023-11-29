namespace UP5
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
            this.pct = new System.Windows.Forms.PictureBox();
            this.btc = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.imya = new System.Windows.Forms.TextBox();
            this.btcSave = new System.Windows.Forms.Button();
            this.saveFile1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(71, 31);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(401, 343);
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            // 
            // btc
            // 
            this.btc.Location = new System.Drawing.Point(71, 410);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(129, 47);
            this.btc.TabIndex = 1;
            this.btc.Text = "Загрузить рисунок";
            this.btc.UseVisualStyleBackColor = true;
            this.btc.Click += new System.EventHandler(this.btc_Click);
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            // 
            // imya
            // 
            this.imya.Location = new System.Drawing.Point(150, 380);
            this.imya.Name = "imya";
            this.imya.Size = new System.Drawing.Size(254, 20);
            this.imya.TabIndex = 2;
            // 
            // btcSave
            // 
            this.btcSave.Location = new System.Drawing.Point(343, 410);
            this.btcSave.Name = "btcSave";
            this.btcSave.Size = new System.Drawing.Size(129, 47);
            this.btcSave.TabIndex = 3;
            this.btcSave.Text = "Сохранить рисунок";
            this.btcSave.UseVisualStyleBackColor = true;
            this.btcSave.Click += new System.EventHandler(this.btcSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 469);
            this.Controls.Add(this.btcSave);
            this.Controls.Add(this.imya);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.pct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button btc;
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.TextBox imya;
        private System.Windows.Forms.Button btcSave;
        private System.Windows.Forms.SaveFileDialog saveFile1;
    }
}

