namespace AtividadeFORMS
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
            BtnConfirm = new Button();
            BtnExit = new Button();
            TxtResu = new TextBox();
            RbnCPF = new RadioButton();
            RbnCnpj = new RadioButton();
            SuspendLayout();
            // 
            // BtnConfirm
            // 
            BtnConfirm.Location = new Point(237, 247);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(119, 59);
            BtnConfirm.TabIndex = 0;
            BtnConfirm.Text = "Confirmar";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(455, 251);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(110, 55);
            BtnExit.TabIndex = 1;
            BtnExit.Text = "Sair";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // TxtResu
            // 
            TxtResu.Location = new Point(229, 182);
            TxtResu.Name = "TxtResu";
            TxtResu.Size = new Size(336, 23);
            TxtResu.TabIndex = 2;
            // 
            // RbnCPF
            // 
            RbnCPF.AutoSize = true;
            RbnCPF.Location = new Point(268, 110);
            RbnCPF.Name = "RbnCPF";
            RbnCPF.Size = new Size(46, 19);
            RbnCPF.TabIndex = 3;
            RbnCPF.TabStop = true;
            RbnCPF.Text = "CPF";
            RbnCPF.UseVisualStyleBackColor = true;
            // 
            // RbnCnpj
            // 
            RbnCnpj.AutoSize = true;
            RbnCnpj.Location = new Point(492, 110);
            RbnCnpj.Name = "RbnCnpj";
            RbnCnpj.Size = new Size(52, 19);
            RbnCnpj.TabIndex = 4;
            RbnCnpj.TabStop = true;
            RbnCnpj.Text = "CNPJ";
            RbnCnpj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RbnCnpj);
            Controls.Add(RbnCPF);
            Controls.Add(TxtResu);
            Controls.Add(BtnExit);
            Controls.Add(BtnConfirm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConfirm;
        private Button BtnExit;
        private TextBox TxtResu;
        private RadioButton RbnCPF;
        private RadioButton RbnCnpj;
    }
}