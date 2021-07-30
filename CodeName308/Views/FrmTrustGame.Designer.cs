
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
            this.btnCharaters = new System.Windows.Forms.Button();
            this.btnGameStart = new System.Windows.Forms.Button();
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
            this.lblScoreRank = new System.Windows.Forms.Label();
            this.panelGameSetting = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxErrorRate = new System.Windows.Forms.TextBox();
            this.tbxInitScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxGameCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPlayerCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGameSettingConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.panelGameSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMessage
            // 
            this.tbxMessage.BackColor = System.Drawing.Color.PowderBlue;
            this.tbxMessage.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // btnCharaters
            // 
            this.btnCharaters.Location = new System.Drawing.Point(13, 117);
            this.btnCharaters.Name = "btnCharaters";
            this.btnCharaters.Size = new System.Drawing.Size(154, 29);
            this.btnCharaters.TabIndex = 3;
            this.btnCharaters.Text = "Characters";
            this.btnCharaters.UseVisualStyleBackColor = true;
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(14, 65);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(153, 29);
            this.btnGameStart.TabIndex = 4;
            this.btnGameStart.Text = "Game Start";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // btnGameSetting
            // 
            this.btnGameSetting.Location = new System.Drawing.Point(13, 162);
            this.btnGameSetting.Name = "btnGameSetting";
            this.btnGameSetting.Size = new System.Drawing.Size(153, 29);
            this.btnGameSetting.TabIndex = 5;
            this.btnGameSetting.Text = "Game Setting";
            this.btnGameSetting.UseVisualStyleBackColor = true;
            this.btnGameSetting.Click += new System.EventHandler(this.btnGameSetting_Click);
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
            // lblScoreRank
            // 
            this.lblScoreRank.AutoSize = true;
            this.lblScoreRank.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScoreRank.Location = new System.Drawing.Point(513, 227);
            this.lblScoreRank.Name = "lblScoreRank";
            this.lblScoreRank.Size = new System.Drawing.Size(73, 22);
            this.lblScoreRank.TabIndex = 15;
            this.lblScoreRank.Text = "lblRank";
            // 
            // panelGameSetting
            // 
            this.panelGameSetting.BackColor = System.Drawing.Color.Moccasin;
            this.panelGameSetting.Controls.Add(this.btnGameSettingConfirm);
            this.panelGameSetting.Controls.Add(this.tbxPlayerCount);
            this.panelGameSetting.Controls.Add(this.label4);
            this.panelGameSetting.Controls.Add(this.tbxGameCount);
            this.panelGameSetting.Controls.Add(this.label3);
            this.panelGameSetting.Controls.Add(this.tbxInitScore);
            this.panelGameSetting.Controls.Add(this.label2);
            this.panelGameSetting.Controls.Add(this.tbxErrorRate);
            this.panelGameSetting.Controls.Add(this.label1);
            this.panelGameSetting.Location = new System.Drawing.Point(173, 12);
            this.panelGameSetting.Name = "panelGameSetting";
            this.panelGameSetting.Size = new System.Drawing.Size(369, 579);
            this.panelGameSetting.TabIndex = 16;
            this.panelGameSetting.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Error Rate";
            // 
            // tbxErrorRate
            // 
            this.tbxErrorRate.Location = new System.Drawing.Point(207, 20);
            this.tbxErrorRate.Name = "tbxErrorRate";
            this.tbxErrorRate.Size = new System.Drawing.Size(125, 27);
            this.tbxErrorRate.TabIndex = 1;
            // 
            // tbxInitScore
            // 
            this.tbxInitScore.Location = new System.Drawing.Point(207, 89);
            this.tbxInitScore.Name = "tbxInitScore";
            this.tbxInitScore.Size = new System.Drawing.Size(125, 27);
            this.tbxInitScore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial Score";
            // 
            // tbxGameCount
            // 
            this.tbxGameCount.Location = new System.Drawing.Point(207, 158);
            this.tbxGameCount.Name = "tbxGameCount";
            this.tbxGameCount.Size = new System.Drawing.Size(125, 27);
            this.tbxGameCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turns per Game";
            // 
            // tbxPlayerCount
            // 
            this.tbxPlayerCount.Location = new System.Drawing.Point(207, 227);
            this.tbxPlayerCount.Name = "tbxPlayerCount";
            this.tbxPlayerCount.Size = new System.Drawing.Size(125, 27);
            this.tbxPlayerCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Players";
            // 
            // btnGameSettingConfirm
            // 
            this.btnGameSettingConfirm.Location = new System.Drawing.Point(125, 531);
            this.btnGameSettingConfirm.Name = "btnGameSettingConfirm";
            this.btnGameSettingConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnGameSettingConfirm.TabIndex = 8;
            this.btnGameSettingConfirm.Text = "Confirm";
            this.btnGameSettingConfirm.UseVisualStyleBackColor = true;
            this.btnGameSettingConfirm.Click += new System.EventHandler(this.btnGameSettingConfirm_Click);
            // 
            // FrmTrustGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(792, 603);
            this.Controls.Add(this.panelGameSetting);
            this.Controls.Add(this.lblScoreRank);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.btnBetray);
            this.Controls.Add(this.btnTrust);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.btnGameSetting);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.btnCharaters);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.pbPlayer1);
            this.Name = "FrmTrustGame";
            this.Text = "FrmTrustGame";
            this.Load += new System.EventHandler(this.FrmTrustGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.panelGameSetting.ResumeLayout(false);
            this.panelGameSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnCharaters;
        private System.Windows.Forms.Button btnGameStart;
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
        private System.Windows.Forms.Label lblScoreRank;
        private System.Windows.Forms.Panel panelGameSetting;
        private System.Windows.Forms.TextBox tbxErrorRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPlayerCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxGameCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxInitScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGameSettingConfirm;
    }
}