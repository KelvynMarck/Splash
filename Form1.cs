using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Splash
{
    public partial class Form1 : Form

    {

        //Creando el metodo
        [DllImport("Gdi32.d11", EntryPoint = "CreateRoundRectRgn")]

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
