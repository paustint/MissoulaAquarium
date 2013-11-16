namespace MissoulaAquarium
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.empNameTxtBox = new System.Windows.Forms.TextBox();
            this.loginEmp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.custPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.custNameTxtBox = new System.Windows.Forms.TextBox();
            this.loginCust = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 704);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Employee ID";
            // 
            // empPasswordTxtBox
            // 
            this.empPasswordTxtBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPasswordTxtBox.Location = new System.Drawing.Point(344, 382);
            this.empPasswordTxtBox.Name = "empPasswordTxtBox";
            this.empPasswordTxtBox.Size = new System.Drawing.Size(221, 21);
            this.empPasswordTxtBox.TabIndex = 8;
            this.empPasswordTxtBox.Text = "j1234";
            this.empPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // empNameTxtBox
            // 
            this.empNameTxtBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameTxtBox.Location = new System.Drawing.Point(344, 332);
            this.empNameTxtBox.Name = "empNameTxtBox";
            this.empNameTxtBox.Size = new System.Drawing.Size(221, 21);
            this.empNameTxtBox.TabIndex = 7;
            this.empNameTxtBox.Text = "79002";
            // 
            // loginEmp
            // 
            this.loginEmp.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmp.Location = new System.Drawing.Point(344, 426);
            this.loginEmp.Name = "loginEmp";
            this.loginEmp.Size = new System.Drawing.Size(221, 39);
            this.loginEmp.TabIndex = 6;
            this.loginEmp.Text = "Login";
            this.loginEmp.UseVisualStyleBackColor = true;
            this.loginEmp.Click += new System.EventHandler(this.login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Employee Login";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(344, 465);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(546, 39);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Customer Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(739, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(736, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter User Name";
            // 
            // custPasswordTxtBox
            // 
            this.custPasswordTxtBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPasswordTxtBox.Location = new System.Drawing.Point(669, 382);
            this.custPasswordTxtBox.Name = "custPasswordTxtBox";
            this.custPasswordTxtBox.Size = new System.Drawing.Size(221, 21);
            this.custPasswordTxtBox.TabIndex = 15;
            this.custPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // custNameTxtBox
            // 
            this.custNameTxtBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameTxtBox.Location = new System.Drawing.Point(669, 332);
            this.custNameTxtBox.Name = "custNameTxtBox";
            this.custNameTxtBox.Size = new System.Drawing.Size(221, 21);
            this.custNameTxtBox.TabIndex = 14;
            // 
            // loginCust
            // 
            this.loginCust.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginCust.Location = new System.Drawing.Point(669, 426);
            this.loginCust.Name = "loginCust";
            this.loginCust.Size = new System.Drawing.Size(221, 39);
            this.loginCust.TabIndex = 13;
            this.loginCust.Text = "Login";
            this.loginCust.UseVisualStyleBackColor = true;
            this.loginCust.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 91);
            this.label7.TabIndex = 19;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 703);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.custPasswordTxtBox);
            this.Controls.Add(this.custNameTxtBox);
            this.Controls.Add(this.loginCust);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empPasswordTxtBox);
            this.Controls.Add(this.empNameTxtBox);
            this.Controls.Add(this.loginEmp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aquarium Employee Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empPasswordTxtBox;
        private System.Windows.Forms.TextBox empNameTxtBox;
        private System.Windows.Forms.Button loginEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox custPasswordTxtBox;
        private System.Windows.Forms.TextBox custNameTxtBox;
        private System.Windows.Forms.Button loginCust;
        private System.Windows.Forms.Label label7;
    }
}