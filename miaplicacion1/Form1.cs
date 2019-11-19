using System;
using System.Windows.Forms;

namespace miaplicacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mensaje = textBox1.Text;
            Boolean ismessage = checkBoxMessage.Checked;
            Boolean iserror = checkBoxError.Checked;
            Boolean iswarning = checkBoxWarning.Checked;
            Boolean toconsole = checkBoxToConsole.Checked;
            Boolean tofile = checkBoxToFile.Checked;
            Boolean todatabase = checkBoxToDatabase.Checked;

            JobLogger jobLogger = new JobLogger(tofile,toconsole,todatabase,ismessage,iswarning,iserror);
            JobLogger.LogMessage(mensaje, ismessage, iswarning, iserror);
        }

       
    }
}
