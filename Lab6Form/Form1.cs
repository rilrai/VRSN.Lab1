using System;
using System.Windows.Forms;

namespace Lab6Form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            mobile.Receiver.CallReceived += OnCallReceived;

            Contact petya = new Contact("Petya", "0937564741");
            Contact masha = new Contact("Masha", "0971234567", "0507654321");

            mobile.ContactList.Add(petya);
            mobile.ContactList.Add(masha);
        }

        static MobileLab6 mobile = new MobileLab6(new CallReceiver());

        private CallFactory callFactory = new CallFactory(mobile);

        private void button1_Click(object sender, EventArgs e) {
            if (!callFactory.CallSenderOn) {
                if (!callFactory.IsCallSenderAlive()) {
                    callFactory.StartSender();
                }
                callFactory.CallSenderOn = true;
                button1.Text = "Make it stop!";
            }
            else {
                callFactory.CallSenderOn = false;
                button1.Text = "Generate messages";
            }
        }

        private void OnCallReceived(Call call) {
            if (InvokeRequired) {
                Invoke(new CallReceiver.CallReceivedDelegate(OnCallReceived), call);
                return;
            }

            mobile.AddCalls(call);
            RefreshCallsInListView();
        }

        private void RefreshCallsInListView() {
            listView1.Items.Clear();
            var calls = mobile.GetRelevantCalls();
            for (int i = calls.Length-1; i >= 0 ; i--) {
                var callTime = (calls[i].CallEndTime - calls[i].CallStartTime).TotalSeconds;
                var listItem = new ListViewItem(new[] {
                    calls[i].Name,
                    calls[i].CallStartTime.ToString(),
                    callTime.ToString(),
                    calls[i].IsIncoming.ToString()
                });
                listView1.Items.Add(listItem);
            }
        }
    }
}