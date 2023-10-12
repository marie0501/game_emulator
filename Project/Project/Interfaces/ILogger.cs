using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{

    public interface ILogger  //represent a type used to log
    {
        void Log(string level,string category, string Info);//generates logs
    }
}
