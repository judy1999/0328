﻿
namespace _0328
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_listenPort = new System.Windows.Forms.TextBox();
            this.textBox_receiveMsg = new System.Windows.Forms.TextBox();
            this.textBox_targetIP = new System.Windows.Forms.TextBox();
            this.textBox_targetPort = new System.Windows.Forms.TextBox();
            this.textBox_sendMsg = new System.Windows.Forms.TextBox();
            this.button_startListen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "接聽";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "接收文字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "目標IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "目標Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "傳送文字";
            // 
            // textBox_listenPort
            // 
            this.textBox_listenPort.Location = new System.Drawing.Point(134, 31);
            this.textBox_listenPort.Name = "textBox_listenPort";
            this.textBox_listenPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_listenPort.TabIndex = 5;
            // 
            // textBox_receiveMsg
            // 
            this.textBox_receiveMsg.Location = new System.Drawing.Point(134, 70);
            this.textBox_receiveMsg.Name = "textBox_receiveMsg";
            this.textBox_receiveMsg.Size = new System.Drawing.Size(232, 22);
            this.textBox_receiveMsg.TabIndex = 6;
            // 
            // textBox_targetIP
            // 
            this.textBox_targetIP.Location = new System.Drawing.Point(134, 138);
            this.textBox_targetIP.Name = "textBox_targetIP";
            this.textBox_targetIP.Size = new System.Drawing.Size(100, 22);
            this.textBox_targetIP.TabIndex = 7;
            // 
            // textBox_targetPort
            // 
            this.textBox_targetPort.Location = new System.Drawing.Point(134, 185);
            this.textBox_targetPort.Name = "textBox_targetPort";
            this.textBox_targetPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_targetPort.TabIndex = 8;
            // 
            // textBox_sendMsg
            // 
            this.textBox_sendMsg.Location = new System.Drawing.Point(134, 235);
            this.textBox_sendMsg.Name = "textBox_sendMsg";
            this.textBox_sendMsg.Size = new System.Drawing.Size(232, 22);
            this.textBox_sendMsg.TabIndex = 9;
            // 
            // button_startListen
            // 
            this.button_startListen.Location = new System.Drawing.Point(466, 69);
            this.button_startListen.Name = "button_startListen";
            this.button_startListen.Size = new System.Drawing.Size(75, 23);
            this.button_startListen.TabIndex = 10;
            this.button_startListen.Text = "啟動接收";
            this.button_startListen.UseVisualStyleBackColor = true;
            this.button_startListen.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "傳送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_startListen);
            this.Controls.Add(this.textBox_sendMsg);
            this.Controls.Add(this.textBox_targetPort);
            this.Controls.Add(this.textBox_targetIP);
            this.Controls.Add(this.textBox_receiveMsg);
            this.Controls.Add(this.textBox_listenPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_listenPort;
        private System.Windows.Forms.TextBox textBox_receiveMsg;
        private System.Windows.Forms.TextBox textBox_targetIP;
        private System.Windows.Forms.TextBox textBox_targetPort;
        private System.Windows.Forms.TextBox textBox_sendMsg;
        private System.Windows.Forms.Button button_startListen;
        private System.Windows.Forms.Button button2;
    }
}

