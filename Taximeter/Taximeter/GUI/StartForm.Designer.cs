namespace Taximeter.GUI
{
    partial class StartForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnClose.TabIndex = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = global::Taximeter.Properties.Resources.icons8_checked_480;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Location = new System.Drawing.Point(786, 213);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 77);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please enter the required information:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 43);
            this.label2.TabIndex = 18;
            this.label2.Text = "Current fuel amount (in l):";
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(449, 90);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(103, 20);
            this.txtFuel.TabIndex = 19;
            this.txtFuel.Text = "0";
            this.txtFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFuel_KeyPress);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(395, 133);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(157, 20);
            this.txtFname.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(131, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 43);
            this.label3.TabIndex = 20;
            this.label3.Text = "First Name:";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(395, 176);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(157, 20);
            this.txtLname.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 43);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last Name:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taximeter.Properties.Resources.North_American_taximeter__cropped_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 375);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFuel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label4;
    }
}