using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SHA1_MD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnSHA1Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSHA1Ascii.Text);
        }

        private void btnSHA1ReplacedCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSHA1ReplacedAscii.Text);
        }

        private void btnMD5Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxMD5Ascii.Text);
        }

        private void btnMD5ReplacedCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxMD5ReplacedAscii.Text);
        }
        Sha1 sha1 = new Sha1();
        Md5 md5 = new Md5();
        private void btnSHA1ASCII_Click(object sender, EventArgs e)
        {
            
            textBoxSHA1Ascii.Text = sha1.GetSHA1ASCII(textBoxInput.Text);
            textBoxSHA1ReplacedAscii.Text = sha1.GetSHA1ReplaceASCII(textBoxInput.Text);
        }

        private void btnSHA1Unicode_Click(object sender, EventArgs e)
        {
            textBoxSHA1Unicode.Text = sha1.GetSHA1Unicode(textBoxInput.Text);
            textBoxSHA1ReplacedUnicode.Text = sha1.GetSHA1ReplaceUnicode(textBoxInput.Text);
        }

        private void btnMD5Ascii_Click(object sender, EventArgs e)
        {
            textBoxMD5Ascii.Text = md5.GetMD5Ascii(textBoxInput.Text);
            textBoxMD5ReplacedAscii.Text = md5.GetMD5AsciiReplaced(textBoxInput.Text);
        }

        private void btnMD5Unicode_Click(object sender, EventArgs e)
        {
            textBoxMD5Unicode.Text = md5.GetMD5Unicode(textBoxInput.Text);
            textBoxMD5ReplacedUnicode.Text = md5.GetMD5UnicodeReplaced(textBoxInput.Text);
        }

        private void btnGenerateAll_Click(object sender, EventArgs e)
        {
            btnSHA1ASCII.PerformClick();
            btnSHA1Unicode.PerformClick();
            btnMD5Unicode.PerformClick();
            btnMD5Ascii.PerformClick();
        }
    }
}
