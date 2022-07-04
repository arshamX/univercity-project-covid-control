namespace vacsan
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblVacsin = new System.Windows.Forms.Label();
            this.lblpatient = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(103, 90);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(75, 23);
            this.btnPatient.TabIndex = 1;
            this.btnPatient.Text = "+";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(301, 177);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 33);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblVacsin
            // 
            this.lblVacsin.AutoSize = true;
            this.lblVacsin.Location = new System.Drawing.Point(222, 93);
            this.lblVacsin.Name = "lblVacsin";
            this.lblVacsin.Size = new System.Drawing.Size(75, 16);
            this.lblVacsin.TabIndex = 3;
            this.lblVacsin.Text = "add Vacsin";
            // 
            // lblpatient
            // 
            this.lblpatient.AutoSize = true;
            this.lblpatient.Location = new System.Drawing.Point(22, 93);
            this.lblpatient.Name = "lblpatient";
            this.lblpatient.Size = new System.Drawing.Size(75, 16);
            this.lblpatient.TabIndex = 4;
            this.lblpatient.Text = "add Patient";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Location = new System.Drawing.Point(194, 24);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(0, 16);
            this.lblwelcome.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 222);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.lblpatient);
            this.Controls.Add(this.lblVacsin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "پنل کاربری";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblVacsin;
        private System.Windows.Forms.Label lblpatient;
        private System.Windows.Forms.Label lblwelcome;
    }
}