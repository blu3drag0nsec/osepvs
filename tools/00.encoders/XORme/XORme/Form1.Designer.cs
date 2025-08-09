namespace XORme
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
            this.txSource = new System.Windows.Forms.TextBox();
            this.txDestination = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.txXORKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txSource
            // 
            this.txSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.txSource.Location = new System.Drawing.Point(0, 0);
            this.txSource.Multiline = true;
            this.txSource.Name = "txSource";
            this.txSource.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txSource.Size = new System.Drawing.Size(504, 585);
            this.txSource.TabIndex = 0;
            // 
            // txDestination
            // 
            this.txDestination.Dock = System.Windows.Forms.DockStyle.Right;
            this.txDestination.Location = new System.Drawing.Point(593, 0);
            this.txDestination.Multiline = true;
            this.txDestination.Name = "txDestination";
            this.txDestination.ReadOnly = true;
            this.txDestination.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txDestination.Size = new System.Drawing.Size(504, 585);
            this.txDestination.TabIndex = 1;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(510, 148);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C#";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(510, 201);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(75, 23);
            this.btnV.TabIndex = 3;
            this.btnV.Text = "VBA";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // txXORKey
            // 
            this.txXORKey.Location = new System.Drawing.Point(510, 90);
            this.txXORKey.Name = "txXORKey";
            this.txXORKey.Size = new System.Drawing.Size(77, 20);
            this.txXORKey.TabIndex = 4;
            this.txXORKey.Text = "b3 1b fa ee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "hollow.xml";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txXORKey);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txDestination);
            this.Controls.Add(this.txSource);
            this.Name = "Form1";
            this.Text = "XORme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txSource;
        private System.Windows.Forms.TextBox txDestination;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.TextBox txXORKey;
        private System.Windows.Forms.Button button1;
    }
}

