namespace TimerExamples
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
            this.components = new System.ComponentModel.Container();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.colourLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countTimer
            // 
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(108, 38);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 61);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(143, 125);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(24, 25);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "0";
            // 
            // colourLabel
            // 
            this.colourLabel.BackColor = System.Drawing.Color.White;
            this.colourLabel.Location = new System.Drawing.Point(130, 168);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(50, 50);
            this.colourLabel.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(143, 246);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(24, 25);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}

