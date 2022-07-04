namespace vacsan
{
    partial class Form3
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblcountry = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.nudcount = new System.Windows.Forms.NumericUpDown();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudcount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(99, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Vacsine name :";
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Location = new System.Drawing.Point(12, 81);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(92, 16);
            this.lblcountry.TabIndex = 1;
            this.lblcountry.Text = "prodused by : ";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(12, 120);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(83, 16);
            this.lblcount.TabIndex = 2;
            this.lblcount.Text = "Does Count :";
            // 
            // txtcountry
            // 
            this.txtcountry.Location = new System.Drawing.Point(117, 75);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(100, 22);
            this.txtcountry.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(117, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 5;
            // 
            // nudcount
            // 
            this.nudcount.Location = new System.Drawing.Point(117, 118);
            this.nudcount.Name = "nudcount";
            this.nudcount.Size = new System.Drawing.Size(48, 22);
            this.nudcount.TabIndex = 6;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(20, 176);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(173, 176);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 224);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.nudcount);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblcountry);
            this.Controls.Add(this.lblname);
            this.Name = "Form3";
            this.Text = "اطلاعات واکسن";
            ((System.ComponentModel.ISupportInitialize)(this.nudcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.NumericUpDown nudcount;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnexit;
    }
}