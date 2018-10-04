using FormLoginEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormLoginEstoque;

namespace SlideMenu
{
    public partial class SlideMenu : Form
    {
        public SlideMenu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close(); //closses form
        }

        private void btnMnu_Click(object sender, EventArgs e)
        {

            if (sidemenu.Width == 50)
            {
                //EXPAND
                //1. Expand the panel, w = 260
                //2. Show logo
                sidemenu.Visible = false;
                sidemenu.Width = 260;
                PanelAnimator.ShowSync(sidemenu);
                LogoAnimator.ShowSync(logo);
            }
            else
            {
                //MINIMIZE
                //using bunifu animator
                //1. Hide the logo
                //2. Slide the panel
                LogoAnimator.Hide(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 50;
                PanelAnimator.ShowSync(sidemenu);

            }



        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            BodyMain.Controls.Clear();
            UserCadControl cadMed = new UserCadControl();
            BodyMain.Controls.Add(cadMed);
            cadMed.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            BodyMain.Controls.Clear();
            UserSearchControl consultarMed = new UserSearchControl();
            BodyMain.Controls.Add(consultarMed);
            consultarMed.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            BodyMain.Controls.Clear();
            UserAskForControl solicitarMed = new UserAskForControl();
            BodyMain.Controls.Add(solicitarMed);
            solicitarMed.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            BodyMain.Controls.Clear();
            UserOrdersControl listarPedidosMed = new UserOrdersControl();
            BodyMain.Controls.Add(listarPedidosMed);
            listarPedidosMed.Show();
        }
    }
}
