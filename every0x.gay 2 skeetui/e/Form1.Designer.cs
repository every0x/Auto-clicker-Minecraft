
namespace e
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.skeetSlider1 = new SkeetUI.skeetSlider();
            this.skeetSlider2 = new SkeetUI.skeetSlider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.autoclicker = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gunaGradient2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 10);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(123, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(141, 23);
            this.logo.TabIndex = 3;
            this.logo.Text = "every0x.gay";
            this.logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // skeetSlider1
            // 
            this.skeetSlider1.BackColor = System.Drawing.Color.Transparent;
            this.skeetSlider1.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.skeetSlider1.Location = new System.Drawing.Point(17, 23);
            this.skeetSlider1.MaxValue = 20D;
            this.skeetSlider1.MinimumSize = new System.Drawing.Size(100, 40);
            this.skeetSlider1.MinValue = 0D;
            this.skeetSlider1.Name = "skeetSlider1";
            this.skeetSlider1.Size = new System.Drawing.Size(281, 40);
            this.skeetSlider1.SliderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.skeetSlider1.SliderColor = System.Drawing.Color.DarkViolet;
            this.skeetSlider1.TabIndex = 4;
            this.skeetSlider1.Title = " ";
            this.skeetSlider1.Value = 0D;
            this.skeetSlider1.Load += new System.EventHandler(this.skeetSlider1_Load);
            // 
            // skeetSlider2
            // 
            this.skeetSlider2.BackColor = System.Drawing.Color.Transparent;
            this.skeetSlider2.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.skeetSlider2.Location = new System.Drawing.Point(17, 69);
            this.skeetSlider2.MaxValue = 20D;
            this.skeetSlider2.MinimumSize = new System.Drawing.Size(100, 40);
            this.skeetSlider2.MinValue = 0D;
            this.skeetSlider2.Name = "skeetSlider2";
            this.skeetSlider2.Size = new System.Drawing.Size(282, 40);
            this.skeetSlider2.SliderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.skeetSlider2.SliderColor = System.Drawing.Color.DarkViolet;
            this.skeetSlider2.TabIndex = 5;
            this.skeetSlider2.Title = " ";
            this.skeetSlider2.Value = 0D;
            this.skeetSlider2.Load += new System.EventHandler(this.skeetSlider2_Load);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 10);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaGradient2Panel1.Controls.Add(this.label4);
            this.gunaGradient2Panel1.Controls.Add(this.label3);
            this.gunaGradient2Panel1.Controls.Add(this.gunaButton1);
            this.gunaGradient2Panel1.Controls.Add(this.autoclicker);
            this.gunaGradient2Panel1.Controls.Add(this.skeetSlider1);
            this.gunaGradient2Panel1.Controls.Add(this.skeetSlider2);
            this.gunaGradient2Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(32, 64);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(326, 160);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "MinCPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MaxCPS";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(41, 115);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(222, 25);
            this.gunaButton1.TabIndex = 8;
            this.gunaButton1.Text = "                   Toggle";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // autoclicker
            // 
            this.autoclicker.AutoSize = true;
            this.autoclicker.BackColor = System.Drawing.Color.Transparent;
            this.autoclicker.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoclicker.Location = new System.Drawing.Point(3, 0);
            this.autoclicker.Name = "autoclicker";
            this.autoclicker.Size = new System.Drawing.Size(71, 16);
            this.autoclicker.TabIndex = 7;
            this.autoclicker.Text = "Autoclicker";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(302, 275);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(83, 16);
            this.gunaButton2.TabIndex = 11;
            this.gunaButton2.Text = "Selfdestruct";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(372, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(372, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "0";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(397, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private SkeetUI.skeetSlider skeetSlider1;
        private SkeetUI.skeetSlider skeetSlider2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.Label autoclicker;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
    }
}

