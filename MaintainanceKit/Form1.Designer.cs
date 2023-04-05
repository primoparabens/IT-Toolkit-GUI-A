namespace MaintainanceKit
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
            components = new System.ComponentModel.Container();
            btn_proxy_on = new Button();
            btn_proxy_off = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btn_proxy_on
            // 
            btn_proxy_on.Location = new Point(12, 63);
            btn_proxy_on.Name = "btn_proxy_on";
            btn_proxy_on.Size = new Size(87, 23);
            btn_proxy_on.TabIndex = 0;
            btn_proxy_on.Text = "ON";
            btn_proxy_on.UseVisualStyleBackColor = true;
            btn_proxy_on.Click += btn_proxy_on_Click;
            // 
            // btn_proxy_off
            // 
            btn_proxy_off.Location = new Point(12, 92);
            btn_proxy_off.Name = "btn_proxy_off";
            btn_proxy_off.Size = new Size(87, 23);
            btn_proxy_off.TabIndex = 1;
            btn_proxy_off.Text = "OFF";
            btn_proxy_off.UseVisualStyleBackColor = true;
            btn_proxy_off.Click += btn_proxy_off_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 447);
            Controls.Add(btn_proxy_off);
            Controls.Add(btn_proxy_on);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_proxy_on;
        private Button btn_proxy_off;
        private BindingSource bindingSource1;
    }
}