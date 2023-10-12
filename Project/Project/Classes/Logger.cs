using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Logger : ILogger //type used to log
    {
        LoggingForm Form;

        public Logger(LoggingForm form)
        {
            Form = form;
        }
        public void Log(string level,string category, string Info)//generate logs and send them to the LoggingForm
        {
            if (level == "info") Form.Logging(Info,category);
            else MessageBox.Show(Info);
        }
    }
}
