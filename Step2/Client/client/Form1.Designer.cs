namespace WindowsFormsApplication5
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
            this.feed = new System.Windows.Forms.RichTextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.IP_a = new System.Windows.Forms.TextBox();
            this.player_q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feed
            // 
            this.feed.Location = new System.Drawing.Point(294, 28);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(415, 379);
            this.feed.TabIndex = 0;
            this.feed.Text = "";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(154, 232);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 22);
            this.portBox.TabIndex = 1;
            // 
            // IP_a
            // 
            this.IP_a.Location = new System.Drawing.Point(154, 162);
            this.IP_a.Name = "IP_a";
            this.IP_a.Size = new System.Drawing.Size(100, 22);
            this.IP_a.TabIndex = 2;
            // 
            // player_q
            // 
            this.player_q.Location = new System.Drawing.Point(154, 82);
            this.player_q.Name = "player_q";
            this.player_q.Size = new System.Drawing.Size(100, 22);
            this.player_q.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(32, 294);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(222, 113);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP Adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player_q);
            this.Controls.Add(this.IP_a);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.feed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox feed;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox IP_a;
        private System.Windows.Forms.TextBox player_q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

