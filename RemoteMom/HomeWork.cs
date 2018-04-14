using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMom
{
    class HomeWork
    {
        public string HomeworkName { get; set; }
        public DateTime TimeAllocated { get; set; }
        public DateTime SubmissionDateTime { get; set; }
        public DateTime DayofCompletion { get; set; }
        public string Resources { get; set; }
        public string AssociatedClass { get; set; }
        public DateTime AssociatedClassDateTime { get; set; }
    }
}
