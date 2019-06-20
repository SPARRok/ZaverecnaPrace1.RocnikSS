using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnaPrace_MykytaVorobiov
{
    public partial class Calc_ZAE_ohm : Form
    {
        public Calc_ZAE_ohm()
        {
            InitializeComponent();
        }

        //Deklarace
        #region
        double U, I, R;
        #endregion

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert U, I, R
                #region
                U = 0;
                R = 0;
                I = 0;

                U = Convert.ToDouble(txtU.Text);
                I = Convert.ToDouble(txtI.Text);
                R = Convert.ToDouble(txtR.Text);
                #endregion
            }
            catch
            {

            }

            try
            {
                //vypocet
                #region
                if(U>0 && I>0 && R>0)
                {
                    MessageBox.Show("...ehm. A co mám počítat?");
                }
                else
                {
                    if (U > 0)
                    {
                        if (I > 0)
                        {
                            R = U / I;
                            MessageBox.Show("Odpor = " + R.ToString() + " Ω");

                        }

                        else if (R > 0)
                        {
                            I = U / R;
                            MessageBox.Show("El. Proud = " + I.ToString() + " A");
                        }


                    }

                    else if (R > 0)
                    {
                        if (U > 0)
                        {
                            I = U / R;
                            MessageBox.Show("El. Proud = " + I.ToString() + " A");
                        }
                        else if (I > 0)
                        {
                            U = I * R;
                            MessageBox.Show("Napětí = " + U.ToString() + " V");
                        }
                    }

                    else if (I > 0)
                    {
                        if (R > 0)
                        {
                            U = R * I;
                            MessageBox.Show("Napětí = " + U.ToString() + " V");
                        }
                        else if (U > 0)
                        {
                            R = U / I;
                            MessageBox.Show("Odpor = " + R.ToString() + " Ω");

                        }
                    }
                }
                #endregion
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
