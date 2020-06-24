namespace Assignment
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.label1 = new System.Windows.Forms.Label();
            this.classcb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datelist = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reasont = new System.Windows.Forms.TextBox();
            this.addcheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.descript = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timelist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "Venue Booking";
            // 
            // classcb
            // 
            this.classcb.BackColor = System.Drawing.Color.Olive;
            this.classcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classcb.DropDownWidth = 400;
            this.classcb.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classcb.ForeColor = System.Drawing.Color.White;
            this.classcb.FormattingEnabled = true;
            this.classcb.Location = new System.Drawing.Point(250, 200);
            this.classcb.MaxDropDownItems = 10;
            this.classcb.Name = "classcb";
            this.classcb.Size = new System.Drawing.Size(387, 53);
            this.classcb.TabIndex = 6;
            this.classcb.SelectedIndexChanged += new System.EventHandler(this.classcb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Classroom";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(872, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 9;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1300, 700);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datelist
            // 
            this.datelist.BackColor = System.Drawing.Color.Olive;
            this.datelist.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold);
            this.datelist.ForeColor = System.Drawing.Color.White;
            this.datelist.FormattingEnabled = true;
            this.datelist.ItemHeight = 45;
            this.datelist.Location = new System.Drawing.Point(65, 303);
            this.datelist.Name = "datelist";
            this.datelist.Size = new System.Drawing.Size(355, 409);
            this.datelist.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(854, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 55);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reason";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // reasont
            // 
            this.reasont.BackColor = System.Drawing.Color.Olive;
            this.reasont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reasont.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasont.ForeColor = System.Drawing.Color.White;
            this.reasont.Location = new System.Drawing.Point(1064, 334);
            this.reasont.Name = "reasont";
            this.reasont.Size = new System.Drawing.Size(500, 52);
            this.reasont.TabIndex = 7;
            // 
            // addcheck
            // 
            this.addcheck.AutoSize = true;
            this.addcheck.BackColor = System.Drawing.Color.Transparent;
            this.addcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcheck.Location = new System.Drawing.Point(1231, 452);
            this.addcheck.Name = "addcheck";
            this.addcheck.Size = new System.Drawing.Size(18, 17);
            this.addcheck.TabIndex = 8;
            this.addcheck.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(854, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 55);
            this.label6.TabIndex = 5;
            this.label6.Text = "Additional Request";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(854, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 55);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // descript
            // 
            this.descript.BackColor = System.Drawing.Color.Olive;
            this.descript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descript.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript.ForeColor = System.Drawing.Color.White;
            this.descript.Location = new System.Drawing.Point(1064, 534);
            this.descript.Name = "descript";
            this.descript.Size = new System.Drawing.Size(500, 52);
            this.descript.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Olive;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(665, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 100);
            this.button3.TabIndex = 9;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timelist
            // 
            this.timelist.BackColor = System.Drawing.Color.Olive;
            this.timelist.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold);
            this.timelist.ForeColor = System.Drawing.Color.White;
            this.timelist.FormattingEnabled = true;
            this.timelist.ItemHeight = 45;
            this.timelist.Location = new System.Drawing.Point(455, 303);
            this.timelist.Name = "timelist";
            this.timelist.Size = new System.Drawing.Size(355, 409);
            this.timelist.TabIndex = 10;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.timelist);
            this.Controls.Add(this.datelist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addcheck);
            this.Controls.Add(this.descript);
            this.Controls.Add(this.reasont);
            this.Controls.Add(this.classcb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox datelist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reasont;
        private System.Windows.Forms.CheckBox addcheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox descript;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox timelist;
    }
}