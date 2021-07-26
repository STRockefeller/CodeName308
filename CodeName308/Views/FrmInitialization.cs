using System;
using System.Windows.Forms;
using CodeName308.Storage;

namespace CodeName308.Views
{
    public partial class FrmInitialization : Form
    {
        public FrmInitialization()
        {
            InitializeComponent();
            SetForm();
        }

        private void SetForm()
        {
            tbxUser.Text = StorageHandler.NameStorage.User;
            tbxAnti80.Text = StorageHandler.NameStorage.Anti80;
            tbxBetrayer.Text = StorageHandler.NameStorage.Betrayer;
            tbxConspirator.Text = StorageHandler.NameStorage.Conspirator;
            tbxKing80.Text = StorageHandler.NameStorage.King80;
            tbxLionKing.Text = StorageHandler.NameStorage.LionKing;
            tbxNiceMan.Text = StorageHandler.NameStorage.NiceMan;
            tbxRandom.Text = StorageHandler.NameStorage.Random;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StorageHandler.NameStorage.User = tbxUser.Text;
            StorageHandler.NameStorage.Anti80 = tbxAnti80.Text;
            StorageHandler.NameStorage.Betrayer = tbxBetrayer.Text;
            StorageHandler.NameStorage.Conspirator = tbxConspirator.Text;
            StorageHandler.NameStorage.King80 = tbxKing80.Text;
            StorageHandler.NameStorage.LionKing = tbxLionKing.Text;
            StorageHandler.NameStorage.NiceMan = tbxNiceMan.Text;
            StorageHandler.NameStorage.Random = tbxRandom.Text;
            StorageHandler.NameStorage.JsonSerialize();
            this.Hide();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            StorageHandler.NameStorage.UseDefault();
            SetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}