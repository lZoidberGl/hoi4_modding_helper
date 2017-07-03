namespace HOI4_Modding_Helper
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
            this.to_GFX = new System.Windows.Forms.Button();
            this.to_EasyIdeology = new System.Windows.Forms.Button();
            this.to_hz_helper = new System.Windows.Forms.Button();
            this.to_ISO_helper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // to_GFX
            // 
            this.to_GFX.Dock = System.Windows.Forms.DockStyle.Top;
            this.to_GFX.Location = new System.Drawing.Point(0, 0);
            this.to_GFX.Name = "to_GFX";
            this.to_GFX.Size = new System.Drawing.Size(297, 50);
            this.to_GFX.TabIndex = 0;
            this.to_GFX.Text = "Помошник GFX";
            this.to_GFX.UseVisualStyleBackColor = true;
            this.to_GFX.Click += new System.EventHandler(this.to_GFX_Click);
            // 
            // to_EasyIdeology
            // 
            this.to_EasyIdeology.Dock = System.Windows.Forms.DockStyle.Top;
            this.to_EasyIdeology.Location = new System.Drawing.Point(0, 50);
            this.to_EasyIdeology.Name = "to_EasyIdeology";
            this.to_EasyIdeology.Size = new System.Drawing.Size(297, 50);
            this.to_EasyIdeology.TabIndex = 1;
            this.to_EasyIdeology.Text = "Помошник по фокусам";
            this.to_EasyIdeology.UseVisualStyleBackColor = true;
            this.to_EasyIdeology.Click += new System.EventHandler(this.toEasyFocus_Click);
            // 
            // to_hz_helper
            // 
            this.to_hz_helper.Dock = System.Windows.Forms.DockStyle.Top;
            this.to_hz_helper.Location = new System.Drawing.Point(0, 100);
            this.to_hz_helper.Name = "to_hz_helper";
            this.to_hz_helper.Size = new System.Drawing.Size(297, 50);
            this.to_hz_helper.TabIndex = 2;
            this.to_hz_helper.Text = "Помошник с территорияим";
            this.to_hz_helper.UseVisualStyleBackColor = true;
            this.to_hz_helper.Click += new System.EventHandler(this.to_state_helper_Click);
            // 
            // to_ISO_helper
            // 
            this.to_ISO_helper.Dock = System.Windows.Forms.DockStyle.Top;
            this.to_ISO_helper.Location = new System.Drawing.Point(0, 150);
            this.to_ISO_helper.Name = "to_ISO_helper";
            this.to_ISO_helper.Size = new System.Drawing.Size(297, 50);
            this.to_ISO_helper.TabIndex = 3;
            this.to_ISO_helper.Text = "Помошник с ISO id";
            this.to_ISO_helper.UseVisualStyleBackColor = true;
            this.to_ISO_helper.Click += new System.EventHandler(this.to_ISO_Helper_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 311);
            this.Controls.Add(this.to_ISO_helper);
            this.Controls.Add(this.to_hz_helper);
            this.Controls.Add(this.to_EasyIdeology);
            this.Controls.Add(this.to_GFX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button to_GFX;
        private System.Windows.Forms.Button to_EasyIdeology;
        private System.Windows.Forms.Button to_hz_helper;
        private System.Windows.Forms.Button to_ISO_helper;
    }
}

