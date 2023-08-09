namespace ValidadorCNPJandCPF
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
            textBox1 = new TextBox();
            RbnCpf = new RadioButton();
            RbnCnpj = new RadioButton();
            BtnCorfirm = new Button();
            BtnSair = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 161);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 45);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RbnCpf
            // 
            RbnCpf.AutoSize = true;
            RbnCpf.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RbnCpf.Location = new Point(247, 70);
            RbnCpf.Name = "RbnCpf";
            RbnCpf.Size = new Size(79, 33);
            RbnCpf.TabIndex = 1;
            RbnCpf.TabStop = true;
            RbnCpf.Text = "CPF";
            RbnCpf.UseVisualStyleBackColor = true;
            RbnCpf.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // RbnCnpj
            // 
            RbnCnpj.AutoSize = true;
            RbnCnpj.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RbnCnpj.Location = new Point(487, 79);
            RbnCnpj.Name = "RbnCnpj";
            RbnCnpj.Size = new Size(91, 35);
            RbnCnpj.TabIndex = 2;
            RbnCnpj.TabStop = true;
            RbnCnpj.Text = "CNPJ";
            RbnCnpj.UseVisualStyleBackColor = true;
            // 
            // BtnCorfirm
            // 
            BtnCorfirm.Location = new Point(247, 221);
            BtnCorfirm.Name = "BtnCorfirm";
            BtnCorfirm.Size = new Size(95, 45);
            BtnCorfirm.TabIndex = 3;
            BtnCorfirm.Text = "Confirmar";
            BtnCorfirm.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(479, 221);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(99, 42);
            BtnSair.TabIndex = 4;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSair);
            Controls.Add(BtnCorfirm);
            Controls.Add(RbnCnpj);
            Controls.Add(RbnCpf);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RadioButton RbnCpf;
        private RadioButton RbnCnpj;
        private Button BtnCorfirm;
        private Button BtnSair;
    }
}