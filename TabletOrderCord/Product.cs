using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletOrder {
    class Product {
        private string name;
        private int price;
        private string url;

        public Product(string name,int price,string url) {
            this.name = name;
            this.price = price;
            this.url = url;
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

        public string Url {
            get {
                return this.url;
            }
        }
    }
}
