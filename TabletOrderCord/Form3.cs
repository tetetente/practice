using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabletOrder {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        public string GetName() {
            return this.nameList.Text;
        }

        public void SetName(string name) {
            this.nameList.Text += name+ Environment.NewLine;
        }

        public void SetPrice(int price) {
            this.priceList.Text += price+ Environment.NewLine;
        }

        public void SetCount(int count) {
            this.countList.Text += count+ Environment.NewLine;
        }

        public void SetSum(int sum) {
            this.sumList.Text += sum+ Environment.NewLine;
        }

        public void SetMoney(int money) {
            this.money.Text = money.ToString();
        }
         
        public void SetSeat(int seat) {
            this.getSeat.Text = seat.ToString();
        }

        private void Delete(object sender, EventArgs e) {
            this.nameList.Text = " ";
            this.countList.Text = " ";
            this.priceList.Text = " ";
            this.sumList.Text = " ";
            this.money.Text = " ";
            this.Close();
        }
    }
}
