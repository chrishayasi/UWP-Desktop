using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Desktop.Model
{
    public class CmbModel
    {
        public string Code {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string CodeAndName
        {
            get { return Code + ":" + Name; }
        }

    }
}
