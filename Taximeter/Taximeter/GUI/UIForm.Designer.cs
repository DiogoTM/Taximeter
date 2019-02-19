namespace Taximeter.GUI
{
    partial class UIForm
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
            this.lblGas = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.btnFillUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGas
            // 
            this.lblGas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGas.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGas.ForeColor = System.Drawing.Color.Lime;
            this.lblGas.Location = new System.Drawing.Point(143, 227);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(201, 50);
            this.lblGas.TabIndex = 0;
            this.lblGas.Text = "Gas Level";
            // 
            // lblMileage
            // 
            this.lblMileage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMileage.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileage.ForeColor = System.Drawing.Color.Lime;
            this.lblMileage.Location = new System.Drawing.Point(360, 134);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(201, 50);
            this.lblMileage.TabIndex = 1;
            this.lblMileage.Text = "Mileage";
            // 
            // lblIncome
            // 
            this.lblIncome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIncome.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.Lime;
            this.lblIncome.Location = new System.Drawing.Point(360, 227);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(201, 50);
            this.lblIncome.TabIndex = 2;
            this.lblIncome.Text = "Net Income";
            // 
            // lblTrip
            // 
            this.lblTrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTrip.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.ForeColor = System.Drawing.Color.Lime;
            this.lblTrip.Location = new System.Drawing.Point(143, 134);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(201, 50);
            this.lblTrip.TabIndex = 3;
            this.lblTrip.Text = "Nbr Trips ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trips:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gas Level:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(360, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mileage:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(360, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "Net Income:";
            // 
            // btnPickUp
            // 
            this.btnPickUp.BackColor = System.Drawing.Color.Transparent;
            this.btnPickUp.BackgroundImage = global::Taximeter.Properties.Resources.icons8_add_user_male_100;
            this.btnPickUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPickUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickUp.Location = new System.Drawing.Point(789, 117);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(59, 59);
            this.btnPickUp.TabIndex = 8;
            this.btnPickUp.UseVisualStyleBackColor = false;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // btnFillUp
            // 
            this.btnFillUp.BackColor = System.Drawing.Color.Transparent;
            this.btnFillUp.BackgroundImage = global::Taximeter.Properties.Resources.icons8_gas_pump_80;
            this.btnFillUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFillUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillUp.Location = new System.Drawing.Point(789, 203);
            this.btnFillUp.Name = "btnFillUp";
            this.btnFillUp.Size = new System.Drawing.Size(59, 59);
            this.btnFillUp.TabIndex = 9;
            this.btnFillUp.UseVisualStyleBackColor = false;
            this.btnFillUp.Click += new System.EventHandler(this.btnFillUp_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(564, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 43);
            this.label5.TabIndex = 10;
            this.label5.Text = "New Passenger:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(564, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 43);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fill up Gas Tank:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Taximeter.Properties.Resources.icons8_close_window_80;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(833, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 43);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfo.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(134, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(649, 67);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "Taxi Info";
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taximeter.Properties.Resources.North_American_taximeter__cropped_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 375);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFillUp);
            this.Controls.Add(this.btnPickUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblGas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIForm";
            this.Load += new System.EventHandler(this.UIForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.Button btnFillUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInfo;
    }
}