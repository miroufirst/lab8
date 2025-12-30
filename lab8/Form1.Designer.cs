namespace lab8
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
            this.btnSedan = new System.Windows.Forms.Button();
            this.btnSuv = new System.Windows.Forms.Button();
            this.btnGps = new System.Windows.Forms.Button();
            this.btnLeather = new System.Windows.Forms.Button();
            this.btnSpoiler = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSedan
            // 
            this.btnSedan.Location = new System.Drawing.Point(12, 12);
            this.btnSedan.Name = "btnSedan";
            this.btnSedan.Size = new System.Drawing.Size(189, 23);
            this.btnSedan.TabIndex = 0;
            this.btnSedan.Text = "New Sedan (10 000$)";
            this.btnSedan.UseVisualStyleBackColor = true;
            // 
            // btnSuv
            // 
            this.btnSuv.Location = new System.Drawing.Point(12, 41);
            this.btnSuv.Name = "btnSuv";
            this.btnSuv.Size = new System.Drawing.Size(189, 23);
            this.btnSuv.TabIndex = 1;
            this.btnSuv.Text = "New SUV (15 000$)";
            this.btnSuv.UseVisualStyleBackColor = true;
            // 
            // btnGps
            // 
            this.btnGps.Location = new System.Drawing.Point(12, 70);
            this.btnGps.Name = "btnGps";
            this.btnGps.Size = new System.Drawing.Size(189, 23);
            this.btnGps.TabIndex = 2;
            this.btnGps.Text = "Add GPS (+500$)";
            this.btnGps.UseVisualStyleBackColor = true;
            // 
            // btnLeather
            // 
            this.btnLeather.Location = new System.Drawing.Point(12, 99);
            this.btnLeather.Name = "btnLeather";
            this.btnLeather.Size = new System.Drawing.Size(189, 23);
            this.btnLeather.TabIndex = 3;
            this.btnLeather.Text = "Add Leather (+1000$)";
            this.btnLeather.UseVisualStyleBackColor = true;
            // 
            // btnSpoiler
            // 
            this.btnSpoiler.Location = new System.Drawing.Point(12, 128);
            this.btnSpoiler.Name = "btnSpoiler";
            this.btnSpoiler.Size = new System.Drawing.Size(189, 23);
            this.btnSpoiler.TabIndex = 4;
            this.btnSpoiler.Text = "Add Spoiler (+300$)";
            this.btnSpoiler.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(23, 166);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(87, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Select a car...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 529);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSpoiler);
            this.Controls.Add(this.btnLeather);
            this.Controls.Add(this.btnGps);
            this.Controls.Add(this.btnSuv);
            this.Controls.Add(this.btnSedan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSedan;
        private System.Windows.Forms.Button btnSuv;
        private System.Windows.Forms.Button btnGps;
        private System.Windows.Forms.Button btnLeather;
        private System.Windows.Forms.Button btnSpoiler;
        private System.Windows.Forms.Label lblResult;
    }
}

