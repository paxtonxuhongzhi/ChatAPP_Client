namespace TCPClient
{
    partial class TCPClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartConnect = new System.Windows.Forms.Button();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ConnectStateLable = new System.Windows.Forms.Label();
            this.ConnectState = new System.Windows.Forms.Label();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.SendBotton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceiveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartConnect
            // 
            this.StartConnect.Location = new System.Drawing.Point(246, 4);
            this.StartConnect.Name = "StartConnect";
            this.StartConnect.Size = new System.Drawing.Size(75, 23);
            this.StartConnect.TabIndex = 0;
            this.StartConnect.Text = "请求连接";
            this.StartConnect.UseVisualStyleBackColor = true;
            this.StartConnect.Click += new System.EventHandler(this.StartConnect_Click);
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(35, 6);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(205, 21);
            this.IPTextBox.TabIndex = 1;
            this.IPTextBox.Text = "192.168.0.107";
            this.IPTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPTextBox_KeyDown);
            // 
            // ConnectStateLable
            // 
            this.ConnectStateLable.AutoSize = true;
            this.ConnectStateLable.Location = new System.Drawing.Point(343, 9);
            this.ConnectStateLable.Name = "ConnectStateLable";
            this.ConnectStateLable.Size = new System.Drawing.Size(59, 12);
            this.ConnectStateLable.TabIndex = 2;
            this.ConnectStateLable.Text = "连接状态:";
            // 
            // ConnectState
            // 
            this.ConnectState.AutoSize = true;
            this.ConnectState.Location = new System.Drawing.Point(408, 9);
            this.ConnectState.Name = "ConnectState";
            this.ConnectState.Size = new System.Drawing.Size(41, 12);
            this.ConnectState.TabIndex = 3;
            this.ConnectState.Text = "未连接";
            // 
            // SendTextBox
            // 
            this.SendTextBox.AcceptsReturn = true;
            this.SendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTextBox.Location = new System.Drawing.Point(0, 324);
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SendTextBox.Size = new System.Drawing.Size(690, 126);
            this.SendTextBox.TabIndex = 4;
            this.SendTextBox.TextChanged += new System.EventHandler(this.SendTextBox_TextChanged);
            this.SendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown);
            // 
            // SendBotton
            // 
            this.SendBotton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBotton.Location = new System.Drawing.Point(696, 324);
            this.SendBotton.Name = "SendBotton";
            this.SendBotton.Size = new System.Drawing.Size(103, 23);
            this.SendBotton.TabIndex = 5;
            this.SendBotton.Text = "发送";
            this.SendBotton.UseVisualStyleBackColor = true;
            this.SendBotton.Click += new System.EventHandler(this.SendBotton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP";
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.AcceptsReturn = true;
            this.ReceiveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiveTextBox.Location = new System.Drawing.Point(0, 32);
            this.ReceiveTextBox.Multiline = true;
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReceiveTextBox.Size = new System.Drawing.Size(799, 286);
            this.ReceiveTextBox.TabIndex = 7;
            this.ReceiveTextBox.TextChanged += new System.EventHandler(this.ReceiveTextBox_TextChanged);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReceiveTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendBotton);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.ConnectState);
            this.Controls.Add(this.ConnectStateLable);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.StartConnect);
            this.Name = "TCPClient";
            this.Text = "TCPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartConnect;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label ConnectStateLable;
        private System.Windows.Forms.Label ConnectState;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Button SendBotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReceiveTextBox;
    }
}

