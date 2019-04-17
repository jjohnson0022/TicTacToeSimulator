namespace Ch07ProjTicTacToe
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
            this.exitButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.topLeftLabel = new System.Windows.Forms.Label();
            this.topRightLabel = new System.Windows.Forms.Label();
            this.topMidLabel = new System.Windows.Forms.Label();
            this.midMidLabel = new System.Windows.Forms.Label();
            this.midRightLabel = new System.Windows.Forms.Label();
            this.midLeftLabel = new System.Windows.Forms.Label();
            this.bottomMidLabel = new System.Windows.Forms.Label();
            this.bottomRightLabel = new System.Windows.Forms.Label();
            this.bottomLeftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(156, 318);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(63, 318);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outcomeLabel.Location = new System.Drawing.Point(12, 278);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(277, 23);
            this.outcomeLabel.TabIndex = 2;
            this.outcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftLabel.Location = new System.Drawing.Point(12, 9);
            this.topLeftLabel.Name = "topLeftLabel";
            this.topLeftLabel.Size = new System.Drawing.Size(75, 71);
            this.topLeftLabel.TabIndex = 3;
            this.topLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topRightLabel
            // 
            this.topRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightLabel.Location = new System.Drawing.Point(214, 9);
            this.topRightLabel.Name = "topRightLabel";
            this.topRightLabel.Size = new System.Drawing.Size(75, 71);
            this.topRightLabel.TabIndex = 4;
            this.topRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topMidLabel
            // 
            this.topMidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topMidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMidLabel.Location = new System.Drawing.Point(111, 9);
            this.topMidLabel.Name = "topMidLabel";
            this.topMidLabel.Size = new System.Drawing.Size(75, 71);
            this.topMidLabel.TabIndex = 5;
            this.topMidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // midMidLabel
            // 
            this.midMidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midMidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midMidLabel.Location = new System.Drawing.Point(111, 96);
            this.midMidLabel.Name = "midMidLabel";
            this.midMidLabel.Size = new System.Drawing.Size(75, 71);
            this.midMidLabel.TabIndex = 8;
            this.midMidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // midRightLabel
            // 
            this.midRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midRightLabel.Location = new System.Drawing.Point(214, 96);
            this.midRightLabel.Name = "midRightLabel";
            this.midRightLabel.Size = new System.Drawing.Size(75, 71);
            this.midRightLabel.TabIndex = 7;
            this.midRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // midLeftLabel
            // 
            this.midLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midLeftLabel.Location = new System.Drawing.Point(12, 96);
            this.midLeftLabel.Name = "midLeftLabel";
            this.midLeftLabel.Size = new System.Drawing.Size(75, 71);
            this.midLeftLabel.TabIndex = 6;
            this.midLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomMidLabel
            // 
            this.bottomMidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomMidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMidLabel.Location = new System.Drawing.Point(111, 184);
            this.bottomMidLabel.Name = "bottomMidLabel";
            this.bottomMidLabel.Size = new System.Drawing.Size(75, 71);
            this.bottomMidLabel.TabIndex = 11;
            this.bottomMidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomRightLabel
            // 
            this.bottomRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRightLabel.Location = new System.Drawing.Point(214, 184);
            this.bottomRightLabel.Name = "bottomRightLabel";
            this.bottomRightLabel.Size = new System.Drawing.Size(75, 71);
            this.bottomRightLabel.TabIndex = 10;
            this.bottomRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomLeftLabel
            // 
            this.bottomLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeftLabel.Location = new System.Drawing.Point(12, 184);
            this.bottomLeftLabel.Name = "bottomLeftLabel";
            this.bottomLeftLabel.Size = new System.Drawing.Size(75, 71);
            this.bottomLeftLabel.TabIndex = 9;
            this.bottomLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 357);
            this.Controls.Add(this.bottomMidLabel);
            this.Controls.Add(this.bottomRightLabel);
            this.Controls.Add(this.bottomLeftLabel);
            this.Controls.Add(this.midMidLabel);
            this.Controls.Add(this.midRightLabel);
            this.Controls.Add(this.midLeftLabel);
            this.Controls.Add(this.topMidLabel);
            this.Controls.Add(this.topRightLabel);
            this.Controls.Add(this.topLeftLabel);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label outcomeLabel;
        private System.Windows.Forms.Label topLeftLabel;
        private System.Windows.Forms.Label topRightLabel;
        private System.Windows.Forms.Label topMidLabel;
        private System.Windows.Forms.Label midMidLabel;
        private System.Windows.Forms.Label midRightLabel;
        private System.Windows.Forms.Label midLeftLabel;
        private System.Windows.Forms.Label bottomMidLabel;
        private System.Windows.Forms.Label bottomRightLabel;
        private System.Windows.Forms.Label bottomLeftLabel;
    }
}

