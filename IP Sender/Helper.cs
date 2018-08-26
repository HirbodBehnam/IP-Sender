using System.Drawing;
using System.Security.Principal;
using System.ServiceProcess;
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
        /// <summary>
        /// Check if service exists
        /// </summary>
        /// <param name="serviceName">Name of service</param>
        /// <returns></returns>
        public static bool ServiceExists(string Name)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
                if (service.ServiceName == Name)
                    return true;
            return false;
        }
        /// <summary>
        /// Check if program is running as admin
        /// </summary>
        /// <returns></returns>
        /// https://stackoverflow.com/a/11660205/4213397
        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }

    public static class RichTextBoxExtensions
    {
        //https://stackoverflow.com/a/1926822/4213397
        /// <summary>
        /// Append a text with color to a RichTextBox
        /// </summary>
        /// <param name="box">The RechTextBox</param>
        /// <param name="text">Text to append</param>
        /// <param name="color">Color of text</param>
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
    public static class TextBoxExtension
    {
        /// <summary>
        /// Checks if textbox text is empty
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool Empty(this TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }
    }
    public static class StringExrension
    {
        /// <summary>
        /// Because I'm lazy
        /// </summary>
        /// <param name="str">The string to check</param>
        /// <returns></returns>
        public static bool Empty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}
