// S2097
// Program 3
// 4/2/20
// CIS 199-75
// This application calculates the marginal tax rate
// for various candidates' tex plans.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Prog3Form : Form
    {
        public Prog3Form()
        {
            InitializeComponent();
        }

        // User has clicked the Calculate Tax button
        // Will calculate and display their marginal tax rate
        private void calcTaxBtn_Click(object sender, EventArgs e)
        {
            // The marginal tax rates
            // Baseline
            decimal[] BASE_RATE = {.1m, .12m, .22m, .24m, .32m, .35m, .37m}; // array for base rates

            // Candidate 2
            decimal[] C2_RATE = { .1m, .12m, .22m, .24m, .32m, .35m, .4m, .45m, .5m, .52m }; // array for candidate 2 rates

            // Taxable income thresholds for each candidate
            // Baseline
            int[] BASE_THRESH = { 1, 9700, 39475, 84200, 160725, 204100, 510300 }; // array for baseline thresholds

            // Candidate 2
            int[] C2_THRESH = { 1, 9525, 38700, 82500, 157500, 200000, 250000, 500000, 2000000, 10000000 }; // array for candidate 2 thresholds

            int income; // Filer's taxable income (input)

            int baseSub = BASE_THRESH.Length - 1; // helps count array
            int c2Sub = C2_THRESH.Length - 1; // helps count array

            bool corr = false; // value that ensures correct calculation
            


            decimal marginalRate; // Filer's calculated marginal tax rate
            

            if (int.TryParse(incomeTxt.Text, out income) && income >= 0)
            {
                // Which rates/thresholds apply to this filer?
                if (baselineRdoBtn.Checked) // Baseline?
                {
                    while(baseSub >= 0 && !corr)
                    {
                        if (income >= BASE_THRESH[baseSub])
                        {
                            corr = true;
                        }
                        else
                        {
                            --baseSub;
                        }

                    }

                    if(corr)
                    {
                        marginalRate = BASE_RATE[baseSub];
                    }
                    marginalRateOutLbl.Text = $"{BASE_RATE[baseSub]:P1}";



                }
                else // Must be Candidate 2
                {
                    

                    while (c2Sub >= 0 && !corr)
                    {
                        if (income >= C2_THRESH[c2Sub])
                        {
                            corr = true;
                        }
                        else
                        {
                            --c2Sub;
                        }

                    }

                    if (corr)
                    {
                        marginalRate = C2_RATE[c2Sub];
                    }

                    marginalRateOutLbl.Text = $"{C2_RATE[c2Sub]:P1}";
                }



               

            }
            else // Invalid input
                MessageBox.Show("Enter valid income!");
        }
    }
}
