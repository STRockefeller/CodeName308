using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeName308.Text;
using CodeName308.Games.TrustGame;
using CodeName308.Characters.TrustGameCharaters;
using CodeName308.Characters;

namespace CodeName308.Views
{
    public partial class FrmTrustGame : Form
    {
        private FrmTrustGame_Article article;
        private PlayerManagement playerManagement;
        private TrustGame game;
        private GameSetting setting;

        /// <summary>
        /// 遊戲中判斷
        /// </summary>
        private bool isGaming;

        /// <summary>
        /// 賽局計次
        /// </summary>
        private int gameCount;

        public FrmTrustGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 隱藏部分項目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTrustGame_Load(object sender, EventArgs e)
        {
            article = new FrmTrustGame_Article();
            tbxMessage.Text = article.Show();
            isGaming = false;
            btnTrust.Visible = false;
            btnBetray.Visible = false;
            lblPlayer1Score.Visible = false;
            lblPlayer2Score.Visible = false;
            lblPlayer1Name.Visible = false;
            lblPlayer2Name.Visible = false;
            lblTurn.Visible = false;
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            btnGameSetting.Visible = false;
            btnGameStart.Visible = false;
            btnCharaters.Visible = false;
            btnTutorial.Visible = false;
            tbxMessage.Text = article.Show(("tutorial", 0));
        }

