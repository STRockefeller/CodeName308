using CodeName308.Characters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeName308.Views
{
    public partial class FrmCharacterDetail : Form
    {
        ICharacter character;
        public FrmCharacterDetail(ICharacter character)
        {
            InitializeComponent();
            this.character = character;
            if (this.CanFocus) { this.Focus(); }
        }

        private void FrmCharacterDetail_Load(object sender, EventArgs e)
        {
            lblDetail.Text = character.GetTrustGameCharaters().Description();
        }

        private void btnClose_Click(object sender, EventArgs e) => Hide();

        private void FrmCharacterDetail_KeyDown(object sender, KeyEventArgs e) => Hide();
    }
}
