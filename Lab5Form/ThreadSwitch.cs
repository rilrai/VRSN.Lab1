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