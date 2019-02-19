namespace Taximeter.GUI
{
    partial class PickupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSHour = new System.Windows.Forms.ComboBox();
            this.cboSMin = new System.Windows.Forms.ComboBox();
            this.cboEMin = new System.Windows.Forms.ComboBox();
            this.cboEHour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter the required information:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = global::Taximeter.Properties.Resources.icons8_checked_480;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Location = new System.Drawing.Point(783, 213);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 77);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start time:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "End Time:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "Initial Speed:";
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
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(345, 213);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(200, 20);
            this.txtSpeed.TabIndex = 15;
            this.txtSpeed.Text = "0";
            this.txtSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpeed_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(339, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hour:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(409, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Minutes:";
            // 
            // cboSHour
            // 
            this.cboSHour.AllowDrop = true;
            this.cboSHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSHour.FormattingEnabled = true;
            this.cboSHour.Location = new System.Drawing.Point(345, 127);
            this.cboSHour.Name = "cboSHour";
            this.cboSHour.Size = new System.Drawing.Size(58, 21);
            this.cboSHour.TabIndex = 20;
            // 
            // cboSMin
            // 
            this.cboSMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSMin.FormattingEnabled = true;
            this.cboSMin.Location = new System.Drawing.Point(415, 127);
            this.cboSMin.Name = "cboSMin";
            this.cboSMin.Size = new System.Drawing.Size(58, 21);
            this.cboSMin.TabIndex = 21;
            // 
            // cboEMin
            // 
            this.cboEMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEMin.FormattingEnabled = true;
            this.cboEMin.Location = new System.Drawing.Point(415, 170);
            this.cboEMin.Name = "cboEMin";
            this.cboEMin.Size = new System.Drawing.Size(58, 21);
            this.cboEMin.TabIndex = 23;
            // 
            // cboEHour
            // 
            this.cboEHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEHour.FormattingEnabled = true;
            this.cboEHour.Location = new System.Drawing.Point(345, 170);
            this.cboEHour.Name = "cboEHour";
            this.cboEHour.Size = new System.Drawing.Size(58, 21);
            this.cboEHour.TabIndex = 22;
            // 
            // PickupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taximeter.Properties.Resources.North_American_taximeter__cropped_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 375);
            this.Controls.Add(this.cboEMin);
            this.Controls.Add(this.cboEHour);
            this.Controls.Add(this.cboSMin);
            this.Controls.Add(this.cboSHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PickupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.PickupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSHour;
        private System.Windows.Forms.ComboBox cboSMin;
        private System.Windows.Forms.ComboBox cboEMin;
        private System.Windows.Forms.ComboBox cboEHour;
    }
}