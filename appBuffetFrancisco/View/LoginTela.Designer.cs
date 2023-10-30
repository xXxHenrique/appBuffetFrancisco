namespace appBuffetFrancisco.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            pictureBox1 = new PictureBox();
            txtBox_senha = new TextBox();
            txtbox_usuario = new TextBox();
            label3 = new Label();
            bnt_acessar = new Button();
            label2 = new Label();
            btn_sair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5545071;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtBox_senha
            // 
            txtBox_senha.Location = new Point(346, 133);
            txtBox_senha.Name = "txtBox_senha";
            txtBox_senha.PasswordChar = '*';
            txtBox_senha.Size = new Size(217, 23);
            txtBox_senha.TabIndex = 3;
            // 
            // txtbox_usuario
            // 
            txtbox_usuario.Location = new Point(361, 57);
            txtbox_usuario.Name = "txtbox_usuario";
            txtbox_usuario.Size = new Size(217, 23);
            txtbox_usuario.TabIndex = 4;
            txtbox_usuario.TextChanged += txtbox_usuario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(269, 131);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // bnt_acessar
            // 
            bnt_acessar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_acessar.Location = new Point(527, 225);
            bnt_acessar.Name = "bnt_acessar";
            bnt_acessar.Size = new Size(127, 36);
            bnt_acessar.TabIndex = 5;
            bnt_acessar.Text = "Acessar";
            bnt_acessar.UseVisualStyleBackColor = true;
            bnt_acessar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(269, 57);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sair.Location = new Point(603, 283);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(70, 30);
            btn_sair.TabIndex = 8;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // LoginTela
            // 
            AcceptButton = bnt_acessar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = btn_sair;
            ClientSize = new Size(685, 325);
            Controls.Add(btn_sair);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(bnt_acessar);
            Controls.Add(txtBox_senha);
            Controls.Add(txtbox_usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginTela";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox txtBox_senha;
        private TextBox txtbox_usuario;
        private Label label3;
        private Button bnt_acessar;
        private Label label2;
        private Button btn_sair;
    }
}