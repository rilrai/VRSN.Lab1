using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Form {
    class ThreadSwitch {
        public ThreadController Controller { get; set; }

        public ThreadSwitch(ThreadController controller) {
            Controller = controller;
        }

        public void ChangeStatus(bool flag) {
            Controller.ThreadStatusChangedEvent(flag);
        }
    }
}
