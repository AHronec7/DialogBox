namespace DialogBox
{
    partial class PlayerInfo
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
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPlayerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.Location = new System.Drawing.Point(12, 42);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(221, 277);
            this.PlayersListBox.TabIndex = 0;
            this.PlayersListBox.SelectedIndexChanged += new System.EventHandler(this.PlayersListBox_SelectedIndexChanged);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreLabel.Location = new System.Drawing.Point(291, 66);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 23);
            this.ScoreLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // DateLabel
            // 
            this.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateLabel.Location = new System.Drawing.Point(291, 148);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(100, 28);
            this.DateLabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Player: ";
            // 
            // AddPlayerTextBox
            // 
            this.AddPlayerTextBox.Location = new System.Drawing.Point(291, 298);
            this.AddPlayerTextBox.Name = "AddPlayerTextBox";
            this.AddPlayerTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddPlayerTextBox.TabIndex = 6;
            this.AddPlayerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPlayerTextBox_KeyPress);
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 368);
            this.Controls.Add(this.AddPlayerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PlayersListBox);
            this.Name = "PlayerInfo";
            this.Text = "PlayerInfo";
            this.Load += new System.EventHandler(this.PlayerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddPlayerTextBox;
    }
}