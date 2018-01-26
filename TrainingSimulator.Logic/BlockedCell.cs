using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSimulator.Logic
{
    public class BlockedCell
    {
        public virtual bool? IsBlocked { get; set; }
        public virtual int? Row { get; set; }
        public virtual int? Column { get; set; }
    }
}
