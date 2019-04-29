/*
 * Created by: AllanL
 * Created on: April 6, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - 2D Arrays
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DArraysAllanL
{
    public partial class frm2DArrays : Form
    {
        public frm2DArrays()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int width;
            int length;
            Random randomNumberGenerator = new Random();
            int aRandomNumber;
            string aPieceOfText = null;

            width = Convert.ToInt16(this.nudWidth.Value);
            length = Convert.ToInt16(this.nudLength.Value);

            int[,] a2DArray = new int[width, length];

            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    aRandomNumber = randomNumberGenerator.Next(0, 9 + 1);
                    a2DArray[widthCounter, lengthCounter] = aRandomNumber;
                    aPieceOfText = aPieceOfText + " " + aRandomNumber;
                }

                aPieceOfText = aPieceOfText + "\r" + "\n";
            }
            this.txtArray.Text = aPieceOfText;
        }
    }
}