        private void tbxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (isGaming) { KeyDownInGame(e); }
            else { KeyDownNotInGame(e); }
            
        }
        /// <summary>
        /// 遊戲中動作
        /// </summary>
        /// <param name="e"></param>
        private void KeyDownInGame(KeyEventArgs e)
        {
            if (game.CurrentPhase() != EnumGamePhase.Strategy) { return; }
            switch (e.KeyValue)
            {
                case 38:
                    SelectTrust();
                    break;

                case 40:
                    SelectBetray();
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// 遊戲外動作
        /// </summary>
        /// <param name="e"></param>
        private void KeyDownNotInGame(KeyEventArgs e)
        {
            (string, int) key = article.GetKey();
            switch (key.Item1)
            {
                case "tutorial":
                    TutorialMessageHandler(key.Item2, e);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 處理Tutorial文章顯示部分
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="e"></param>
        private void TutorialMessageHandler(int keyId, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 37:
                    tbxMessage.Text = keyId > 0 ? article.Show(("tutorial", keyId - 1)) : tbxMessage.Text;
                    break;

                case 39:
                    tbxMessage.Text = keyId < 2 ? article.Show(("tutorial", keyId + 1)) : tbxMessage.Text;
                    if (keyId == 2)
                        TutorialGame01();
                    else if (keyId == 3)
                        TutorialGameStandard(2,new User_TG(),new Betrayer_TG()); //第二場教學賽局，對手為Betrayer
                    else if (keyId == 4)
                        TutorialGameStandard(3, new Betrayer_TG(), new King80_TG()); //第三場教學賽局，對手為King80
                    else if (keyId == 5)
                        TutorialGameStandard(4, new King80_TG(), new Anti80_TG()); //第四場教學賽局，對手為Anti80
                    else if (keyId == 6)
                        TutorialGameStandard(5, new Anti80_TG(), new LionKing_TG()); //第五場教學賽局，對手為LionKing
                    else if (keyId == 7)
                        TutorialGameStandard(6, new LionKing_TG(), new Chaos_TG()); //第六場教學賽局，對手為Chaos
                    else if (keyId == 8)
                        TutorialGameStandard(7, new Chaos_TG(), new NiceMan_TG()); //第七場教學賽局，對手為NiceMan
                    else if (keyId == 9)
                        TutorialGameStandard(8, new NiceMan_TG(), new Conspirator_TG()); //第八場教學賽局，對手為Conspirator
                    break;
                case 38:
                    FrmCharacterDetail detail;
                    switch (keyId)
                    {
                        case 3:
                            detail = new FrmCharacterDetail(new User());
                            detail.Show();
                            break;
                        case 4:
                            detail = new FrmCharacterDetail(new Betrayer());
                            detail.Show();
                            break;
                        case 5:
                            detail = new FrmCharacterDetail(new King80());
                            detail.Show();
                            break;
                        case 6:
                            detail = new FrmCharacterDetail(new Anti80());
                            detail.Show();
                            break;
                        case 7:
                            detail = new FrmCharacterDetail(new LionKing());
                            detail.Show();
                            break;
                        case 8:
                            detail = new FrmCharacterDetail(new Chaos());
                            detail.Show();
                            break;
                        case 9:
                            detail = new FrmCharacterDetail(new NiceMan());
                            detail.Show();
                            break;
                        case 10:
                            detail = new FrmCharacterDetail(new Conspirator());
                            detail.Show();
                            break;
                        default:
                            break;
                    }
                    break;
                case 40:
                    if (keyId >= 7)
                    {
                        FrmTrustGame trustGame = new FrmTrustGame();
                        trustGame.Show();
                        this.Dispose(false);
                    }    
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 第一場教學賽局，對手是user
        /// </summary>
        private void TutorialGame01()
        {
            isGaming = true;
            gameCount = 1;
            setting = new GameSetting();
            setting.UseDefault();
            setting.ErrorRate = 0;
            setting.GameCount = 3;
            playerManagement = new PlayerManagement(setting);
            playerManagement.AddPlayer(new User_TG());
            playerManagement.AddNPC(new User_TG());
            GameStatus status = new GameStatus(playerManagement.Players[0], playerManagement.Players[1]);
            game = new TrustGame(status);
            game.GameType = EnumTrustGameType.Tutorial01;
            SetImage();
            game.ToPhase(EnumGamePhase.Match);
            game.ToPhase(EnumGamePhase.Strategy);
            ShowScore();
            lblPlayer1Name.Text = game.GetName().Item1;
            lblPlayer2Name.Text = game.GetName().Item2;
            lblPlayer1Name.Visible = true;
            lblPlayer2Name.Visible = true;
            tbxMessage.Text = "歡迎進入教學模式第一關" +
                "\r\n您的第一個對手已經就位" +
                "\r\n現在請選擇您的策略" +
                "\r\n您也可以透過[方向鍵上]選擇合作/[方向鍵下]選擇背叛";
            btnBetray.Visible = true;
            btnTrust.Visible = true;
        }
        /// <summary>
        /// 標準教學賽局
        /// </summary>
        /// <param name="count">場次</param>
        /// <param name="Player1"></param>
        /// <param name="Player2"></param>
        private void TutorialGameStandard(int count,TrustGameCharatersBase Player1,TrustGameCharatersBase Player2)
        {
            isGaming = true;
            gameCount = 1;
            setting = new GameSetting();
            setting.UseDefault();
            playerManagement = new PlayerManagement(setting);
            playerManagement.AddPlayer(Player1);
            playerManagement.AddNPC(Player2);
            GameStatus status = new GameStatus(playerManagement.Players[0], playerManagement.Players[1]);
            game = new TrustGame(status);
            game.GameType = (EnumTrustGameType)count;
            SetImage();
            game.ToPhase(EnumGamePhase.Match);
            game.ToPhase(EnumGamePhase.Strategy);
            ShowScore();
            lblPlayer1Name.Text = game.GetName().Item1;
            lblPlayer2Name.Text = game.GetName().Item2;
            lblPlayer1Name.Visible = true;
            lblPlayer2Name.Visible = true;
            tbxMessage.Text = $"歡迎進入教學模式第{count}關" +
                $"\r\n您的第{count}個對手已經就位" +
                "\r\n現在請選擇您的策略" +
                "\r\n您也可以透過[方向鍵上]選擇合作/[方向鍵下]選擇背叛";
            btnBetray.Visible = true;
            btnTrust.Visible = true;
        }

        private void SetImage()
        {
            pbPlayer1.ImageLocation = game.GetImagePath().Item1;
            pbPlayer2.ImageLocation = game.GetImagePath().Item2;
        }
        /// <summary>
        /// 同一個對手重複進行賽局
        /// </summary>
        private void GameLoop()
        {
            game.ToPhase(EnumGamePhase.Strategy);
            tbxMessage.Text += "\r\n請選擇您的策略";
        }

        private void EndGame()
        {
            isGaming = false;
            switch (game.GameType)
            {
                case EnumTrustGameType.Tutorial01:
                    tbxMessage.Text = article.Show(("tutorial", 3));
                    break;
                case EnumTrustGameType.Tutorial02:
                    tbxMessage.Text = article.Show(("tutorial", 4));
                    break;
                case EnumTrustGameType.Tutorial03:
                    tbxMessage.Text = article.Show(("tutorial", 5));
                    break;
                case EnumTrustGameType.Tutorial04:
                    tbxMessage.Text = article.Show(("tutorial", 6));
                    break;
                case EnumTrustGameType.Tutorial05:
                    tbxMessage.Text = article.Show(("tutorial", 7));
                    break;
                case EnumTrustGameType.Tutorial06:
                    tbxMessage.Text = article.Show(("tutorial", 8));
                    break;
                case EnumTrustGameType.Tutorial07:
                    tbxMessage.Text = article.Show(("tutorial", 9));
                    break;
                case EnumTrustGameType.Tutorial08:
                    tbxMessage.Text = article.Show(("tutorial", 10));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 合作動作
        /// </summary>
        private void SelectTrust()
        {
            if (game.CurrentPhase() != EnumGamePhase.Strategy) { return; }
            tbxMessage.Text += "\r\n您選擇信任對方";
            var result = game.SetPlayer1Strategy(EnumTrustGameStrategy.Cooperate);
            if (result.Item1)
                tbxMessage.Text += "\r\n但是出了點意外，最終您執行了背叛動作";
            NPCStrategyPick();
        }

        /// <summary>
        /// 背叛動作
        /// </summary>
        private void SelectBetray()
        {
            if (game.CurrentPhase() != EnumGamePhase.Strategy) { return; }
            tbxMessage.Text += "\r\n您選擇背叛對方";
            var result = game.SetPlayer1Strategy(EnumTrustGameStrategy.Betray);
            if (result.Item1)
                tbxMessage.Text += "\r\n但是出了點意外，最終您與對方進行合作";
            NPCStrategyPick();
        }

        /// <summary>
        /// NPC策略選擇環節
        /// </summary>
        private void NPCStrategyPick()
        {
            EnumTrustGameStrategy npcStrategy = game.SetPlayer2NPCStrategy();
            tbxMessage.Text += npcStrategy == EnumTrustGameStrategy.Cooperate ?
                "\r\n您的對手選擇與您合作" : "\r\n您的對手選擇背叛";
            game.GameResult(setting);
            SetImage();
            game.ToPhase(EnumGamePhase.Result);
            game.ToPhase(EnumGamePhase.End);
            var score = game.ShowScore();
            tbxMessage.Text += $"\r\n您與對手的第{gameCount}場賽局已完成";
            ShowScore();
            if (gameCount < setting.GameCount)
            {
                gameCount++;
                GameLoop();
            }
            else
                EndGame();
        }

        private void ShowScore()
        {
            var score = game.ShowScore();
            lblPlayer1Score.Visible = true;
            lblPlayer2Score.Visible = true;
            lblTurn.Visible = true;
            lblPlayer1Score.Text = score.Item1.ToString();
            lblPlayer2Score.Text = score.Item2.ToString();
            lblTurn.Text = gameCount.ToString();
        }

        private void btnTrust_Click(object sender, EventArgs e) => SelectTrust();

        private void btnBetray_Click(object sender, EventArgs e) => SelectBetray();
    }
}