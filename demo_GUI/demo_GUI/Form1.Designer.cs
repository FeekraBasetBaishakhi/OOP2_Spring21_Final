namespace demo_GUI
{
    partial class Form1
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
            this.nametb = new System.Windows.Forms.TextBox();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "user";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(156, 33);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(226, 40);
            this.nametb.TabIndex = 1;
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(156, 89);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(226, 40);
            this.usernametb.TabIndex = 3;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(11, 97);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(139, 32);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(156, 209);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(226, 40);
            this.passwordtb.TabIndex = 5;
            this.passwordtb.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(17, 209);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(133, 32);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(156, 152);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(226, 40);
            this.emailtb.TabIndex = 7;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(17, 155);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(82, 32);
            this.email.TabIndex = 6;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.label2_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.Desktop;
            this.add.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(156, 270);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(109, 51);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(412, 367);
            this.Controls.Add(this.add);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.email);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.username);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button add;
    }
}
