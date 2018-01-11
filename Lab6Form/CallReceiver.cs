namespace Lab6Form {
    public class CallReceiver {
        public delegate void CallReceivedDelegate(Call call);

        public event CallReceivedDelegate CallReceived;

        public void CallReceivedEvent(Call call) {
            CallReceived?.Invoke(call);
        }
    }
}
