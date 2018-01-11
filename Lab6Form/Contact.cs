using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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