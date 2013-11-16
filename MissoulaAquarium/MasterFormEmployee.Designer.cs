namespace MissoulaAquarium
{
    partial class MasterFormEmployee
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
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.scheduleListBox = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.eventsSignedListBox = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.eventsAvaillbl = new System.Windows.Forms.Label();
            this.eventsAvailListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelTourBtn = new System.Windows.Forms.Button();
            this.signTourBtn = new System.Windows.Forms.Button();
            this.toursSignedListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availToursListBox = new System.Windows.Forms.ListBox();
            this.tabLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tabPage2);
            this.tabLogin.Controls.Add(this.tabPage3);
            this.tabLogin.Controls.Add(this.tabPage7);
            this.tabLogin.Location = new System.Drawing.Point(1, 0);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(1057, 742);
            this.tabLogin.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cancelTourBtn);
            this.tabPage2.Controls.Add(this.signTourBtn);
            this.tabPage2.Controls.Add(this.toursSignedListBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.availToursListBox);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1049, 716);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tours Schedule";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(82, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(911, 74);
            this.label17.TabIndex = 40;
            this.label17.Text = "Tour Sign-Up";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Controls.Add(this.scheduleListBox);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1049, 716);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(323, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(0, 0);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // scheduleListBox
            // 
            this.scheduleListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25});
            this.scheduleListBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleListBox.HoverSelection = true;
            this.scheduleListBox.Location = new System.Drawing.Point(4, 195);
            this.scheduleListBox.Margin = new System.Windows.Forms.Padding(4);
            this.scheduleListBox.Name = "scheduleListBox";
            this.scheduleListBox.Size = new System.Drawing.Size(1041, 276);
            this.scheduleListBox.TabIndex = 40;
            this.scheduleListBox.UseCompatibleStateImageBehavior = false;
            this.scheduleListBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Emp ID";
            this.columnHeader17.Width = 69;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Employee Name";
            this.columnHeader18.Width = 137;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Monday";
            this.columnHeader19.Width = 93;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Tuesday";
            this.columnHeader20.Width = 106;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Wednesday";
            this.columnHeader21.Width = 117;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Thursday";
            this.columnHeader22.Width = 146;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Friday";
            this.columnHeader23.Width = 123;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Saturday";
            this.columnHeader24.Width = 145;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Sunday";
            this.columnHeader25.Width = 127;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(158, 66);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(764, 74);
            this.label16.TabIndex = 38;
            this.label16.Text = "Employee Schedule";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label10);
            this.tabPage7.Controls.Add(this.pictureBox1);
            this.tabPage7.Controls.Add(this.label9);
            this.tabPage7.Controls.Add(this.cancelBtn);
            this.tabPage7.Controls.Add(this.signupBtn);
            this.tabPage7.Controls.Add(this.eventsSignedListBox);
            this.tabPage7.Controls.Add(this.label18);
            this.tabPage7.Controls.Add(this.eventsAvaillbl);
            this.tabPage7.Controls.Add(this.eventsAvailListBox);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1049, 716);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "View/Sign-up Events";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(349, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Number    Event Name              Date                       Time            Loca" +
    "tion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MissoulaAquarium.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 704);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(513, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 45);
            this.label9.TabIndex = 6;
            this.label9.Text = "Event Management";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(508, 577);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(326, 30);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel Event";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.Location = new System.Drawing.Point(508, 292);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(326, 30);
            this.signupBtn.TabIndex = 4;
            this.signupBtn.Text = "Sign Up For Event";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // eventsSignedListBox
            // 
            this.eventsSignedListBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsSignedListBox.FormattingEnabled = true;
            this.eventsSignedListBox.ItemHeight = 14;
            this.eventsSignedListBox.Location = new System.Drawing.Point(408, 411);
            this.eventsSignedListBox.Name = "eventsSignedListBox";
            this.eventsSignedListBox.Size = new System.Drawing.Size(511, 144);
            this.eventsSignedListBox.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(578, 370);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 26);
            this.label18.TabIndex = 2;
            this.label18.Text = "Events Signed up for";
            // 
            // eventsAvaillbl
            // 
            this.eventsAvaillbl.AutoSize = true;
            this.eventsAvaillbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsAvaillbl.Location = new System.Drawing.Point(578, 59);
            this.eventsAvaillbl.Name = "eventsAvaillbl";
            this.eventsAvaillbl.Size = new System.Drawing.Size(149, 26);
            this.eventsAvaillbl.TabIndex = 1;
            this.eventsAvaillbl.Text = "Available Events";
            // 
            // eventsAvailListBox
            // 
            this.eventsAvailListBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsAvailListBox.FormattingEnabled = true;
            this.eventsAvailListBox.ItemHeight = 14;
            this.eventsAvailListBox.Location = new System.Drawing.Point(408, 125);
            this.eventsAvailListBox.Name = "eventsAvailListBox";
            this.eventsAvailListBox.Size = new System.Drawing.Size(511, 144);
            this.eventsAvailListBox.TabIndex = 0;
            this.eventsAvailListBox.SelectedIndexChanged += new System.EventHandler(this.eventsAvailListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Number    Tour Name              Guide                      Date                 " +
    "                         Location";
            // 
            // cancelTourBtn
            // 
            this.cancelTourBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelTourBtn.Location = new System.Drawing.Point(393, 595);
            this.cancelTourBtn.Name = "cancelTourBtn";
            this.cancelTourBtn.Size = new System.Drawing.Size(326, 30);
            this.cancelTourBtn.TabIndex = 46;
            this.cancelTourBtn.Text = "Cancel Tour";
            this.cancelTourBtn.UseVisualStyleBackColor = true;
            this.cancelTourBtn.Click += new System.EventHandler(this.cancelTourBtn_Click);
            // 
            // signTourBtn
            // 
            this.signTourBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signTourBtn.Location = new System.Drawing.Point(393, 310);
            this.signTourBtn.Name = "signTourBtn";
            this.signTourBtn.Size = new System.Drawing.Size(326, 30);
            this.signTourBtn.TabIndex = 45;
            this.signTourBtn.Text = "Sign Up For Tour";
            this.signTourBtn.UseVisualStyleBackColor = true;
            this.signTourBtn.Click += new System.EventHandler(this.signTourBtn_Click);
            // 
            // toursSignedListBox
            // 
            this.toursSignedListBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toursSignedListBox.FormattingEnabled = true;
            this.toursSignedListBox.ItemHeight = 14;
            this.toursSignedListBox.Location = new System.Drawing.Point(293, 429);
            this.toursSignedListBox.Name = "toursSignedListBox";
            this.toursSignedListBox.Size = new System.Drawing.Size(511, 144);
            this.toursSignedListBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tours Signed up for";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "Available Tours";
            // 
            // availToursListBox
            // 
            this.availToursListBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availToursListBox.FormattingEnabled = true;
            this.availToursListBox.ItemHeight = 14;
            this.availToursListBox.Location = new System.Drawing.Point(293, 143);
            this.availToursListBox.Name = "availToursListBox";
            this.availToursListBox.Size = new System.Drawing.Size(511, 144);
            this.availToursListBox.TabIndex = 41;
            // 
            // MasterFormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 733);
            this.Controls.Add(this.tabLogin);
            this.Name = "MasterFormEmployee";
            this.Text = "Employee Console";
            this.tabLogin.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.ListBox eventsSignedListBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label eventsAvaillbl;
        private System.Windows.Forms.ListBox eventsAvailListBox;
        public System.Windows.Forms.ListView scheduleListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelTourBtn;
        private System.Windows.Forms.Button signTourBtn;
        private System.Windows.Forms.ListBox toursSignedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox availToursListBox;
    }
}