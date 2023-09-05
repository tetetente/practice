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
    public partial class Form1 : Form {
     
        public Form1() {
            InitializeComponent();
        }

        // MainPageと他Pageに移動する際、画面を切り替える
        private void ChangeForm(bool check) {
            bool mainForm;
            if (check) {
                mainForm = false;
            }else {
                mainForm = true;
            }
            pictureBox001.Visible = mainForm;
            pictureBox002.Visible = mainForm;
            pictureBox003.Visible = mainForm;
            pictureBox004.Visible = mainForm;
            pictureBox005.Visible = mainForm;
            pictureBox006.Visible = mainForm;
            pictureBox007.Visible = check;
            pictureBox008.Visible = check;
            pictureBox009.Visible = check;
            order001.Visible = mainForm;
            order002.Visible = mainForm;
            order003.Visible = mainForm;
            order004.Visible = mainForm;
            order005.Visible = mainForm;
            order006.Visible = mainForm;
            order007.Visible = check;
            order008.Visible = check;
            order009.Visible = check;
            name001.Visible = mainForm; 
            name002.Visible = mainForm;
            name003.Visible = mainForm;
            name004.Visible = mainForm;
            name005.Visible = mainForm;
            name006.Visible = mainForm;
            name007.Visible = check;
            name008.Visible = check;
            name009.Visible = check;
            price001.Visible = mainForm;
            price002.Visible = mainForm;
            price003.Visible = mainForm;
            price004.Visible = mainForm;
            price005.Visible = mainForm;
            price006.Visible = mainForm;
            price007.Visible = check;
            price008.Visible = check;
            price009.Visible = check;
            en1.Visible = mainForm;
            en2.Visible = mainForm;
            en3.Visible = mainForm;
            en4.Visible = mainForm;
            en5.Visible = mainForm;
            en6.Visible = mainForm;
            en7.Visible = check;
            en8.Visible = check;
            en9.Visible = check;
            pictureBack1.Visible = check;
        }

        // Form起動時に Top_Button を起動する
        private void Form1_Load(object sender, EventArgs e) {
            this.top.PerformClick();
        }

        // MainPageを表示するボタン ( 商品名もここで変更 )
        private void Top_Button(object sender, EventArgs e) {
            DAO dao = new DAO();
            ChangeForm(true);
            this.total.Text = "1";
            this.menu.Text = "トップ";
            this.name007.Text = "堪能カルビ";
            this.price007.Text = dao.getProductDAO(this.name007.Text).Price.ToString();
            pictureBox007.ImageLocation = dao.getProductDAO(this.name007.Text).Url;
            this.name008.Text = "熟成カルビ";
            this.price008.Text = dao.getProductDAO(this.name008.Text).Price.ToString();
            pictureBox008.ImageLocation = dao.getProductDAO(this.name008.Text).Url;
            this.name009.Text = "上タン塩";
            this.price009.Text = dao.getProductDAO(this.name009.Text).Price.ToString();
            pictureBox009.ImageLocation = dao.getProductDAO(this.name009.Text).Url;
        }

        // 牛肉の商品を表示するボタン
        private void Cow_Button(object sender, EventArgs e) {
            ChangeForm(false);
            this.total.Text = "2";
            int count;
            if (this.menu.Text.Equals("牛肉")){
                count = int.Parse(this.current.Text);
            }else {
                this.menu.Text = "牛肉";
                count = 1;
                this.current.Text = "1";
            }
            List<string> list = new List<string>();
            ProductList prolist = new ProductList();
            list = prolist.setCow(count);
            SetText(list);
        }

        // 豚肉の商品を表示するボタン
        private void Pig_Button(object sender, EventArgs e) {
            ChangeForm(false);
            this.total.Text = "1";
            int count;
            if (this.menu.Text.Equals("豚肉")) {
                count = int.Parse(this.current.Text);
            }
            else {
                this.menu.Text = "豚肉";
                count = 1;
                this.current.Text = "1";
            }
            List<string> list = new List<string>();
            ProductList prolist = new ProductList();
            list = prolist.setPig(count);
            SetText(list);
        }

        // 鶏肉の商品を表示するボタン
        private void Bird_Button(object sender, EventArgs e) {
            ChangeForm(false);
            this.total.Text = "1";
            int count;
            if (this.menu.Text.Equals("鶏肉")) {
                count = int.Parse(this.current.Text);
            }else {
                this.menu.Text = "鶏肉";
                count = 1;
                this.current.Text = "1";
            }
            List<string> list = new List<string>();
            ProductList prolist = new ProductList();
            list = prolist.setBird(count);
            SetText(list);
        }

        // サイドの商品を表示するボタン
        private void Side_Button(object sender, EventArgs e) {
            ChangeForm(false);
            this.total.Text = "2";
            int count;
            if (this.menu.Text.Equals("サイド")) {
                count = int.Parse(this.current.Text);
            }
            else {
                this.menu.Text = "サイド";
                count = 1;
                this.current.Text = "1";
            }
            List<string> list = new List<string>();
            ProductList prolist = new ProductList();
            list = prolist.setSide(count);
            SetText(list);
        }

        // 飲み物の商品を表示するボタン
        private void Drink_Button(object sender, EventArgs e) {
            ChangeForm(false);
            this.total.Text = "1";
            int count;
            if (this.menu.Text.Equals("飲み物")) {
                count = int.Parse(this.current.Text);
            }
            else {
                this.menu.Text = "飲み物";
                count = 1;
                this.current.Text = "1";
            }
            List<string> list = new List<string>();
            ProductList prolist = new ProductList();
            list = prolist.setDrink(count);
            SetText(list);
        }

        // デザートの商品を表示するボタン
        private void Dessert_Button(object sender, EventArgs e) {
            ChangeForm(false);
            this.total.Text = "1";
            int count;
            if (this.menu.Text.Equals("デザート")) {
                count = int.Parse(this.current.Text);
            }
            else {
                this.menu.Text = "デザート";
                count = 1;
                this.current.Text = "1";
            }
            List<string> list = new List<string>();
            ProductList prolist = new ProductList();
            list = prolist.setDessert(count);
            SetText(list);
        }

        // 1ページに6商品の情報を表示するメソッド
        private void SetText(List<string> list) {
            DAO dao = new DAO();
            DeleteList();
            if (list.Count > 0) {
                this.name001.Text = list[0];
                this.price001.Text = dao.getProductDAO(list[0]).Price.ToString();
                pictureBox001.Visible = true;
                this.en1.Visible = true;
                this.order001.Visible = true;
                pictureBox001.ImageLocation = dao.getProductDAO(list[0]).Url;
                Console.WriteLine(dao.getProductDAO(list[0]).Url);
            }
            if(list.Count > 1) {
                this.name002.Text = list[1];
                this.price002.Text = dao.getProductDAO(list[1]).Price.ToString();
                pictureBox002.Visible = true;
                this.en2.Visible = true;
                this.order002.Visible = true;
                pictureBox002.ImageLocation = dao.getProductDAO(list[1]).Url;
            }
            if(list.Count > 2) {
                this.name003.Text = list[2];
                this.price003.Text = dao.getProductDAO(list[2]).Price.ToString();
                pictureBox003.Visible = true;
                this.en3.Visible = true;
                this.order003.Visible = true;
                pictureBox003.ImageLocation = dao.getProductDAO(list[2]).Url;
            }
            if(list.Count > 3) {
                this.name004.Text = list[3];
                this.price004.Text = dao.getProductDAO(list[3]).Price.ToString();
                pictureBox004.Visible = true;
                this.en4.Visible = true;
                this.order004.Visible = true;
                pictureBox004.ImageLocation = dao.getProductDAO(list[3]).Url;
            }
            if(list.Count > 4) {
                this.name005.Text = list[4];
                this.price005.Text = dao.getProductDAO(list[4]).Price.ToString();
                pictureBox005.Visible = true;
                this.en5.Visible = true;
                this.order005.Visible = true;
                pictureBox005.ImageLocation = dao.getProductDAO(list[4]).Url;
            }
            if(list.Count > 5) {
                this.name006.Text = list[5];
                this.price006.Text = dao.getProductDAO(list[5]).Price.ToString();
                pictureBox006.Visible = true;
                this.en6.Visible = true;
                this.order006.Visible = true;
                pictureBox006.ImageLocation = dao.getProductDAO(list[5]).Url;
            }
        }

        // 1ページの商品を全て削除するメソッド
        private void DeleteList() {
            this.name001.Text = "";
            this.price001.Text = "";
            this.en1.Visible = false;
            this.order001.Visible = false;
            pictureBox001.Visible = false;
            this.name002.Text = "";
            this.price002.Text = "";
            this.en2.Visible = false;
            this.order002.Visible = false;
            pictureBox002.Visible = false;
            this.name003.Text = "";
            this.price003.Text = "";
            this.en3.Visible = false;
            this.order003.Visible = false;
            pictureBox003.Visible = false;
            this.name004.Text = "";
            this.price004.Text = "";
            this.en4.Visible = false;
            this.order004.Visible = false;
            pictureBox004.Visible = false;
            this.name005.Text = "";
            this.price005.Text = "";
            this.en5.Visible = false;
            this.order005.Visible = false;
            pictureBox005.Visible = false;
            this.name006.Text = "";
            this.price006.Text = "";
            this.en6.Visible = false;
            this.order006.Visible = false;
            pictureBox006.Visible = false;
        }

        // 次ページに進む際に使用するボタン
        private void Next_Button(object sender, EventArgs e) {
            int plus = int.Parse(this.current.Text);
            if(plus == int.Parse(this.total.Text)) {
                plus = int.Parse(this.total.Text);
            }else {
                plus++;
            }
            this.current.Text = plus.ToString();
            click();
        }

        // 前ページに戻る際に使用するボタン
        private void Back_Button(object sender, EventArgs e) {
            int plus = int.Parse(this.current.Text);
            plus--;
            if (plus == 0) {
                plus = 1;
            }
            this.current.Text = plus.ToString();
            click();
        }

        // Next Back_Buttonを押した際に再度各ボタンをクリックするメソッド
        private void click() {
            if (this.menu.Text.Equals("牛肉")) {
                this.cow.PerformClick();
            }
            if (this.menu.Text.Equals("豚肉")) {
                this.pig.PerformClick();
            }
            if (this.menu.Text.Equals("サイド")) {
                this.side.PerformClick();
            }
            if (this.menu.Text.Equals("鶏肉")) {
                this.bird.PerformClick();
            }
            if (this.menu.Text.Equals("飲み物")) {
                this.brink.PerformClick();
            }
            if (this.menu.Text.Equals("デザート")) {
                this.dessert.PerformClick();
            }
        }

        // Form4に各情報を表示する
        private void Set_Form4(object sender, EventArgs e) {
            Form4 form4 = new Form4();
            DAO dao = new DAO();
            List<Order> orderList = dao.getOrderList();
            int money = 0;
            for (int i = 0; i < orderList.Count; i++) {
                money += orderList[i].Price * orderList[i].getCount;
            }
            form4.SetMoney(money);
            form4.ShowDialog();
        }

        // Form3に各情報を表示する
        private void Set_Form3(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            DAO dao = new DAO();
            List<Order> orderList = dao.getOrderList();
            int money = 0;
            for (int i = 0; i < orderList.Count; i++) {
                form3.SetName(orderList[i].Name);
                form3.SetPrice(orderList[i].Price);
                form3.SetCount(orderList[i].getCount);
                form3.SetSum(orderList[i].Price * orderList[i].getCount);
                money += orderList[i].Price * orderList[i].getCount;
            }
            int seat = dao.getSeat();
            form3.SetSeat(seat);
            form3.SetMoney(money);
            form3.ShowDialog();
        }

        // Form2に各情報を表示するメソッド
        private void Set_Form2(Product product) {
            Form2 form2 = new Form2();
            form2.ChangeForm2(true);
            form2.SetName(product.Name);
            form2.SetPrice(product.Price.ToString());
            form2.SetUrl(product.Url);
            form2.ShowDialog();
        }

        // 以下、注文をした際に起動するボタン
        private void Order001(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name001.Text));
        }

        private void Order002(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name002.Text));
        }

        private void Order003(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name003.Text));
        }

        private void Order004(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name004.Text));
        }

        private void Order005(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name005.Text));
        }

        private void Order006(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name006.Text));
        }

        private void Order007(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name007.Text));
        }

        private void Order008(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name008.Text));
        }

        private void Order009(object sender, EventArgs e) {
            DAO dao = new DAO();
            Set_Form2(dao.getProductDAO(this.name009.Text));
        }

    }
}
