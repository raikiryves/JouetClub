
namespace JouetGSB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Button();
            this.userlog = new System.Windows.Forms.TextBox();
            this.userPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JouetGSB.Properties.Resources.Icone_profil;
            this.pictureBox2.Location = new System.Drawing.Point(27, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(27, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connexion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(27, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JouetGSB.Properties.Resources.Icone_profil;
            this.pictureBox3.Location = new System.Drawing.Point(27, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(27, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 3;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Blue;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(27, 403);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(236, 33);
            this.login.TabIndex = 4;
            this.login.Text = "Se connecter";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // userlog
            // 
            this.userlog.BackColor = System.Drawing.SystemColors.Control;
            this.userlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userlog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userlog.Location = new System.Drawing.Point(58, 244);
            this.userlog.Multiline = true;
            this.userlog.Name = "userlog";
            this.userlog.Size = new System.Drawing.Size(191, 24);
            this.userlog.TabIndex = 5;
            // 
            // userPass
            // 
            this.userPass.BackColor = System.Drawing.SystemColors.Control;
            this.userPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPass.Location = new System.Drawing.Point(58, 329);
            this.userPass.Multiline = true;
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(205, 24);
            this.userPass.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 486);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.userlog);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox userlog;
        private System.Windows.Forms.TextBox userPass;
    }
}

