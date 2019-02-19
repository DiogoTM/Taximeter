namespace Taximeter.GUI
{
    partial class FillTankForm
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFuelCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBalance.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Lime;
            this.lblBalance.Location = new System.Drawing.Point(125, 243);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(253, 43);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = global::Taximeter.Properties.Resources.icons8_checked_480;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Location = new System.Drawing.Point(786, 216);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 77);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(473, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 43);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please enter fuel amount:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fuel Total Cost:";
            // 
            // lblFuelCost
            // 
            this.lblFuelCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFuelCost.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelCost.ForeColor = System.Drawing.Color.Lime;
            this.lblFuelCost.Location = new System.Drawing.Point(125, 149);
            this.lblFuelCost.Name = "lblFuelCost";
            this.lblFuelCost.Size = new System.Drawing.Size(253, 43);
            this.lblFuelCost.TabIndex = 11;
            this.lblFuelCost.Text = "Fuel Cost";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 43);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fuel Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrice.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Lime;
            this.lblPrice.Location = new System.Drawing.Point(125, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(253, 43);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Fuel Price";
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
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(482, 129);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(306, 20);
            this.txtAmount.TabIndex = 16;
            this.txtAmount.Text = "0";
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // FillTankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taximeter.Properties.Resources.North_American_taximeter__cropped_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 375);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFuelCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBalance);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FillTankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FillTankForm";
            this.Load += new System.EventHandler(this.FillTankForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFuelCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAmount;
    }
}