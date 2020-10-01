using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalc : Form
    {
        const int OP_NONE = 0;
        const int OP_PLUS = 1;
        const int OP_MINUS = 2;
        const int OP_DIV = 3;
        const int OP_MUL = 4;

        const int OP_EQUAL = 9;

        int op_flag;
        Boolean op_new = false;
        Boolean mem_flag = false;
        decimal x, y, mem;

        KeyHooker keyHooker = new KeyHooker();

        public frmCalc()
        {
            //===========================================================================================
            //===========================================================================================
            InitializeComponent();
            //===========================================================================================
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            x = 0;
            y = 0;
            mem = 0;
            op_flag = OP_NONE;
            op_new = true;

            mem_flag = false;
            cmdMC.Enabled = false;
            cmdMR.Enabled = false;

            cmdDiv.Enabled = false;
            cmdPercent.Enabled = false;
            cmdResiprocal.Enabled = false;
            //===========================================================================================
            keyHooker.HookedKeys.Add(Keys.NumPad0);
            keyHooker.HookedKeys.Add(Keys.NumPad1);
            keyHooker.HookedKeys.Add(Keys.NumPad2);
            keyHooker.HookedKeys.Add(Keys.NumPad3);
            keyHooker.HookedKeys.Add(Keys.NumPad4);
            keyHooker.HookedKeys.Add(Keys.NumPad5);
            keyHooker.HookedKeys.Add(Keys.NumPad6);
            keyHooker.HookedKeys.Add(Keys.NumPad7);
            keyHooker.HookedKeys.Add(Keys.NumPad8);
            keyHooker.HookedKeys.Add(Keys.NumPad9);

            keyHooker.HookedKeys.Add(Keys.D0);
            keyHooker.HookedKeys.Add(Keys.D1);
            keyHooker.HookedKeys.Add(Keys.D2);
            keyHooker.HookedKeys.Add(Keys.D3);
            keyHooker.HookedKeys.Add(Keys.D4);
            keyHooker.HookedKeys.Add(Keys.D5);
            keyHooker.HookedKeys.Add(Keys.D6);
            keyHooker.HookedKeys.Add(Keys.D7);
            keyHooker.HookedKeys.Add(Keys.D8);
            keyHooker.HookedKeys.Add(Keys.D9);

            keyHooker.HookedKeys.Add(Keys.Decimal);
            keyHooker.HookedKeys.Add(Keys.Add);
            keyHooker.HookedKeys.Add(Keys.Subtract);
            keyHooker.HookedKeys.Add(Keys.Divide);
            keyHooker.HookedKeys.Add(Keys.Multiply);

            keyHooker.HookedKeys.Add(Keys.Return);
            //keyHooker.HookedKeys.Add(Keys.Delete);
            //keyHooker.HookedKeys.Add(Keys.Back);

            keyHooker.KeyDown += new KeyEventHandler(keyHooker_KeyDown);
            //===========================================================================================
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            if(txtDisplay.Text == "0")
            {
                cmdDiv.Enabled = false;
                cmdPercent.Enabled = false;
                cmdResiprocal.Enabled = false;
            }
            else
            {
                cmdDiv.Enabled = true;
                cmdPercent.Enabled = true;
                cmdResiprocal.Enabled = true;
            }
            //===========================================================================================
        }

        private void txtDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            //MessageBox.Show(e.KeyCode.ToString());
            //===========================================================================================
        }

        private void cmdZero_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdDZero_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            if ((txtDisplay.Text == "0") || (op_new == true)) txtDisplay.Text = "0";
            else txtDisplay.Text = txtDisplay.Text + "00";

            op_new = false;
            //===========================================================================================
        }

        private void cmdOne_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdTwo_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdThree_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdFour_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdFive_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdSix_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdSeven_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdEight_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdNine_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numeriaclOps(OP_DIV);
            //===========================================================================================
        }

        private void cmdMul_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numeriaclOps(OP_MUL);
            //===========================================================================================
        }

        private void cmdMinus_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numeriaclOps(OP_MINUS);
            //===========================================================================================
        }

        private void cmdPlus_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numeriaclOps(OP_PLUS);
            //===========================================================================================
        }

        private void cmdAC_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            x = 0;
            y = 0;
            txtDisplay.Text = "0";
            mem = 0;
            op_flag = OP_NONE;
            op_new = true;
            //===========================================================================================
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            txtDisplay.Text = "0";
            op_new = true;
            //===========================================================================================
        }

        private void cmdPercent_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            if (txtDisplay.Text != "0")
            {
                txtDisplay.Text = (Convert.ToDecimal(txtDisplay.Text) / 100).ToString();

                op_new = true;
            }
            //===========================================================================================
        }

        private void cmdResiprocal_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            if (txtDisplay.Text != "0")
            {
                txtDisplay.Text = (1 / Convert.ToDecimal(txtDisplay.Text)).ToString();

                op_new = true;
            }
            //===========================================================================================
        }

        private void cmdMPlus_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            mem += Convert.ToDecimal(txtDisplay.Text);

            mem_flag = true;
            cmdMC.Enabled = true;
            cmdMR.Enabled = true;
            //===========================================================================================
        }

        private void cmdMMinus_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            mem -= Convert.ToDecimal(txtDisplay.Text);

            mem_flag = true;
            cmdMC.Enabled = true;
            cmdMR.Enabled = true;
            //===========================================================================================
        }

        private void cmdMR_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            // Memory Recall
            //===========================================================================================
            if (mem_flag == true) txtDisplay.Text = mem.ToString();
            //===========================================================================================
        }

        private void cmdMC_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            // Memory Clear
            //===========================================================================================
            mem = 0;
            txtDisplay.Text = "0";

            mem_flag = false;
            cmdMC.Enabled = false;
            cmdMR.Enabled = false;
            //===========================================================================================
        }

        private void cmdEqual_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            // Equal Button
            //===========================================================================================
            numeriaclOps();

            op_flag = OP_EQUAL;
            op_new = true;
            //===========================================================================================
        }
        
        private void cmdDecimal_Click(object sender, EventArgs e)
        {
            //===========================================================================================
            //===========================================================================================
            numberClicked((sender as Button).Text);
            //===========================================================================================
        }

        private void numberClicked(String number)
        {
            //===========================================================================================
            //===========================================================================================
            if ((txtDisplay.Text == "0") || (op_new == true)) txtDisplay.Text = number;
            else txtDisplay.Text = txtDisplay.Text + number;

            op_new = false;
            //===========================================================================================
        }        

        private void numeriaclOps()
        {
            //===========================================================================================
            //===========================================================================================
            if (op_flag == OP_DIV || op_flag == OP_MUL || op_flag == OP_MINUS || op_flag == OP_PLUS)
            {
                y = Convert.ToDecimal(txtDisplay.Text);

                if (op_flag == OP_DIV) x /= y;
                else if (op_flag == OP_MUL) x *= y;
                else if (op_flag == OP_MINUS) x -= y;
                else if (op_flag == OP_PLUS) x += y;

                txtDisplay.Text = x.ToString();
            }
            //===========================================================================================
        }

        private void numeriaclOps(int opFlag)
        {
            //===========================================================================================
            //===========================================================================================
            if (op_flag == OP_NONE || op_flag == OP_EQUAL)
                x = Convert.ToDecimal(txtDisplay.Text);
            else numeriaclOps();

            op_flag = opFlag;
            op_new = true;
            //===========================================================================================
        }

        void keyHooker_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    numberClicked("0"); break;

                case Keys.NumPad1:
                    numberClicked("1"); break;

                case Keys.NumPad2:
                    numberClicked("2"); break;

                case Keys.NumPad3:
                    numberClicked("3"); break;

                case Keys.NumPad4:
                    numberClicked("4"); break;
                
                case Keys.NumPad5:
                    numberClicked("5"); break;

                case Keys.NumPad6:
                    numberClicked("6"); break;

                case Keys.NumPad7:
                    numberClicked("7"); break;

                case Keys.NumPad8:
                    numberClicked("8"); break;

                case Keys.NumPad9:
                    numberClicked("9"); break;
                //=======================================================================================
                case Keys.D0:
                    numberClicked("0"); break;

                case Keys.D1:
                    numberClicked("1"); break;

                case Keys.D2:
                    numberClicked("2"); break;

                case Keys.D3:
                    numberClicked("3"); break;

                case Keys.D4:
                    numberClicked("4"); break;

                case Keys.D5:
                    numberClicked("5"); break;

                case Keys.D6:
                    numberClicked("6"); break;

                case Keys.D7:
                    numberClicked("7"); break;

                case Keys.D8:
                    numberClicked("8"); break;

                case Keys.D9:
                    numberClicked("9"); break;
                //=======================================================================================
                case Keys.Decimal:
                    numberClicked("."); break;

                case Keys.Return:
                    numeriaclOps();
                    op_flag = OP_EQUAL;
                    op_new = true;
                    break;
                //=======================================================================================
                case Keys.Add:
                    numeriaclOps(OP_PLUS); break;

                case Keys.Subtract:
                    numeriaclOps(OP_MINUS); break;

                case Keys.Divide:
                    numeriaclOps(OP_DIV); break;

                case Keys.Multiply:
                    numeriaclOps(OP_MUL); break;
                //=======================================================================================

            }

            e.Handled = true;
        }
    }
}
