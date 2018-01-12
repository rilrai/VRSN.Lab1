using System.Collections.Generic;

namespace Lab6Form {
    public class Contact {
        public string Name { get; set; }

        public List<PhoneNumber> Numbers = new List<PhoneNumber>();

        public Contact(string name, params string[] nums) {
            Name = name;
            for (int i = 0; i < nums.Length; i++) {
                Numbers.Add(new PhoneNumber(nums[i]));
            }
        }

        public void AddNumber(string num) {
            Numbers.Add(new PhoneNumber(num));
        }
    }
}