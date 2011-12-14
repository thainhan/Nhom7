namespace MI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.baseaddress = new System.Windows.Forms.TextBox();
            this.mess = new System.Windows.Forms.TextBox();
            this.mex = new System.Windows.Forms.CheckBox();
            this.tb_WSHttpBinding = new System.Windows.Forms.TextBox();
            this.tb_NetTCPBinding = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctwshttp = new System.Windows.Forms.TextBox();
            this.ctnettcp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wshttp = new System.Windows.Forms.TextBox();
            this.nettcp = new System.Windows.Forms.TextBox();
            this.cb_EndPoints2 = new System.Windows.Forms.CheckBox();
            this.cb_EndPoints1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(372, 10);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(99, 45);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(372, 68);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(99, 49);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Base Address";
            // 
            // baseaddress
            // 
            this.baseaddress.Location = new System.Drawing.Point(84, 10);
            this.baseaddress.Name = "baseaddress";
            this.baseaddress.Size = new System.Drawing.Size(187, 20);
            this.baseaddress.TabIndex = 9;
            this.baseaddress.Text = "localhost:8000";
            // 
            // mess
            // 
            this.mess.Location = new System.Drawing.Point(9, 123);
            this.mess.Name = "mess";
            this.mess.ReadOnly = true;
            this.mess.Size = new System.Drawing.Size(462, 20);
            this.mess.TabIndex = 10;
            // 
            // mex
            // 
            this.mex.AutoSize = true;
            this.mex.Checked = true;
            this.mex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mex.Location = new System.Drawing.Point(277, 12);
            this.mex.Name = "mex";
            this.mex.Size = new System.Drawing.Size(79, 17);
            this.mex.TabIndex = 11;
            this.mex.Text = "Show MEX";
            this.mex.UseVisualStyleBackColor = true;
            // 
            // tb_WSHttpBinding
            // 
            this.tb_WSHttpBinding.Enabled = false;
            this.tb_WSHttpBinding.Location = new System.Drawing.Point(266, 97);
            this.tb_WSHttpBinding.Name = "tb_WSHttpBinding";
            this.tb_WSHttpBinding.Size = new System.Drawing.Size(100, 20);
            this.tb_WSHttpBinding.TabIndex = 16;
            this.tb_WSHttpBinding.Text = "WSHttp_MI";
            // 
            // tb_NetTCPBinding
            // 
            this.tb_NetTCPBinding.Enabled = false;
            this.tb_NetTCPBinding.Location = new System.Drawing.Point(266, 68);
            this.tb_NetTCPBinding.Name = "tb_NetTCPBinding";
            this.tb_NetTCPBinding.Size = new System.Drawing.Size(100, 20);
            this.tb_NetTCPBinding.TabIndex = 15;
            this.tb_NetTCPBinding.Text = "NetTcp_MI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // ctwshttp
            // 
            this.ctwshttp.Location = new System.Drawing.Point(151, 97);
            this.ctwshttp.Name = "ctwshttp";
            this.ctwshttp.Size = new System.Drawing.Size(100, 20);
            this.ctwshttp.TabIndex = 10;
            this.ctwshttp.Text = "WSHttp";
            // 
            // ctnettcp
            // 
            this.ctnettcp.Location = new System.Drawing.Point(151, 68);
            this.ctnettcp.Name = "ctnettcp";
            this.ctnettcp.Size = new System.Drawing.Size(100, 20);
            this.ctnettcp.TabIndex = 9;
            this.ctnettcp.Text = "NetTCP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contract";
            // 
            // wshttp
            // 
            this.wshttp.Location = new System.Drawing.Point(31, 97);
            this.wshttp.Name = "wshttp";
            this.wshttp.Size = new System.Drawing.Size(100, 20);
            this.wshttp.TabIndex = 4;
            this.wshttp.Text = "WSHttpBinding";
            // 
            // nettcp
            // 
            this.nettcp.Location = new System.Drawing.Point(32, 68);
            this.nettcp.Name = "nettcp";
            this.nettcp.Size = new System.Drawing.Size(100, 20);
            this.nettcp.TabIndex = 3;
            this.nettcp.Text = "NetTCPBinding";
            // 
            // cb_EndPoints2
            // 
            this.cb_EndPoints2.AutoSize = true;
            this.cb_EndPoints2.Checked = true;
            this.cb_EndPoints2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_EndPoints2.Location = new System.Drawing.Point(10, 100);
            this.cb_EndPoints2.Name = "cb_EndPoints2";
            this.cb_EndPoints2.Size = new System.Drawing.Size(15, 14);
            this.cb_EndPoints2.TabIndex = 1;
            this.cb_EndPoints2.UseVisualStyleBackColor = true;
            // 
            // cb_EndPoints1
            // 
            this.cb_EndPoints1.AutoSize = true;
            this.cb_EndPoints1.Checked = true;
            this.cb_EndPoints1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_EndPoints1.Location = new System.Drawing.Point(9, 71);
            this.cb_EndPoints1.Name = "cb_EndPoints1";
            this.cb_EndPoints1.Size = new System.Drawing.Size(15, 14);
            this.cb_EndPoints1.TabIndex = 0;
            this.cb_EndPoints1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Binding";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(485, 146);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_WSHttpBinding);
            this.Controls.Add(this.tb_NetTCPBinding);
            this.Controls.Add(this.mex);
            this.Controls.Add(this.mess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.baseaddress);
            this.Controls.Add(this.ctwshttp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctnettcp);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.wshttp);
            this.Controls.Add(this.cb_EndPoints1);
            this.Controls.Add(this.nettcp);
            this.Controls.Add(this.cb_EndPoints2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Configure Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baseaddress;
        private System.Windows.Forms.TextBox mess;
        private System.Windows.Forms.CheckBox mex;
        private System.Windows.Forms.TextBox tb_WSHttpBinding;
        private System.Windows.Forms.TextBox tb_NetTCPBinding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctwshttp;
        private System.Windows.Forms.TextBox ctnettcp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wshttp;
        private System.Windows.Forms.TextBox nettcp;
        private System.Windows.Forms.CheckBox cb_EndPoints2;
        private System.Windows.Forms.CheckBox cb_EndPoints1;
        private System.Windows.Forms.Label label4;
    }
}

