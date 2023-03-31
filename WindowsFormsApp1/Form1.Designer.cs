namespace WindowsFormsApp1
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
            this.btn_proxyoff = new System.Windows.Forms.Button();
            this.btn_proxyon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_proxyinstall = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_imp_sp = new System.Windows.Forms.Button();
            this.btn_imp_mos = new System.Windows.Forms.Button();
            this.btn_imp_ldv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_otl_assinatura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_proxyoff
            // 
            this.btn_proxyoff.Location = new System.Drawing.Point(21, 104);
            this.btn_proxyoff.Name = "btn_proxyoff";
            this.btn_proxyoff.Size = new System.Drawing.Size(75, 23);
            this.btn_proxyoff.TabIndex = 0;
            this.btn_proxyoff.Text = "Proxy OFF";
            this.btn_proxyoff.UseVisualStyleBackColor = true;
            this.btn_proxyoff.Click += new System.EventHandler(this.btn_proxyoff_Click);
            // 
            // btn_proxyon
            // 
            this.btn_proxyon.Location = new System.Drawing.Point(21, 75);
            this.btn_proxyon.Name = "btn_proxyon";
            this.btn_proxyon.Size = new System.Drawing.Size(75, 23);
            this.btn_proxyon.TabIndex = 1;
            this.btn_proxyon.Text = "Proxy ON";
            this.btn_proxyon.UseVisualStyleBackColor = true;
            this.btn_proxyon.Click += new System.EventHandler(this.Btn_proxyon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proxy Configuration";
            // 
            // btn_proxyinstall
            // 
            this.btn_proxyinstall.Location = new System.Drawing.Point(21, 46);
            this.btn_proxyinstall.Name = "btn_proxyinstall";
            this.btn_proxyinstall.Size = new System.Drawing.Size(75, 23);
            this.btn_proxyinstall.TabIndex = 5;
            this.btn_proxyinstall.Text = "Proxy Install";
            this.btn_proxyinstall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Impressoras";
            // 
            // btn_imp_sp
            // 
            this.btn_imp_sp.Location = new System.Drawing.Point(132, 46);
            this.btn_imp_sp.Name = "btn_imp_sp";
            this.btn_imp_sp.Size = new System.Drawing.Size(90, 23);
            this.btn_imp_sp.TabIndex = 7;
            this.btn_imp_sp.Text = "São Paulo";
            this.btn_imp_sp.UseVisualStyleBackColor = true;
            // 
            // btn_imp_mos
            // 
            this.btn_imp_mos.Location = new System.Drawing.Point(132, 75);
            this.btn_imp_mos.Name = "btn_imp_mos";
            this.btn_imp_mos.Size = new System.Drawing.Size(90, 23);
            this.btn_imp_mos.TabIndex = 8;
            this.btn_imp_mos.Text = "Mossoro";
            this.btn_imp_mos.UseVisualStyleBackColor = true;
            // 
            // btn_imp_ldv
            // 
            this.btn_imp_ldv.Location = new System.Drawing.Point(132, 104);
            this.btn_imp_ldv.Name = "btn_imp_ldv";
            this.btn_imp_ldv.Size = new System.Drawing.Size(90, 23);
            this.btn_imp_ldv.TabIndex = 9;
            this.btn_imp_ldv.Text = "Lagoa Ventos";
            this.btn_imp_ldv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Outlook";
            // 
            // btn_otl_assinatura
            // 
            this.btn_otl_assinatura.Location = new System.Drawing.Point(251, 46);
            this.btn_otl_assinatura.Name = "btn_otl_assinatura";
            this.btn_otl_assinatura.Size = new System.Drawing.Size(75, 23);
            this.btn_otl_assinatura.TabIndex = 11;
            this.btn_otl_assinatura.Text = "Assinatura";
            this.btn_otl_assinatura.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 418);
            this.Controls.Add(this.btn_otl_assinatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_imp_ldv);
            this.Controls.Add(this.btn_imp_mos);
            this.Controls.Add(this.btn_imp_sp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_proxyinstall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_proxyon);
            this.Controls.Add(this.btn_proxyoff);
            this.Name = "Form1";
            this.Text = "Maintainance Toolkit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_proxyoff;
        private System.Windows.Forms.Button btn_proxyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_proxyinstall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_imp_sp;
        private System.Windows.Forms.Button btn_imp_mos;
        private System.Windows.Forms.Button btn_imp_ldv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_otl_assinatura;
    }
}

