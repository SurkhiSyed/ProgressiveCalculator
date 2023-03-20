//Syed Kaab Surkhi
//March 13, 2023
//Mr. A. Mayer
//A simple calculator through Windows Forms App
using System;
using System.Windows.Forms;

namespace C_SharpCalculator
{
    public partial class IntroScreen : Form
    {

        public IntroScreen()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e) //If Start button is clicked
        {
            this.Close(); //Close this form
            new Complex_Calculator().Show(); //Show the main Calculator screen
        }

        private void IntroScreen_Load(object sender, EventArgs e) //When this screen (Start screen) loads
        {
            new Complex_Calculator().Hide(); //Hide the main Calculator screen
        }
    }
}
