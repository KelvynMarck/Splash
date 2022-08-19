using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Splash
{
    public partial class Form1 : Form

    {

        //Creando el metodo

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundReactRgn

             (
                 int nLeftRect,
                 int nTopRect,
                 int RightReact,
                 int nBottomRect,
                 int nWidthEllipse,
                 int nHeightEllipse
             );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundReactRgn(0, 0, Width, Height, 25, 25));
            ProgressBar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString();

            if (ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Marck marck_form = new Marck();
                marck_form.Show();
                this.Hide();
            }
        }
    }
}
