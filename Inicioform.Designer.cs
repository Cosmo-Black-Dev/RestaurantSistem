namespace Sistema_de_Restaurantes
{
    partial class Inicioform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicioform));
            label1 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 275);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(43, 318);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(320, 34);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(43, 428);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(320, 34);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 385);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(43, 486);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(153, 47);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(210, 486);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 47);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(3, 229);
            label3.Margin = new Padding(0, 180, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(259, 28);
            label3.TabIndex = 7;
            label3.Text = "Plese enter user information.";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 12);
            pictureBox1.Margin = new Padding(100, 12, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.BackColor = Color.Teal;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(416, 223);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // Inicioform
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(416, 576);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicioform";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label2;
        private Button btnLogin;
        private Button btnExit;
        private Label label3;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
