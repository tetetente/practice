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
    public partial class Form2 : Form {
        DAO dao = new DAO();

        public Form2() {
            InitializeComponent();
        }

        // 注文確認画面と注文確定画面の切り替え
        public void ChangeForm2(bool check) {
            this.order_count.Text = "1";
            bool noncheck;
            if (check) {
                noncheck = false;
            }else {
                noncheck = true;
            }
            order_name.Visible = check;
            order_count.Visible = check;
            order_price.Visible = check;
            order_picture.Visible = check;
            order_get.Visible = check;
            order_back.Visible = check;
            label1.Visible = check;
            backButton.Visible = check;
            nextButton.Visible = check;
            order_hit.Visible = noncheck;
            back_form1.Visible = noncheck; 
            
        }

        // 注文を確定した際に、DateBaseのsetorderに登録されるメソッド
        private void Confirm_Button(object sender, EventArgs e) {
            int count = int.Parse(this.order_count.Text);
            Product product = dao.getProductDAO(this.order_name.Text);
            bool set = dao.setProductDAO(product, count);
            if (set) {
                ChangeForm2(false);
                order_hit.Text = "注文が確定しました";
            }else {
                ChangeForm2(false);
                order_hit.Text = "注文が確定出来ませんでした";
            }
        }

        private void Next_Button(object sender, EventArgs e) {
            int plus = int.Parse(this.order_count.Text);
            if(plus < 10) {
                plus++;
                this.order_count.Text = plus.ToString();
            }else {
                this.order_count.Text = "10";
            }
        }

        private void Back_Button(object sender, EventArgs e) {
            int plus = int.Parse(this.order_count.Text);
            if(plus > 1) {
                plus--;
                this.order_count.Text = plus.ToString();
            }else {
                this.order_count.Text = "1";
            }
        }

        private void Delete(object sender, EventArgs e) {
            this.Close();
        }

        public void SetName(string name) {
            this.order_name.Text = name;
        }

        public void SetPrice(string price) {
            this.order_price.Text = price;
        }

        public void SetUrl(string url) {
            this.order_picture.ImageLocation = url;
        }


    }
}
