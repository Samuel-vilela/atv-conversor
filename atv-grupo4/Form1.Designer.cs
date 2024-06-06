namespace atv_grupo4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.textBoxFahrenheit = new System.Windows.Forms.TextBox();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.BackColor = System.Drawing.Color.Salmon;
            this.textBoxCelsius.Location = new System.Drawing.Point(12, 77);
            this.textBoxCelsius.Multiline = true;
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(166, 46);
            this.textBoxCelsius.TabIndex = 0;
            // 
            // textBoxFahrenheit
            // 
            this.textBoxFahrenheit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxFahrenheit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFahrenheit.Location = new System.Drawing.Point(12, 166);
            this.textBoxFahrenheit.Multiline = true;
            this.textBoxFahrenheit.Name = "textBoxFahrenheit";
            this.textBoxFahrenheit.ReadOnly = true;
            this.textBoxFahrenheit.Size = new System.Drawing.Size(166, 46);
            this.textBoxFahrenheit.TabIndex = 1;
            // 
            // btn_Converter
            // 
            this.btn_Converter.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Converter.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Converter.FlatAppearance.BorderSize = 10;
            this.btn_Converter.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Converter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Converter.Location = new System.Drawing.Point(12, 239);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(157, 36);
            this.btn_Converter.TabIndex = 2;
            this.btn_Converter.Text = "Converter";
            this.btn_Converter.UseVisualStyleBackColor = false;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celsius :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fahrenheit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Conversor de temperatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(190, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Converter);
            this.Controls.Add(this.textBoxFahrenheit);
            this.Controls.Add(this.textBoxCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.TextBox textBoxFahrenheit;
        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

