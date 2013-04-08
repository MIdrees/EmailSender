using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmailSender
{
    internal static class MessageForm
    {
        internal static DialogResult Information(string text)
        {
            return MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static DialogResult Error(Exception ex)
        {
            return MessageForm.Error(ex.Message);
        }

        internal static DialogResult Error(string text)
        {
            return MessageBox.Show("Error occurred: " + text, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static DialogResult YesNo(string text)
        {
            return MessageBox.Show(text, "Confirmation", MessageBoxButtons.YesNo);
        }        
    }
}
