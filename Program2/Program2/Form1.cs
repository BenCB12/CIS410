// S2097
// Program 2
// Due 3/5/20
// CIS 199-75
// Create a program that takes entered income and a sslected tax plan adn gives the user their tax due and tax rate
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // When clicked, this button calculates the tax due and tax rate based on entered income and selected tax plan and displays them in the appropiate spots
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int income; // user entered income
            bool select; // determines if income is of valid number
            const int LOW_INCOME = 0; // minimum possible income
            const int bInc1 = 9700, bInc2 = 39475, bInc3 = 84200, bInc4 = 160725, bInc5 = 204100, bInc6 = 510300; // tax bracket cutoffs for baseline plan
            const double bRate1 = .1, bRate2 = .12, bRate3 = .22, bRate4 = .24, bRate5 = .32, bRate6 = .35, bRate7 = .37; // tax bracket percentages for baseline plan
            const double can1Rate1 = .1, can1Rate2 = .15, can1Rate3 = .25, can1Rate4 = .28, can1Rate5 = .33, can1Rate6 = .35, can1Rate7 = .396; // tax bracket percentages for candadate 1 and 3
            const int can1Inc1 = 9525, can1Inc2 = 38700, can1Inc3 = 82500, can1Inc4 = 157500, can1Inc5 = 200000, can1Inc6 = 500000; // tax bracket cutoffs for candidate 1 and 3
            const double can2Rate1 = .1, can2Rate2 = .12, can2Rate3 = .22, can2Rate4 = .24, can2Rate5 = .32, can2Rate6 = .35, can2Rate7 = .4, can2Rate8 = .45, can2Rate9 = .5, can2Rate10 = .52; // tax bracket percentages for candidate 2
            const int can2Inc1 = 9525, can2Inc2 = 38700, can2Inc3 = 82500, can2Inc4 = 157500, can2Inc5 = 200000, can2Inc6 = 250000, can2Inc7 = 500000, can2Inc8 = 2000000, can2Inc9 = 10000000; // tax bracket cutoffs for candidate 2
            double taxRate, taxDue; // total tax due and max tax rate of entered income
            const double can3Reduc = .9; // reduction for candidate 3 in income over $200,000
            const double can2IRate = .04; // increase in tax for those over the threshold of income
            const int can2IInc = 29000; // threshold of income for increased tax

            select = int.TryParse(incomeTxt.Text, out income);
            taxDue = 0;
            taxRate = 0;

            if (select && income >= LOW_INCOME)
            {
                if (baselineRadio.Checked)
                {
                    if (income > bInc1)
                    {
                        taxDue = bRate1 * bInc1;

                        if (income > bInc2)
                        {
                            taxDue = taxDue + bRate2 * (bInc2 - bInc1);

                            if (income > bInc3)
                            {
                                taxDue = taxDue + bRate3 * (bInc3 - bInc2);

                                if (income > bInc4)
                                {
                                    taxDue = taxDue + bRate4 * (bInc4 - bInc3);

                                    if (income > bInc5)
                                    {
                                        taxDue = taxDue + bRate5 * (bInc5 - bInc4);

                                        if (income > bInc6)
                                        {
                                            taxDue = taxDue + bRate6 * (bInc6 - bInc5);
                                            taxDue = taxDue + bRate7 * (income - bInc6);
                                            taxRate = bRate7;
                                        }
                                        else
                                        {
                                            taxDue = taxDue + bRate6 * (income - bInc5);
                                            taxRate = bRate6;
                                        }
                                    }
                                    else
                                    {
                                        taxDue = taxDue + bRate5 * (income - bInc4);
                                        taxRate = bRate5;
                                    }
                                }
                                else
                                {
                                    taxDue = taxDue + bRate4 * (income - bInc3);
                                    taxRate = bRate4;
                                }
                            }
                            else
                            {
                                taxDue = taxDue + bRate3 * (income - bInc2);
                                taxRate = bRate3;
                            }
                        }
                        else
                        {
                            taxDue = taxDue + bRate2 * (income - bInc1);
                            taxRate = bRate2;
                        }
                    }
                    else
                    {
                        taxDue = bRate1 * income;
                        taxRate = bRate1;
                    }
                }
                    if (candidate1Radio.Checked)
                    {
                        if (income > can1Inc1)
                        {
                            taxDue = can1Rate1 * can1Inc1;

                            if (income > can1Inc2)
                            {
                                taxDue = taxDue + can1Rate2 * (can1Inc2 - can1Inc1);

                                if (income > can1Inc3)
                                {
                                    taxDue = taxDue + can1Rate3 * (can1Inc3 - can1Inc2);

                                    if (income > can1Inc4)
                                    {
                                        taxDue = taxDue + can1Rate4 * (can1Inc4 - can1Inc3);

                                        if (income > can1Inc5)
                                        {
                                            taxDue = taxDue + can1Rate5 * (can1Inc5 - can1Inc4);

                                            if (income > can1Inc6)
                                            {
                                                taxDue = taxDue + can1Rate6 * (can1Inc6 - can1Inc5);
                                                taxDue = taxDue + can1Rate7 * (income - can1Inc6);
                                                taxRate = can1Rate7;
                                            }
                                            else
                                            {
                                                taxDue = taxDue + can1Rate6 * (income - can1Inc5);
                                                taxRate = can1Rate6;
                                            }
                                        }
                                        else
                                        {
                                            taxDue = taxDue + can1Rate5 * (income - can1Inc4);
                                            taxRate = can1Rate5;
                                        }
                                    }
                                    else
                                    {
                                        taxDue = taxDue + can1Rate4 * (income - can1Inc3);
                                        taxRate = can1Rate4;
                                    }
                                }
                                else
                                {
                                    taxDue = taxDue + can1Rate3 * (income - can1Inc2);
                                    taxRate = can1Rate3;
                                }
                            }
                            else
                            {
                                taxDue = taxDue + can1Rate2 * (income - can1Inc1);
                                taxRate = can1Rate2;
                            }
                        }
                        else
                        {
                            taxDue = can1Rate1 * income;
                            taxRate = can1Rate1;
                        }

                        
                    }
                if (candidate3Radio.Checked)
                {
                    if (income > can1Inc1)
                    {
                        taxDue = can1Rate1 * can1Inc1 * can3Reduc;

                        if (income > can1Inc2)
                        {
                            taxDue = taxDue + (can1Rate2 * (can1Inc2 - can1Inc1) * can3Reduc);

                            if (income > can1Inc3)
                            {
                                taxDue = taxDue + (can1Rate3 * (can1Inc3 - can1Inc2) * can3Reduc);

                                if (income > can1Inc4)
                                {
                                    taxDue = taxDue + (can1Rate4 * (can1Inc4 - can1Inc3) * can3Reduc);

                                    if (income > can1Inc5)
                                    {
                                        taxDue = taxDue + (can1Rate5 * (can1Inc5 - can1Inc4) * can3Reduc);

                                        if (income > can1Inc6)
                                        {
                                            taxDue = taxDue + can1Rate6 * (can1Inc6 - can1Inc5);
                                            taxDue = taxDue + can1Rate7 * (income - can1Inc6);
                                            taxRate = can1Rate7;
                                        }
                                        else
                                        {
                                            taxDue = taxDue + can1Rate6 * (income - can1Inc5);
                                            taxRate = can1Rate6;
                                        }
                                    }
                                    else
                                    {
                                        taxDue = taxDue + (can1Rate5 * (income - can1Inc4) * can3Reduc);
                                        taxRate = can1Rate5;
                                    }
                                }
                                else
                                {
                                    taxDue = taxDue + (can1Rate4 * (income - can1Inc3) * can3Reduc);
                                    taxRate = can1Rate4;
                                }
                            }
                            else
                            {
                                taxDue = taxDue + (can1Rate3 * (income - can1Inc2) * can3Reduc);
                                taxRate = can1Rate3;
                            }
                        }
                        else
                        {
                            taxDue = taxDue + (can1Rate2 * (income - can1Inc1) * can3Reduc);
                            taxRate = can1Rate2;
                        }
                    }
                    else
                    {
                        taxDue = can1Rate1 * income * can3Reduc;
                        taxRate = can1Rate1;
                    }


                }
                if (candidate2Radio.Checked)
                {
                    if (income > can2Inc1)
                    {
                        taxDue = can2Rate1 * can2Inc1;

                        if (income > can2Inc2)
                        {
                            taxDue = taxDue + can2Rate2 * (can2Inc2 - can2Inc1);

                            if (income > can2Inc3)
                            {
                                taxDue = taxDue + can2Rate3 * (can2Inc3 - can2Inc2);

                                if (income > can2Inc4)
                                {
                                    taxDue = taxDue + can2Rate4 * (can2Inc4 - can2Inc3);

                                    if (income > can2Inc5)
                                    {
                                        taxDue = taxDue + can2Rate5 * (can2Inc5 - can2Inc4);

                                        if (income > can2Inc6)
                                        {
                                            taxDue = taxDue + can2Rate6 * (can2Inc6 - can2Inc5);

                                            if (income > can2Inc7)
                                            {
                                                taxDue = taxDue + can2Rate7 * (can2Inc7 - can2Inc6);

                                                if (income > can2Inc8)
                                                {
                                                    taxDue = taxDue + can2Rate8 * (can2Inc8 - can2Inc7);

                                                    if (income > can2Inc9)
                                                    {
                                                        taxDue = taxDue + can2Rate9 * (can2Inc9 - can2Inc8);
                                                        taxDue = taxDue + can2Rate10 * (income - can2Inc9);
                                                        taxRate = can2Rate10;
                                                    }
                                                    else
                                                    {
                                                        taxDue = taxDue + can2Rate9 * (income - can2Inc8);
                                                        taxRate = can2Rate9;
                                                    }
                                                }
                                                else
                                                {
                                                    taxDue = taxDue + can2Rate8 * (income - can2Inc7);
                                                    taxRate = can2Rate8;
                                                }
                                            }
                                            else
                                            {
                                                taxDue = taxDue + can2Rate7 * (income - can2Inc6);
                                                taxRate = can2Rate7;
                                            }
                                        }
                                        else
                                        {
                                            taxDue = taxDue + can2Rate6 * (income - can2Inc5);
                                            taxRate = can2Rate6;
                                        }
                                    }
                                    else
                                    {
                                        taxDue = taxDue + can2Rate5 * (income - can2Inc4);
                                        taxRate = can2Rate5;
                                    }
                                }
                                else
                                {
                                    taxDue = taxDue + can2Rate4 * (income - can2Inc3);
                                    taxRate = can2Rate4;
                                }
                            }
                            else
                            {
                                taxDue = taxDue + can2Rate3 * (income - can2Inc2);
                                taxRate = can2Rate3;
                            }
                        }
                        else
                        {
                            taxDue = taxDue + can2Rate2 * (income - can2Inc1);
                            taxRate = can2Rate2;
                        }
                    }
                    else
                    {
                        taxDue = can2Rate1 * income;
                        taxRate = can2Rate1;
                    }
                    if (income > can2IInc)
                    {
                        taxDue = taxDue + ((income - can2IInc) * can2IRate);
                    }
                }
                taxRateLabel2.Text = ($"{taxRate:p}");
                taxDueLabel2.Text = ($"{taxDue:c}");







            }
        }
    }   }
