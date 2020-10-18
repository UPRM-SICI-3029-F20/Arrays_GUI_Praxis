using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_GUI_Praxis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //                 1    2    3   // Bedrooms 
        int[,] rents = { {400, 450, 510},       // City A
                             {500, 560, 630 },      // City B
                             {625, 676, 740 },      // City C
                             {1000, 1250, 1600} };  // City D

        private void LblOutput_Click(object sender, EventArgs e)
        {
            ////                 1    2    3   // Bedrooms 
            //int[,] rents = { {400, 450, 510},       // City A
            //                 {500, 560, 630 },      // City B
            //                 {625, 676, 740 },      // City C
            //                 {1000, 1250, 1600} };  // City D

            int r = 0, c = 0;

            if (RadCityA.Checked) r = 0;
            if (RadCityB.Checked) r = 1;
            if (RadCityC.Checked) r = 2;
            if (RadCityD.Checked) r = 3;

            if (RadBR1.Checked) c = 0;
            if (RadBR2.Checked) c = 1;
            if (RadBR3.Checked) c = 2;

            LblOutput.Text = "The rent is: " +  rents[r,c];

        }

        private void RadCityA_CheckedChanged(object sender, EventArgs e)
        {
            Display_Rent();
        }

        private void RadCityB_CheckedChanged(object sender, EventArgs e)
        {
            Display_Rent();
        }

        private void RadCityC_CheckedChanged(object sender, EventArgs e)
        {
            Display_Rent();
        }

        private void RadCityD_CheckedChanged(object sender, EventArgs e)
        {
            Display_Rent();
        }

        private void RadBR1_CheckedChanged(object sender, EventArgs e)
        {
            Display_Rent();
        }

        private void RadBR2_CheckedChanged(object sender, EventArgs e)
        {
            Display_Rent();
        }

        private void RadBR3_CheckedChanged(object sender, EventArgs e)
        {
            Display_Rent();
        }

        private void Display_Rent()
        {
            ////                 1    2    3   // Bedrooms 
            //int[,] rents = { {400, 450, 510},       // City A
            //                 {500, 560, 630 },      // City B
            //                 {625, 676, 740 },      // City C
            //                 {1000, 1250, 1600} };  // City D

            int r = 0, c = 0;

            if (RadCityA.Checked) r = 0;
            if (RadCityB.Checked) r = 1;
            if (RadCityC.Checked) r = 2;
            if (RadCityD.Checked) r = 3;

            if (RadBR1.Checked) c = 0;
            if (RadBR2.Checked) c = 1;
            if (RadBR3.Checked) c = 2;

            LblOutput.Text = "The rent is: " + rents[r, c];

        }
    }
}
