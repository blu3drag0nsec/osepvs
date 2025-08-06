using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XORme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte[] ParseInput(string input)
        {
            var cleaned = input.Replace("byte[] buf =", "")
                               .Replace("{", "")
                               .Replace("}", "")
                               .Replace(";", "")
                               .Replace("\n", "")
                               .Replace("\r", "")
                               .Trim();
            int newByteIndex = cleaned.IndexOf("new byte[");
            if (newByteIndex != -1)
            {
                int closingBracket = cleaned.IndexOf(']', newByteIndex);
                if (closingBracket != -1)
                {
                    cleaned = cleaned.Remove(newByteIndex, (closingBracket - newByteIndex) + 1);
                }
            }

            var bytes = cleaned.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return bytes.Select(b => Convert.ToByte(b.Replace("0x", ""), 16)).ToArray();
        }

        private string FormatCSharp(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"byte[] buf = new byte[{data.Length}] {{");
            for (int i = 0; i < data.Length; i++)
            {
                sb.AppendFormat("0x{0:x2}", data[i]);
                if (i != data.Length - 1) sb.Append(", ");
                if ((i + 1) % 15 == 0) sb.AppendLine();
            }
            sb.AppendLine("};");
            return sb.ToString();
        }

        private string FormatVBA(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dim buf As Variant");
            int counter = 0;
            foreach (var b in data)
            {
                sb.Append($"{b}, ");
                counter++;
                if (counter % 25 == 0) sb.AppendLine("_");
            }
            return sb.ToString();
        }
        private byte[] ParseKey(string keyInput)
        {
            if (string.IsNullOrWhiteSpace(keyInput))
                throw new ArgumentException("Key cannot be empty.");

            var bytes = keyInput.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return bytes.Select(b => Convert.ToByte(b, 16)).ToArray();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] inputBytes = ParseInput(txSource.Text);                
                byte[] keyBytes = ParseKey(txXORKey.Text);

                byte[] result = new byte[inputBytes.Length];
                for (int i = 0; i < inputBytes.Length; i++)
                {
                    result[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
                }

                txDestination.Text = FormatCSharp(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnV_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] inputBytes = ParseInput(txSource.Text);
                byte[] keyBytes = ParseKey(txXORKey.Text);

                byte[] result = new byte[inputBytes.Length];
                for (int i = 0; i < inputBytes.Length; i++)
                {
                    result[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
                }

                txDestination.Text = FormatVBA(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
