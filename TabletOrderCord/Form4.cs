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
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        public void SetMoney(int money) {
            this.money.Text = money.ToString();
        }

        private void Account_Button(object sender, EventArgs e) {
            DAO dao = new DAO();
            bool end = dao.setComfirm();
            Console.WriteLine(end);
            if (end) {
                endLabel.Visible = true;
            }
        }

        private void Back_Button(object sender, EventArgs e) {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e) {
            endLabel.Visible = false;
        }
    }
}
