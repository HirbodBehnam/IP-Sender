using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IP_Sender
{
    static class Helper
    {
        /// <summary>
        /// Returns hashed string
        /// </summary>
        /// <param name="s">The string to hash</param>
        /// <returns></returns>
        /// https://stackoverflow.com/a/14709940/4213397
        public static string SHA256(string s)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(s));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }

    public static class RichTextBoxExtensions
    {
        //https://stackoverflow.com/a/1926822/4213397
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
