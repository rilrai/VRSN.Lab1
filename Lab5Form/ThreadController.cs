using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Form {
    class ThreadController {
        public delegate void ThreadControllerDelegate(bool flag);

        public event ThreadControllerDelegate ThreadStatusChanged;

        public void ThreadStatusChangedEvent(bool flag) {
            ThreadStatusChanged?.Invoke(flag);
        }
    }
}
