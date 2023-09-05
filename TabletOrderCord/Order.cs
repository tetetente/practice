using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletOrder {
    class Order {
        private string name;
        private int count;
        private int price;

        public Order(string name,int count,int price) {
            this.name = name;
            this.count = count;
            this.price = price;
        }

        public string Name {
            get {
                return this.name;
            }
        }

        public int Price {
            get {
                return this.price;
            }
        }

        public int getCount {
            get {
                return this.count;
            }
        }
    }
}
