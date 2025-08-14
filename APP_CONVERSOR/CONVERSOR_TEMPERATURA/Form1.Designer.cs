namespace CONVERSOR_TEMPERATURA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBOrigem = new System.Windows.Forms.GroupBox();
            this.RbK = new System.Windows.Forms.RadioButton();
            this.RbF = new System.Windows.Forms.RadioButton();
            this.RbC = new System.Windows.Forms.RadioButton();
            this.GBDestino = new System.Windows.Forms.GroupBox();
            this.RbToK = new System.Windows.Forms.RadioButton();
            this.RbToF = new System.Windows.Forms.RadioButton();
            this.RbToC = new System.Windows.Forms.RadioButton();
            this.GBTemperatura = new System.Windows.Forms.GroupBox();
            this.LbResposta = new System.Windows.Forms.Label();
            this.BtnConveter = new System.Windows.Forms.Button();
            this.TxtTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBOrigem.SuspendLayout();
            this.GBDestino.SuspendLayout();
            this.GBTemperatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBOrigem
            // 
            this.GBOrigem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GBOrigem.Controls.Add(this.RbK);
            this.GBOrigem.Controls.Add(this.RbF);
            this.GBOrigem.Controls.Add(this.RbC);
            this.GBOrigem.Location = new System.Drawing.Point(13, 13);
            this.GBOrigem.Name = "GBOrigem";
            this.GBOrigem.Size = new System.Drawing.Size(247, 151);
            this.GBOrigem.TabIndex = 0;
            this.GBOrigem.TabStop = false;
            this.GBOrigem.Text = "CONVERTER DE";
            // 
            // RbK
            // 
            this.RbK.AutoSize = true;
            this.RbK.Location = new System.Drawing.Point(17, 119);
            this.RbK.Name = "RbK";
            this.RbK.Size = new System.Drawing.Size(63, 17);
            this.RbK.TabIndex = 2;
            this.RbK.TabStop = true;
            this.RbK.Text = "KELVIN";
            this.RbK.UseVisualStyleBackColor = true;
            // 
            // RbF
            // 
            this.RbF.AutoSize = true;
            this.RbF.Location = new System.Drawing.Point(17, 75);
            this.RbF.Name = "RbF";
            this.RbF.Size = new System.Drawing.Size(97, 17);
            this.RbF.TabIndex = 1;
            this.RbF.TabStop = true;
            this.RbF.Text = "FAHREINHEIT";
            this.RbF.UseVisualStyleBackColor = true;
            // 
            // RbC
            // 
            this.RbC.AutoSize = true;
            this.RbC.Location = new System.Drawing.Point(17, 30);
            this.RbC.Name = "RbC";
            this.RbC.Size = new System.Drawing.Size(70, 17);
            this.RbC.TabIndex = 0;
            this.RbC.TabStop = true;
            this.RbC.Text = "CELSIUS";
            this.RbC.UseVisualStyleBackColor = true;
            // 
            // GBDestino
            // 
            this.GBDestino.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GBDestino.Controls.Add(this.RbToK);
            this.GBDestino.Controls.Add(this.RbToF);
            this.GBDestino.Controls.Add(this.RbToC);
            this.GBDestino.Location = new System.Drawing.Point(281, 13);
            this.GBDestino.Name = "GBDestino";
            this.GBDestino.Size = new System.Drawing.Size(247, 151);
            this.GBDestino.TabIndex = 1;
            this.GBDestino.TabStop = false;
            this.GBDestino.Text = "PARA";
            // 
            // RbToK
            // 
            this.RbToK.AutoSize = true;
            this.RbToK.Location = new System.Drawing.Point(17, 119);
            this.RbToK.Name = "RbToK";
            this.RbToK.Size = new System.Drawing.Size(63, 17);
            this.RbToK.TabIndex = 2;
            this.RbToK.TabStop = true;
            this.RbToK.Text = "KELVIN";
            this.RbToK.UseVisualStyleBackColor = true;
            // 
            // RbToF
            // 
            this.RbToF.AutoSize = true;
            this.RbToF.Location = new System.Drawing.Point(17, 75);
            this.RbToF.Name = "RbToF";
            this.RbToF.Size = new System.Drawing.Size(97, 17);
            this.RbToF.TabIndex = 1;
            this.RbToF.TabStop = true;
            this.RbToF.Text = "FAHREINHEIT";
            this.RbToF.UseVisualStyleBackColor = true;
            // 
            // RbToC
            // 
            this.RbToC.AutoSize = true;
            this.RbToC.Location = new System.Drawing.Point(17, 30);
            this.RbToC.Name = "RbToC";
            this.RbToC.Size = new System.Drawing.Size(70, 17);
            this.RbToC.TabIndex = 0;
            this.RbToC.TabStop = true;
            this.RbToC.Text = "CELSIUS";
            this.RbToC.UseVisualStyleBackColor = true;
            // 
            // GBTemperatura
            // 
            this.GBTemperatura.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GBTemperatura.Controls.Add(this.LbResposta);
            this.GBTemperatura.Controls.Add(this.BtnConveter);
            this.GBTemperatura.Controls.Add(this.TxtTemperatura);
            this.GBTemperatura.Controls.Add(this.label1);
            this.GBTemperatura.Location = new System.Drawing.Point(13, 177);
            this.GBTemperatura.Name = "GBTemperatura";
            this.GBTemperatura.Size = new System.Drawing.Size(514, 403);
            this.GBTemperatura.TabIndex = 2;
            this.GBTemperatura.TabStop = false;
            this.GBTemperatura.Text = "TEMPERATURA";
            // 
            // LbResposta
            // 
            this.LbResposta.BackColor = System.Drawing.Color.Cornsilk;
            this.LbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResposta.Location = new System.Drawing.Point(14, 221);
            this.LbResposta.Name = "LbResposta";
            this.LbResposta.Size = new System.Drawing.Size(484, 169);
            this.LbResposta.TabIndex = 3;
            this.LbResposta.Text = "Resposta";
            this.LbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConveter
            // 
            this.BtnConveter.Location = new System.Drawing.Point(162, 148);
            this.BtnConveter.Name = "BtnConveter";
            this.BtnConveter.Size = new System.Drawing.Size(193, 32);
            this.BtnConveter.TabIndex = 2;
            this.BtnConveter.Text = "CONVERTER";
            this.BtnConveter.UseVisualStyleBackColor = true;
            this.BtnConveter.Click += new System.EventHandler(this.BtnConveter_Click);
            // 
            // TxtTemperatura
            // 
            this.TxtTemperatura.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTemperatura.Location = new System.Drawing.Point(72, 97);
            this.TxtTemperatura.Name = "TxtTemperatura";
            this.TxtTemperatura.Size = new System.Drawing.Size(366, 26);
            this.TxtTemperatura.TabIndex = 1;
            this.TxtTemperatura.Text = "0";
            this.TxtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE O VALOR DA TEMPERATURA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(540, 592);
            this.Controls.Add(this.GBTemperatura);
            this.Controls.Add(this.GBDestino);
            this.Controls.Add(this.GBOrigem);
            this.Name = "Form1";
            this.Text = "CONVERSOR TEMPERATURA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBOrigem.ResumeLayout(false);
            this.GBOrigem.PerformLayout();
            this.GBDestino.ResumeLayout(false);
            this.GBDestino.PerformLayout();
            this.GBTemperatura.ResumeLayout(false);
            this.GBTemperatura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBOrigem;
        private System.Windows.Forms.RadioButton RbK;
        private System.Windows.Forms.RadioButton RbF;
        private System.Windows.Forms.RadioButton RbC;
        private System.Windows.Forms.GroupBox GBDestino;
        private System.Windows.Forms.RadioButton RbToK;
        private System.Windows.Forms.RadioButton RbToF;
        private System.Windows.Forms.RadioButton RbToC;
        private System.Windows.Forms.GroupBox GBTemperatura;
        private System.Windows.Forms.Button BtnConveter;
        private System.Windows.Forms.TextBox TxtTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbResposta;
    }
}

