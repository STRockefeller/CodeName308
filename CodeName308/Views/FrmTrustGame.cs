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

namespace CodeName308.Views
{
    public partial class FrmTrustGame : Form
    {
        private FrmTrustGame_Article article;
        private PlayerManagement playerManagement;
        private TrustGame game;
        public FrmTrustGame()
        {
            InitializeComponent();
        }

        private void FrmTrustGame_Load(object sender, EventArgs e)
        {
            article = new FrmTrustGame_Article();
            tbxMessage.Text = article.Show();
            btnTrust.Visible = false;
            btnBetray.Visible = false;
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            btnGameSetting.Visible = false;
            btnSandBox.Visible = false;
            btnStory.Visible = false;
            btnTutorial.Visible = false;
            tbxMessage.Text = article.Show(("tutorial", 0));
        }

        private void tbxMessage_KeyDown(object sender, KeyEventArgs e)
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
            playerManagement = new PlayerManagement();
            playerManagement.AddPlayer(new User_TG());
            playerManagement.AddNPC(new User_TG());
            GameStatus status = new GameStatus(playerManagement.Players[0], playerManagement.Players[1]);
            game = new TrustGame(status);
            game.ToPhase(EnumGamePhase.Strategy);
            tbxMessage.Text = "請選擇策略";
            btnBetray.Visible = true;
            btnTrust.Visible = true;
        }
    }
}