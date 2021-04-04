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
        public char[] alphabet;

        public Form1()
        {
            InitializeComponent();
            alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        }

        private string codeText(string givenText,string key)
        {
            char[] resultArr = new char[givenText.Length];
            char[] txtArr = givenText.ToCharArray();
            char[] keyArr = key.ToCharArray();

            for (int i = 0; i < givenText.Length; i++)
            {
                int newIndex = (getCharPos(txtArr[i]).Item1 + getCharPos(keyArr[i]).Item1) % alphabet.Length;
                char newChar = getCharForIndex(newIndex);

                resultArr[i] = newChar;
            }

            string result = new string (resultArr);

            return result;
        }

        private string decodeText(string givenText, string key)
        {
            char[] resultArr = new char[givenText.Length];
            char[] txtArr = givenText.ToCharArray();
            char[] keyArr = key.ToCharArray();

            for (int i = 0; i < givenText.Length; i++)
            {
                int newIndex = (getCharPos(txtArr[i]).Item1 - getCharPos(keyArr[i]).Item1 + 26) % alphabet.Length;
                char newChar = getCharForIndex(newIndex);

                resultArr[i] = newChar;
            }

            string result = new string(resultArr);

            return result;
        }

        private string editKey(string userKey, int lengthOfText)
        {
            char[] keyArr = userKey.ToCharArray();
            char[] resultArr = new char[lengthOfText];

            for (int i = 0; i < lengthOfText; i++)
            {
                int x = i % userKey.Length;
                resultArr[i] = keyArr[x];
            }
            string result = new string(resultArr);
            return result;


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
            string key = keyTXT.Text;
            codedText = codeText(text, editKey(key, text.Length));
            codedTXT.Text = codedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = keyTXT.Text;
            decodedTXT.Text = decodeText(codedText, editKey(key, codedText.Length));
        }
    }
}
