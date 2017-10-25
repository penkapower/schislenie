using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Schislenie
{
    public partial class Form1 : Form
    {
        string bukv = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 2;
            numericUpDown1.Maximum = 16;
            numericUpDown1.Value = 10;
            numericUpDown2.Minimum = 2;
            numericUpDown2.Maximum = 16;
            numericUpDown2.Value = 10;
            button1.Enabled = false;
            richTextBox1.Visible = false;
            button3.Visible = false;
            panel1.Visible = false;
            textBox4.KeyPress += (sender, e) => e.Handled = true;
            textBox3.KeyPress += (sender, e) => e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
        private string ToN(string number, string sys)
        {
            string newNum = "";
            int num = Convert.ToInt32(number);
            int chast = Convert.ToInt32(number);
            ArrayList numTemp = new ArrayList();
            while(chast>0)
            {
                chast = chast / Convert.ToInt32(sys);
                numTemp.Add(num - chast * Convert.ToInt32(sys));
                num = chast;
            }
            int j;
            for (j=numTemp.Count-1; j >= 0; j--)
                newNum += newCh(numTemp[j].ToString(),"to");
            return newNum;
        }
        string newCh(string sym,string otk)
        {
            string s = "";
            if (otk == "to")
            {
                if (Convert.ToInt32(sym) > 10)
                    s += bukv.Substring(Convert.ToInt32(sym) - 10, 1);
                else
                    s += sym;
            }
            else if (otk == "from")
            {
                if (bukv.IndexOf(sym)==-1)
                    s += sym;
                else
                    s += (bukv.IndexOf(sym) + 10).ToString();
            }
            return s;
        }
        private string FromN(string number, string sys)
        {
            int newNum = 0;
            string temp = "";
            int t;
            int i;
            for (i = 0; i < number.Length; i++)
            {
                temp = "";
                temp += newCh(number.Substring(i, 1), "from");
                t=(int)Math.Pow(Convert.ToDouble(sys),Convert.ToDouble(number.Length-(i+1)));
                newNum += Convert.ToInt32(temp) * t;
            }
            return newNum.ToString();
        }
        private string FromTo(string number, string sysN, string sysK)
        {
            string temp="";
            temp=FromN(number, sysN);
            temp = ToN(temp, sysK);
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Поле пустое!");
                button1.Enabled = false;
                return;
            }
            else
            {
                if (numericUpDown1.Value == 2 && numericUpDown2.Value == 2)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 3 && numericUpDown2.Value == 3)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 4 && numericUpDown2.Value == 4)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 5 && numericUpDown2.Value == 5)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 6 && numericUpDown2.Value == 6)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 7 && numericUpDown2.Value == 7)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 8 && numericUpDown2.Value == 8)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 9 && numericUpDown2.Value == 9)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 10 && numericUpDown2.Value == 10)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 11 && numericUpDown2.Value == 11)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 12 && numericUpDown2.Value == 12)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 13 && numericUpDown2.Value == 13)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 14 && numericUpDown2.Value == 14)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 15 && numericUpDown2.Value == 15)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                if (numericUpDown1.Value == 16 && numericUpDown2.Value == 16)
                {
                    textBox2.Text = textBox1.Text;
                    File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox1.Text + " (" + numericUpDown1.Value + ")\n");
                    button1.Enabled = false;
                }
                else {
                    if (numericUpDown1.Value == 10 && numericUpDown2.Value != 10)
                    {
                        textBox2.Text = ToN(textBox1.Text, numericUpDown2.Value.ToString());
                        File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox2.Text + " (" + numericUpDown2.Value + ")\n");
                        button1.Enabled = false;
                    }
                    else
                    {
                        if (numericUpDown2.Value == 10 && numericUpDown1.Value != 10)
                        {
                            textBox2.Text = FromN(textBox1.Text, numericUpDown1.Value.ToString());
                            File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox2.Text + " (" + numericUpDown2.Value + ")\n");
                            button1.Enabled = false;
                        }
                        else
                        {
                            if (numericUpDown2.Value != 10 && numericUpDown1.Value != 10)
                            {
                                textBox2.Text = FromTo(textBox1.Text, numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString());
                                File.AppendAllText("history.txt", textBox1.Text + " (" + numericUpDown1.Value + ")" + " ----------> " + textBox2.Text + " (" + numericUpDown2.Value + ")\n");
                                button1.Enabled = false;
                            }
                        }
                    }
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (numericUpDown1.Value == 2)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 50) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 3)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 51) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 4)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 52) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 5)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 53) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 6)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 54) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 7)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 55) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 8)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 56) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 9)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 57) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 10)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 11)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar <= 64 || e.KeyChar >= 66))
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 12)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar <= 64 || e.KeyChar >= 67))
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 13)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar <= 64 || e.KeyChar >= 68))
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 14)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar <= 64 || e.KeyChar >= 69))
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 15)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar <= 64 || e.KeyChar >= 70))
                    e.Handled = true;
            }
            if (numericUpDown1.Value == 16)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar <= 64 || e.KeyChar >= 71))
                    e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Visible = false;
                button3.Visible = false;
            }
            else
            {
                button3.Visible = true;
                richTextBox1.Visible = true;
                 richTextBox1.Text = File.ReadAllText("history.txt");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("history.txt","");
            richTextBox1.Text = File.ReadAllText("history.txt");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("1. Выберете начальную систему счислениея\n2. Введите данные в поле ввода\n3. Нажмите кнопку 'Перевести'\n4. Для просмотра истории переводов нажмите кнопку 'История'", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult f1 = MessageBox.Show("Версия программы 1.5.2\n\nВеремейко Роман","О программе",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
