
namespace CodeName308.Views
{
    partial class FrmTrustGame
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
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnStory = new System.Windows.Forms.Button();
            this.btnSandBox = new System.Windows.Forms.Button();
            this.btnGameSetting = new System.Windows.Forms.Button();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.btnTrust = new System.Windows.Forms.Button();
            this.btnBetray = new System.Windows.Forms.Button();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMessage
            // 
            this.tbxMessage.BackColor = System.Drawing.Color.PowderBlue;
            this.tbxMessage.Location = new System.Drawing.Point(13, 209);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ReadOnly = true;
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMessage.Size = new System.Drawing.Size(757, 382);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMessage_KeyDown);
            // 
            // btnTutorial
            // 
            this.btnTutorial.Location = new System.Drawing.Point(13, 12);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(153, 29);
            this.btnTutorial.TabIndex = 2;
            this.btnTutorial.Text = "Game Tutorial";
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnStory
            // 
            this.btnStory.Location = new System.Drawing.Point(12, 62);
            this.btnStory.Name = "btnStory";
            this.btnStory.Size = new System.Drawing.Size(154, 29);
            this.btnStory.TabIndex = 3;
            this.btnStory.Text = "Story Mode";
            this.btnStory.UseVisualStyleBackColor = true;
            // 
            // btnSandBox
            // 
            this.btnSandBox.Location = new System.Drawing.Point(13, 112);
            this.btnSandBox.Name = "btnSandBox";
            this.btnSandBox.Size = new System.Drawing.Size(153, 29);
            this.btnSandBox.TabIndex = 4;
            this.btnSandBox.Text = "Sand Box Mode";
            this.btnSandBox.UseVisualStyleBackColor = true;
            // 
            // btnGameSetting
            // 
            this.btnGameSetting.Location = new System.Drawing.Point(13, 162);
            this.btnGameSetting.Name = "btnGameSetting";
            this.btnGameSetting.Size = new System.Drawing.Size(153, 29);
            this.btnGameSetting.TabIndex = 5;
            this.btnGameSetting.Text = "Game Setting";
            this.btnGameSetting.UseVisualStyleBackColor = true;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Location = new System.Drawing.Point(13, 11);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(290, 180);
            this.pbPlayer1.TabIndex = 6;
            this.pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Location = new System.Drawing.Point(480, 11);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(290, 180);
            this.pbPlayer2.TabIndex = 7;
            this.pbPlayer2.TabStop = false;
            // 
            // btnTrust
            // 
            this.btnTrust.Location = new System.Drawing.Point(339, 12);
            this.btnTrust.Name = "btnTrust";
            this.btnTrust.Size = new System.Drawing.Size(94, 29);
            this.btnTrust.TabIndex = 8;
            this.btnTrust.Text = "Trust";
            this.btnTrust.UseVisualStyleBackColor = true;
            this.btnTrust.Click += new System.EventHandler(this.btnTrust_Click);
            // 
            // btnBetray
            // 
            this.btnBetray.Location = new System.Drawing.Point(339, 162);
            this.btnBetray.Name = "btnBetray";
            this.btnBetray.Size = new System.Drawing.Size(94, 29);
            this.btnBetray.TabIndex = 9;
            this.btnBetray.Text = "Betray";
            this.btnBetray.UseVisualStyleBackColor = true;
            this.btnBetray.Click += new System.EventHandler(this.btnBetray_Click);
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPlayer1Score.Location = new System.Drawing.Point(190, 149);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(226, 42);
            this.lblPlayer1Score.TabIndex = 10;
            this.lblPlayer1Score.Text = "Player1Score";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPlayer2Score.Location = new System.Drawing.Point(644, 149);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(226, 42);
            this.lblPlayer2Score.TabIndex = 11;
            this.lblPlayer2Score.Text = "Player2Score";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTurn.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTurn.Location = new System.Drawing.Point(339, 81);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(92, 42);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Turn";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPlayer2Name.Location = new System.Drawing.Point(472, 149);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(114, 42);
            this.lblPlayer2Name.TabIndex = 13;
            this.lblPlayer2Name.Text = "Name";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPlayer1Name.Location = new System.Drawing.Point(0, 149);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(114, 42);
            this.lblPlayer1Name.TabIndex = 14;
            this.lblPlayer1Name.Text = "Name";
            // 
            // FrmTrustGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(792, 603);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.btnBetray);
            this.Controls.Add(this.btnTrust);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.btnGameSetting);
            this.Controls.Add(this.btnSandBox);
            this.Controls.Add(this.btnStory);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.pbPlayer1);
            this.Name = "FrmTrustGame";
            this.Text = "FrmTrustGame";
            this.Load += new System.EventHandler(this.FrmTrustGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnStory;
        private System.Windows.Forms.Button btnSandBox;
        private System.Windows.Forms.Button btnGameSetting;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Button btnTrust;
        private System.Windows.Forms.Button btnBetray;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
    }
}