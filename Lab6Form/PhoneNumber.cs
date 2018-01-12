using System;

namespace Lab6Form {
    public class PhoneNumber {
        private string _number;

        public PhoneNumber(string num) {
            SetNumber(num);
        }
        public void SetNumber(string num) {
            if (num.Length == 10) {
                _number = num;
            }
            else {
                throw new ArgumentException("Number must consist of 10 digits");
            }
        }


    }
}