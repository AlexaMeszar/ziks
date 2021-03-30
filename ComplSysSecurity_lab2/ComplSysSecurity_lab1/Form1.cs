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
        public string codedText;

        public Form1()
        {
            InitializeComponent();
        }

        private string codeText(string givenText,string key)
        {
            char[] resultArr = new char[givenText.Length];
            char[] txtArr = givenText.ToCharArray();
            char[] keyArr = key.ToCharArray();

            for (int i = 0; i < givenText.Length; i++)
            {
                int x = i % key.Length;
                char newChar = (char)(txtArr[i]^keyArr[x]);
                resultArr[i] = newChar;
            }

            string result = new string (resultArr);

            return result;
        }

        private string codeKey(string userKey, int lengthOfText)
        {
            int m = int.MaxValue;
            int t = userKey.GetHashCode();
            int a = 10;
            int c = 25;
            char[] resultArr = new char[lengthOfText];

            for (int i = 0; i < lengthOfText; i++)
            {   
                t = (a * t + c) % m;
                resultArr[i] = (char)t;
            }
            string result = new string(resultArr);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = originalTXT.Text;
            string key = keyTXT.Text; 
            codedText = codeText(text, codeKey(key, text.Length));
            codedTXT.Text = codedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = keyTXT.Text;
            decodedTXT.Text = codeText(codedText, codeKey(key, codedText.Length));
        }
    }
}
