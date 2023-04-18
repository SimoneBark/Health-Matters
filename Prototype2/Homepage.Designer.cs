
namespace Prototype2
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.btnHealthTracking = new System.Windows.Forms.Button();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnForecast = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRisk = new System.Windows.Forms.Button();
            this.btnEHA = new System.Windows.Forms.Button();
            this.btnECAS = new System.Windows.Forms.Button();
            this.btnAirQuality = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.btnSupport);
            this.panel1.Controls.Add(this.btnHealthTracking);
            this.panel1.Controls.Add(this.btnTemperature);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(12, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 50);
            this.btnHome.TabIndex = 12;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.BackgroundImage")));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Location = new System.Drawing.Point(481, 20);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(54, 50);
            this.btnAccount.TabIndex = 11;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptions.Location = new System.Drawing.Point(391, 34);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(81, 36);
            this.btnOptions.TabIndex = 10;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupport.Location = new System.Drawing.Point(285, 34);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(81, 36);
            this.btnSupport.TabIndex = 9;
            this.btnSupport.Text = "Support";
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // btnHealthTracking
            // 
            this.btnHealthTracking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHealthTracking.Location = new System.Drawing.Point(181, 34);
            this.btnHealthTracking.Name = "btnHealthTracking";
            this.btnHealthTracking.Size = new System.Drawing.Size(81, 36);
            this.btnHealthTracking.TabIndex = 8;
            this.btnHealthTracking.Text = "Health Tracking";
            this.btnHealthTracking.UseVisualStyleBackColor = true;
            this.btnHealthTracking.Click += new System.EventHandler(this.btnHealthTracking_Click);
            // 
            // btnTemperature
            // 
            this.btnTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemperature.Location = new System.Drawing.Point(76, 34);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(81, 36);
            this.btnTemperature.TabIndex = 7;
            this.btnTemperature.Text = "Temperature Advice";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnGetWeather);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 348);
            this.panel2.TabIndex = 1;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(87, 52);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(104, 25);
            this.btnGetWeather.TabIndex = 15;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Season";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Temperature:   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Health Information and Weather warning";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.btnForecast);
            this.panel3.Location = new System.Drawing.Point(215, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 254);
            this.panel3.TabIndex = 2;
            // 
            // btnForecast
            // 
            this.btnForecast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForecast.Location = new System.Drawing.Point(170, 226);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(147, 25);
            this.btnForecast.TabIndex = 13;
            this.btnForecast.Text = "Weekly Forecast";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(106, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Todays Forecast";
            // 
            // btnRisk
            // 
            this.btnRisk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRisk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRisk.Location = new System.Drawing.Point(332, 556);
            this.btnRisk.Name = "btnRisk";
            this.btnRisk.Size = new System.Drawing.Size(110, 69);
            this.btnRisk.TabIndex = 7;
            this.btnRisk.Text = "Risk Assesments";
            this.btnRisk.UseVisualStyleBackColor = false;
            this.btnRisk.Click += new System.EventHandler(this.btnRisk_Click);
            // 
            // btnEHA
            // 
            this.btnEHA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEHA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEHA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEHA.Location = new System.Drawing.Point(100, 556);
            this.btnEHA.Name = "btnEHA";
            this.btnEHA.Size = new System.Drawing.Size(110, 69);
            this.btnEHA.TabIndex = 8;
            this.btnEHA.Text = "Environmental Health Advice";
            this.btnEHA.UseVisualStyleBackColor = false;
            this.btnEHA.Click += new System.EventHandler(this.btnEHA_Click);
            // 
            // btnECAS
            // 
            this.btnECAS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnECAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnECAS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnECAS.Location = new System.Drawing.Point(100, 664);
            this.btnECAS.Name = "btnECAS";
            this.btnECAS.Size = new System.Drawing.Size(110, 69);
            this.btnECAS.TabIndex = 9;
            this.btnECAS.Text = "Enviornmental Conditions & Support";
            this.btnECAS.UseVisualStyleBackColor = false;
            this.btnECAS.Click += new System.EventHandler(this.btnECAS_Click);
            // 
            // btnAirQuality
            // 
            this.btnAirQuality.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAirQuality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAirQuality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAirQuality.Location = new System.Drawing.Point(332, 664);
            this.btnAirQuality.Name = "btnAirQuality";
            this.btnAirQuality.Size = new System.Drawing.Size(110, 69);
            this.btnAirQuality.TabIndex = 10;
            this.btnAirQuality.Text = "Air Quality & Pollution";
            this.btnAirQuality.UseVisualStyleBackColor = false;
            this.btnAirQuality.Click += new System.EventHandler(this.btnAirQuality_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(495, 713);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(37, 36);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Health Advice Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 114);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(544, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAirQuality);
            this.Controls.Add(this.btnECAS);
            this.Controls.Add(this.btnEHA);
            this.Controls.Add(this.btnRisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Button btnHealthTracking;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRisk;
        private System.Windows.Forms.Button btnEHA;
        private System.Windows.Forms.Button btnECAS;
        private System.Windows.Forms.Button btnAirQuality;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}