namespace server
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
            this.connectButton = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // feed
            // 
            this.feed.Location = new System.Drawing.Point(278, 34);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(305, 288);
            this.feed.TabIndex = 0;
            this.feed.Text = "";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(76, 210);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(145, 58);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Open";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(25, 107);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(127, 17);
            this.description.TabIndex = 2;
            this.description.Text = "Enter port number:";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(168, 107);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(85, 22);
            this.port.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 363);
            this.Controls.Add(this.port);
            this.Controls.Add(this.description);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.feed);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox feed;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox port;
    }
}

