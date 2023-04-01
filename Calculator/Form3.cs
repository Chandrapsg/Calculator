using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator
{
    
    public partial class Form3 : Form
    {
        public static int historyFlag = 1;
        public static int MemoryFlag = 1;
        int addflag = 0;
        int subflag = 0;
        int mulflag = 0;
        int divflag= 0;
        int perflag = 0;
        Double onebyx = 0;
        double lastno = 0;
        int plucnt = 0;
        String firstno = string.Empty;
        String Buttonpress = String.Empty;
        Double text2 = 0;
        double mod = 0;
        

        public Form3()
        {
            InitializeComponent();
          
        }


        private void buttonhistory_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);

            if (historyFlag == 2)
            {
                panelhistory.Visible = false;
                panelMR.Visible = true;
                historyFlag = 1;
            }
            else
            {
                panelhistory.Visible = true;
                panelMR.Visible = false;
               // richTextBox1.Text = "There's no history yet";
                historyFlag = 2;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
           
            if((textBox2.Text=="0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "1";
                text2 = 1;
            }
            else
            {

                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "1";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "1";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "2";
                text2 = 2;
            }
            else
            {  
                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "2";
                    text2 = double.Parse(textBox2.Text);
                }
                if(textBox2.Text.Contains(".") )
                {
                    textBox2.Text = textBox2.Text + "2";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "3";
                text2 = 3;
            }
            else
            {

                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "3";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "3";
                    text2 = double.Parse(textBox2.Text);
                }

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "6";
                text2 = 6;
            }
            else
            {
                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "6";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "6";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "5";
                text2 = 5;
            }
            else
            {

                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "5";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "5";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "4";
                text2 = 4;
            }
            else
            {
                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "4";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "4";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "9";
                text2 = 9;
            }
            else
            {
                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "9";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "9";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "8";
                text2 = 8;
            }
            else
            {
                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "8";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "8";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "7";
                text2 = 7;
            }
            else
            {
                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "7";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "7";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Buttonpress = btn.Name;
          
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "0" ;
                textBox1.Text = "0" + "+";
            }
            else
            {
                switch (textBox1.Text)
                {
                    case "0-":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "+";
                        break;
                    case "0*":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "+";
                        break;
                    case "0/":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "+";
                        break;
                    case "0-0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "+";
                        break;
                    case "0*0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "+";
                        break;
                    default:
                        if (textBox1.Text.Contains("="))
                        {
                            textBox1.Text = Global.Result + "+";
                            textBox2.Text = Global.Result.ToString();
                            addflag = 1;
                        }
                        else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("+"))
                        {
                            textBox1.Text = textBox1.Text;
                            textBox2.Text = textBox2.Text;
                        }
                        else if (textBox1.Text.Contains(")") && !textBox1.Text.Contains("+"))
                        {
                            textBox1.Text = textBox1.Text + "+";
                            textBox2.Text = Global.Result.ToString();
                        }
                        else if ((addflag == 0) && textBox2.Text != "")
                        {
                            Global.Result = Global.Result + Double.Parse(textBox2.Text);
                            textBox1.Text = Global.Result + "+";
                            textBox2.Text = Global.Result.ToString();
                            addflag = 1;
                        }
                        
                            break;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Buttonpress = btn.Name;
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "0";
                textBox1.Text = "0" + "-";
            }
            else
            { 
                switch(textBox1.Text) { 
                    case "0+":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "-";
                        break;
                    case "0*":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "-";
                        break;
                    case "0/":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "-";
                        break;
                    case "0+0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "-";
                        break;
                    case "0*0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "-";
                        break;
                    default:
                        if (textBox1.Text == "")
                        {
                            textBox1.Text = textBox2.Text + "-";
                            Global.Result = Double.Parse(textBox2.Text);
                        }
                        else if (textBox1.Text.Contains("="))
                        {
                            textBox1.Text = Global.Result + "-";
                            textBox2.Text = Global.Result.ToString();
                            subflag = 1;
                        }
                        else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("-"))
                        {
                            textBox1.Text = textBox1.Text;
                            textBox2.Text = textBox2.Text;
                        }
                        else if (textBox1.Text.Contains(")") && !textBox1.Text.Contains("-"))
                        {
                            textBox1.Text = textBox1.Text + "-";
                            textBox2.Text = Global.Result.ToString();
                        }
                        else if ((subflag == 0) && (textBox2.Text != ""))
                        {
                            Global.Result = Global.Result - Double.Parse(textBox2.Text);
                            textBox1.Text = Global.Result + "-";
                            textBox2.Text = Global.Result.ToString();
                            subflag = 1;
                        }

                      
                        break;
                }
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Buttonpress = btn.Name;
           
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "0";
                textBox1.Text = "0" + "*";
            }
            else
            {
                switch (textBox1.Text)
                {
                    case "0-":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "*";
                        break;
                    case "0+":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "*";
                        break;
                    case "0/":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "*";
                        break;
                    case "0-0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "*";
                        break;
                    case "0+0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "*";
                        break;
                    default:

                        if(textBox1.Text=="")
                        {
                            Global.Result = 1;
                        }
                        if ( textBox1.Text.Contains("="))
                        {
                            textBox1.Text = Global.Result + "*";
                            textBox2.Text = Global.Result.ToString();
                            mulflag = 1;
                        }else
                        {
                            if((mulflag == 0) && textBox2.Text != "")
                            {
                                Global.Result = Global.Result * Double.Parse(textBox2.Text);
                                textBox1.Text = Global.Result + "*";
                                textBox2.Text = Global.Result.ToString();
                                mulflag = 1;
                            }
                           
                        }
                     
                        break;

                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Buttonpress = btn.Name;
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {  
                textBox2.Text = "0";
                textBox1.Text = "0" + "/";
            }
            else
            {
                switch (textBox1.Text)
                {
                    case "0-":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "/";
                        break;
                    case "0-0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "/";
                        break;

                    case "0*":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "/";
                        break;
                    case "0*0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "/";
                        break;
                    case "0+":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "/";
                        break;
                    case "0+0=":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "/";
                        break;
                    default:
                        
                        if (textBox1.Text == "")
                        {
                            Global.Result = 1;
                        }
                        if (textBox1.Text.Contains("="))
                        {
                            textBox1.Text = Global.Result + "/";
                            textBox2.Text = Global.Result.ToString();
                            divflag = 1;
                        }
                        else
                        {
                            if ((divflag == 0) && textBox2.Text !="" )
                            {
                                Global.Result = Global.Result * Double.Parse(textBox2.Text);
                                textBox1.Text = Global.Result + "/";
                                textBox2.Text = Global.Result.ToString();
                                divflag = 1;
                            }

                        }

                        
                        break;
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            text2 = 0;
            textBox1.Text = "";
            textBox2.Text= "0";
            Global.Result = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("hi");
           if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "0";
                textBox1.Text = "0" + "=";
            }
            else
            {
                switch (textBox1.Text)
                {
                    case "0-":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "-" + "0"+ "=";
                        break;
                    case "0*":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "*"+ "0" + "="; 
                        break;
                    case "0+":
                        textBox2.Text = "";
                        textBox2.Text = "0";
                        textBox1.Text = "0" + "+" +"0" + "="; 
                        break;
                    case "0/":
                        textBox2.Text = "Result is undefined";
                        textBox1.Text = "0" + "/"; 
                        break;
                    default:
                       
                        switch (Buttonpress)
                        {
                            case "button27":
                                MessageBox.Show("hi");
                                break;
                            case "button12":
                                if (perflag == 1)
                                {
                                    textBox1.Text = firstno + "+" + mod + "=";
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("=") && textBox1.Text.Contains("+"))
                                {
                                    textBox1.Text = Global.Result +"+"+ text2.ToString() + "=";
                                    Global.Result = Global.Result + text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("+"))
                                {
                                    textBox1.Text = textBox1.Text + text2.ToString() + "=";
                                    Global.Result = Global.Result + text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else
                                {
                                    textBox1.Text = Global.Result + "+" + text2.ToString() + "=";
                                    Global.Result = Global.Result + text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                break;
                           case "button16":
                                if (perflag == 1)
                                {
                                    textBox1.Text = firstno + "-" + mod + "=";
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("=") && textBox1.Text.Contains("-"))
                                {
                                    textBox1.Text = Global.Result + "-" + text2.ToString() + "=";
                                    Global.Result = Global.Result - text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("-"))
                                {
                                    textBox1.Text = textBox1.Text + text2.ToString() + "=";
                                    Global.Result = Global.Result - text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else
                                {
                                    textBox1.Text = Global.Result + "-" + text2.ToString() + "=";
                                    Global.Result = Global.Result - text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                break;
                            case "button20":
                                if (perflag == 1)
                                {
                                    textBox1.Text = firstno + "*" + mod + "=";
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("=") && textBox1.Text.Contains("*"))
                                {
                                    textBox1.Text = Global.Result + "*" + text2.ToString() + "=";
                                    Global.Result = Global.Result * text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("*"))
                                {
                                    textBox1.Text = textBox1.Text + text2.ToString() + "=";
                                    Global.Result = Global.Result * text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                else
                                {
                                    textBox1.Text = Global.Result + "*" + text2.ToString() + "=";
                                    Global.Result = Global.Result * text2;
                                    textBox2.Text = Global.Result.ToString();
                                }
                                break;
                          
                            case "button24":
                                if (textBox2.Text == "0")
                                {
                                    textBox2.Text = "Cannot divide by zero";
                                }
                                else
                                {
                                    if (perflag == 1)
                                    {
                                        textBox1.Text = firstno + "/" + mod + "=";
                                        textBox2.Text = Global.Result.ToString();
                                    }
                                    else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("=") && textBox1.Text.Contains("/"))
                                    {
                                        textBox1.Text = Global.Result + "/" + text2.ToString() + "=";
                                        Global.Result = Global.Result / text2;
                                        textBox2.Text = Global.Result.ToString();
                                    }
                                    else if (textBox1.Text.Contains(")") && textBox1.Text.Contains("/"))
                                    {
                                        textBox1.Text = textBox1.Text + text2.ToString() + "=";
                                        Global.Result = Global.Result / text2;
                                        textBox2.Text = Global.Result.ToString();
                                    }
                                    else
                                    {
                                        textBox1.Text = Global.Result + "/" + text2.ToString() + "=";
                                        Global.Result = Global.Result / text2;
                                        textBox2.Text = Global.Result.ToString();
                                    }
                                }
                                break;
                            case "equal":
                                if (textBox1.Text.Contains(")") && textBox1.Text.Contains("+"))
                                {
                                    textBox1.Text = Global.Result + Buttonpress + text2.ToString() + "=";
                                }
                                switch (Buttonpress)
                                {
                                    
                                    case "button12":
                                        if (textBox1.Text.Contains(")") && textBox1.Text.Contains("+"))
                                        {
                                            textBox1.Text = Global.Result + text2.ToString() + "=";
                                            Global.Result = Global.Result + text2;
                                            textBox2.Text = Global.Result.ToString();
                                        }
                                        else
                                        {
                                            Global.Result = Global.Result + text2;
                                            textBox2.Text = Global.Result.ToString();
                                        }
                                        
                                        break;
                                    case "button16":
                                        Global.Result = Global.Result - text2;
                                        textBox2.Text = Global.Result.ToString();
                                        break;
                                    case "button11":
                                        textBox2.Text = textBox1.Text;
                                        textBox1.Text = textBox2.Text + "=";
                                       
                                        break;
                                    case "button20":
                                        Global.Result = Global.Result * double.Parse(textBox2.Text) ;
                                        textBox2.Text = Global.Result.ToString();
                                        break;
                                    case "button24":
                                        Global.Result = Global.Result / text2;
                                        textBox2.Text = Global.Result.ToString();
                                        break;
                                }
                                break;
                            case "0*":
                                textBox2.Text = "";
                                textBox2.Text = "0";
                                textBox1.Text = "0" + "*" + "0" + "=";
                                break;
                            case "0+":
                                textBox2.Text = "";
                                textBox2.Text = "0";
                                textBox1.Text = "0" + "+" + "0" + "=";
                                break;
                            case "0/":
                                textBox2.Text = "Result is undefined";
                                textBox1.Text = "0" + "/";
                                break;
                            default:
                                textBox1.Text = textBox2.Text + "=";
                                break;
                        }
                        break;
                }
            }
            perflag = 0;
            richTextBox1.Text = richTextBox1.Text + textBox1.Text +"\n"+textBox2.Text +"\n\n\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "0";
                textBox1.Text = "";
            }
            else
            {
                if(textBox2.Text != "")
                {
                    textBox1.Text = "";
                    if (textBox2.Text.Substring(0, 1) == "-")
                    {
                        temp = textBox2.Text.Substring(1, textBox2.Text.Length - 1);
                        textBox2.Text = temp;
                    }
                    else
                    {
                        temp = textBox2.Text;
                        textBox2.Text = "-" + temp;
                    }
                }
            
            }

        }

        private void button12_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                text2 = Double.Parse(textBox2.Text);
                textBox2.Text = "";
                addflag = 0;
            }
        }
        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("="))
            {
                textBox1.Text = "";
                textBox2.Text = "0";
            }
            else
            textBox2.Text = "0";
        }

        private void button16_Leave(object sender, EventArgs e)
        {
            textBox2.Text = "";
            subflag = 0;
        }

        private void button20_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text !="")
            {
                text2 = Double.Parse(textBox2.Text);
                textBox2.Text = "";
                mulflag = 0;
            }
        }

        private void button24_Leave(object sender, EventArgs e)
        {
            textBox2.Text = "";
            divflag = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "0";
                text2 = 0;
            }
            else
            {

                if (textBox2.Text.All(char.IsDigit))
                {
                    textBox2.Text = textBox2.Text + "0";
                    text2 = double.Parse(textBox2.Text);
                }
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + "0";
                    text2 = double.Parse(textBox2.Text);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "";
                textBox2.Text = "0.";
                text2 = 0;
            }
          
            else
            {
                if(text2 == 0)
                {
                    textBox2.Text = textBox2.Text;
                    if (textBox2.Text.All(char.IsDigit) && textBox2.Text != "")
                    {
                        text2 = double.Parse(textBox2.Text);
                    }
                }
                else
                {
                    
                    if (textBox2.Text.All(char.IsDigit) && textBox2.Text != "" )
                    {
                        if(textBox2.Text.Contains("."))
                        {
                            text2 = double.Parse(textBox2.Text) ;
                        }
                        else
                        {
                            textBox2.Text = textBox2.Text + ".";
                            
                        }
                        
                    }
                }
            }
        }

        private void button10_Leave(object sender, EventArgs e)
        {

            if (text2 == 0)
                textBox2.Text = "0.";
            else
            {
                textBox2.Text = text2.ToString() + ".";
            }
        }

        private void button10_Enter(object sender, EventArgs e)
        {
            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            perflag = 1;

            if (textBox1.Text == "0")
            {
                textBox2.Text = "0";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
            }
           
            switch (Buttonpress)
            {
                case "button12":
                    if (textBox2.Text.All(char.IsDigit) && textBox2.Text != "")
                    {
                        firstno = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        mod = (double.Parse(firstno) * double.Parse(textBox2.Text)) / 100;
                        textBox1.Text = Global.Result + "+" + mod.ToString();
                        Global.Result = Global.Result + mod;
                        textBox2.Text = mod.ToString();
                    }   
                    break;
                case "button16":
                    if (textBox2.Text.All(char.IsDigit) && textBox2.Text != "")
                    {   
                        firstno = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        mod = (double.Parse(firstno) * double.Parse(textBox2.Text)) / 100;
                        textBox1.Text = Global.Result + "-" + mod.ToString();
                        Global.Result = Global.Result - mod;
                        textBox2.Text = mod.ToString();
                    }
                    break;
                case "button20":
                    firstno = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    mod =text2 / 100;
                    textBox1.Text = Global.Result + "*" + mod.ToString();
                    Global.Result = Global.Result * mod;
                    textBox2.Text = mod.ToString();
                    break;
                case "button24":
                    firstno = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    mod = text2 / 100;
                    if (textBox2.Text == "0")
                    {
                        textBox2.Text = "Cannot divide by zero";
                    }
                    else
                    {
                        textBox1.Text = Global.Result + "/" + mod.ToString();
                        Global.Result = Global.Result / mod;
                        textBox2.Text = mod.ToString();
                        break;
                    }
                    break;
            }
        }

        private void button31_Leave(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length ==1 )
            {
                textBox2.Text = "0";
            }
            if (textBox1.Text.Contains("="))
            {
                textBox1.Text = "";
            }
            else if(textBox1.Text == "" && textBox2.Text.Length > 1)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            else
            {
                if (!textBox2.Text.Contains("="))
                {
                    textBox2.Text = "0";
                }

            }
           

        }

        private void button27_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "Cannot divide by zero";
                textBox1.Text = "1/(0)";
                text2 = 6;
            }
            else
            {
                if(textBox2.Text != "")
                {
                    Global.Result = 1 / (double.Parse(textBox2.Text));
                    textBox1.Text = "1" + "/" + "(" + textBox2.Text + ")";
                    textBox2.Text = Global.Result.ToString();
                }
                
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "0";
            }
            else
            {
                if(textBox2.Text != "")
                {
                    Global.Result = double.Parse(textBox2.Text) * double.Parse(textBox2.Text);
                    textBox1.Text = "sqr(" + textBox2.Text + ")";
                    textBox2.Text = Global.Result.ToString();
                }
            }

        }

        private void button26_Leave(object sender, EventArgs e)
        {
            if ((textBox2.Text != ""))
            {
                text2 = Double.Parse(textBox2.Text);
                textBox2.Text = "";
                addflag = 0;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") && (textBox1.Text == string.Empty))
            {
                textBox2.Text = "0";
            }
            else
            {
                if(textBox2.Text != "")
                {
                    Global.Result = Math.Sqrt(double.Parse(textBox2.Text));
                    textBox1.Text = "/(" + textBox2.Text + ")";
                    textBox2.Text = Global.Result.ToString();
                }
            }
        }

        private void button25_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                text2 = Double.Parse(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void button30_Leave(object sender, EventArgs e)
        {
            text2 = Double.Parse(textBox2.Text);
            textBox2.Text = "";
        }

        private void button28_Leave(object sender, EventArgs e)
        {
            text2 = Double.Parse(textBox2.Text);
            textBox2.Text = "";
        }

        private void buttondelhis_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            richTextBox1.Text = "There's no history yet";
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }
    }
    class Global
    {
        public static double Result = 0;

    }
}
