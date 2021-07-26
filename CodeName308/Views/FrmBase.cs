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
using CodeName308.Views;
using CodeName308.Storage;

namespace CodeName308
{
    public partial class FrmBase : Form
    {
        private FrmBase_Article _article;

        public FrmBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 文章初始化
        /// Storage初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBase_Load(object sender, EventArgs e)
        {
            _article = new FrmBase_Article();
            tbxMessage.Text = _article.Show();
            StorageHandler.NameStorage = new InitializationNameStorage();
            StorageHandler.NameStorage = StorageHandler.NameStorage.JsonDeserialize();
        }

        private void NextStory(KeyEventArgs e)
        {
            if (e.KeyValue == 39)
            {
                tbxMessage.Text = _article.Next();
            }
        }

        private void FrmBase_KeyDown(object sender, KeyEventArgs e)
        {
            NextStory(e);
        }

        private void tbxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            NextStory(e);
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            FrmInitialization frm = new FrmInitialization();
            frm.Show();
        }

        private void btnTrustGame_Click(object sender, EventArgs e)
        {
            FrmTrustGame frm = new FrmTrustGame();
            frm.Show();
        }
    }
}