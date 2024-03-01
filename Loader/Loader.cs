using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace FirstCsharpGUI
{
    public partial class Loader : Form
    {
        //rounded edges for GUI 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        // moveabable panel
        bool mouseDown;
        private Point offset;

        private Form activeform = null;

        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDescription.Controls.Add(childForm);
            pnlDescription.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public void startGame()
        {
            //games
            GUI.Games.Recoilscript recoilscritUI = new GUI.Games.Recoilscript();
            // check for lblgame status for gui execution

            if (lblgameselection.Text == "Recoilscript")
            {
                recoilscritUI.Show();
                this.Hide();
            }

        }
        public Loader()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Descriptions.Recoil());
            lblgameselection.Text = "Recoilscript";
            btnStart.BringToFront();
            btnStart.Location = new Point(290, 250);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundedPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundedPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            startGame();
        }

        private void pnlSelection_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }

        private void pnlSelection_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnlSelection_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
