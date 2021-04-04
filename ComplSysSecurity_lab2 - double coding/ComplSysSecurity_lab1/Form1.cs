using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplSysSecurity_lab1
{
    public partial class Form1 : Form
    {
        public char[] alphabet;

        public Form1()
        {
            InitializeComponent();
            alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray(); 
        }

        private string codeText(string text)
        {
            string[] codedStrArr = new string[text.Length];
            string[] strArr = text.ToCharArray().Select(c => c.ToString()).ToArray();
            int key = Convert.ToInt32(keyBox.Value);
            char codedC;

            for (int i = 0; i < text.Length; i++)
            {
                char c = Convert.ToChar(strArr[i]);
                if ((c == ' ') || (c == ',' ) || (c == '.'))
                {
                    codedC = c;
                }
                else
                {
                    Tuple<int, bool> tuple = getCharPos(c);
                    if (tuple.Item2 == false)
                    {
                        MessageBox.Show("Error occured!");
                        break;
                    }
                    codedC = getCharForIndex((tuple.Item1 + key * 2));
                }             
                
                codedStrArr[i] = codedC.ToString();
            }

            string codedText = string.Join("", codedStrArr);

            return codedText;
        }

        private string decodeText(string text)
        {
            string[] decodedStrArr = new string[text.Length];
            string[] strArr = text.ToCharArray().Select(c => c.ToString()).ToArray();
            int key = Convert.ToInt32(keyBox.Value);
            char decodedC;

            for (int i = 0; i < text.Length; i++)
            {
                char c = Convert.ToChar(strArr[i]);
                if ((c == ' ') || (c == ',') || (c == '.'))
                {
                    decodedC = c;
                }
                else
                {
                    Tuple<int, bool> tuple = getCharPos(c);
                    if (tuple.Item2 == false)
                    {
                        MessageBox.Show("Error occured!");
                        break;
                    }

                    int y = (tuple.Item1 - key);

                    if (y < 0)
                    {
                        decodedC = getCharForIndex(alphabet.Count() + y);
                    }
                    else
                    {
                        decodedC = getCharForIndex((tuple.Item1 - key * 2));
                    }                    
                }

                decodedStrArr[i] = decodedC.ToString();
            }

            string decodedText = string.Join("", decodedStrArr);

            return decodedText;
        }

        private Tuple<int, bool> getCharPos(char c)
        {
            int index = 0;
            bool found = false;
            for (int i = 0; i < alphabet.Count(); i++)
            {
                char compare = alphabet[i];
                if (compare == char.ToLower(c))
                {
                    index = i;
                    found = true;
                }
            }
            return Tuple.Create(index, found);
        }

        private char getCharForIndex(int index)
        {
            int x = index % alphabet.Count();
            char c = alphabet[x];
            return c; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = originalTXT.Text;
            codedTXT.Text = codeText(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = codedTXT.Text;
            decodedTXT.Text = decodeText(text);
        }
    }
}
