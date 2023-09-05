using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TabletOrder {
    class DAO {
        int seat = 1;
        string server = "localhost";
        string database = "tabletorder";
        string user = "root";
        string pass = "root";
        string charset = "utf8";

        public int getSeat() {
            return this.seat;
        }

        // 接続が可能かどうかを確認する
        // 現在どこにも記載していない
        public void checkDAO() {
            try {
                string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Charset={4}", server, database, user, pass, charset);
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();　// 接続
                Console.WriteLine("接続しました");
                string sql = $"SELECT name,price,url FROM namelist WHERE name='タン'";
                MySqlCommand command = new MySqlCommand(sql.ToString(), connection); // SQL送信
                MySqlDataReader reader = command.ExecuteReader(); // 取得した情報をリスト化
                while (reader.Read()) {
                    for (int i = 0; i < reader.FieldCount; i++) {
                        Console.Write(reader[i] + " ");
                    }
                    Console.WriteLine();
                }
                connection.Close();    // 接続の解除
            }
            catch {
                Console.WriteLine("接続できません");
            }
        }

        // 引数の名前をDataBaseで検索しProductを取得する
        // Productには 商品名 値段 画像の場所 を代入する
        public Product getProductDAO(string getname) {
            try {
                string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Charset={4}", server, database, user, pass, charset);
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();　// 接続
                string sql = "SELECT name,price,url FROM namelist WHERE name= @getname";
                using (MySqlCommand command = new MySqlCommand(sql.ToString(), connection)) {
                    command.Parameters.AddWithValue("@getName", getname);
                    using (MySqlDataReader reader = command.ExecuteReader()) {
                        List<Product> list = new List<Product>();
                        while (reader.Read()) {
                            for (int i = 0; i < reader.FieldCount; i++) {
                                string name = (string)reader["name"];
                                int price = (int)reader["price"];
                                string url = (string)reader["url"];
                                Product product = new Product(name, price, url);
                                list.Add(product);
                            }
                            return list[0];
                        }
                    }
                    connection.Close();    // 接続の解除
                    Console.WriteLine("情報が取得できました！");
                }
            }
            catch {
                Console.WriteLine("情報が取得できませんでした！");
            }
            return null;
        }

        // 引数の商品情報をDateBaseのsetorderに登録する
        // 登録が出来た場合はtrueで返す
        public bool setProductDAO(Product product, int count) {
            try {
                string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Charset={4}", server, database, user, pass, charset);
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();　// 接続
                string sql = "INSERT INTO setorder (seat,name,count,price) VALUES (@seat,@name,@count,@price)";
                using (MySqlCommand command = new MySqlCommand(sql.ToString(), connection)) {
                    string name = product.Name;
                    int price = product.Price;
                    command.Parameters.AddWithValue("@seat", seat);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@count", count);
                    command.Parameters.AddWithValue("@price", price);
                    command.ExecuteNonQuery();
                    Console.WriteLine("情報が登録できました！");
                }
                connection.Close();    // 接続の解除
                return true;
            }
            catch {
                Console.WriteLine("情報が登録できませんでした！");
            }
            return false;
        }

        // 現在のsetorderの情報を取得する
        public List<Order> getOrderList() {
            try {
                string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Charset={4}", server, database, user, pass, charset);
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();　// 接続
                string sql = "SELECT name,count,price FROM setorder WHERE seat= @seat";
                using (MySqlCommand command = new MySqlCommand(sql.ToString(), connection)) {
                    command.Parameters.AddWithValue("@seat", seat);
                    using (MySqlDataReader reader = command.ExecuteReader()) {
                        List<Order> list = new List<Order>();
                        while (reader.Read()) {
                            string name = (string)reader["name"];
                            int count = (int)reader["count"];
                            int price = (int)reader["price"];
                            Order order = new Order(name, count, price);
                            list.Add(order);
                        }
                        connection.Close();    // 接続の解除
                        Console.WriteLine("情報が取得できました！");
                        return list;
                    }
                }
            }
            catch {
                Console.WriteLine("情報が取得できませんでした！");
            }
            return null;

        }

        // 現在のsetorderの情報を取得し、comfirmに移す。
        // その後、seat番号に応じたsetorderを削除
        public bool setComfirm() {
            List<Order> list = getOrderList();
            try {
                string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Charset={4}", server, database, user, pass, charset);
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();　// 接続
                DateTime dt = DateTime.Now;
                for (int i = 0; i < list.Count; i++) {
                    string sql = "INSERT INTO comfirm (name,price,count,money,year,month,day,hour) VALUES (@name,@price,@count,@money,@year,@month,@day,@hour)";
                    using (MySqlCommand command = new MySqlCommand(sql.ToString(), connection)) {
                        Console.WriteLine(list.Count);
                        string name = list[i].Name;
                        int price = list[i].Price;
                        int count = list[i].getCount;
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@count", count);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@money", count * price);
                        command.Parameters.AddWithValue("@year", dt.Year);
                        command.Parameters.AddWithValue("@month", dt.Month);
                        command.Parameters.AddWithValue("@day", dt.Day);
                        command.Parameters.AddWithValue("@hour", dt.Hour);
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("情報が登録できました！");
                }
                string delsql = "DELETE FROM setorder WHERE seat = @seat";
                using (MySqlCommand command = new MySqlCommand(delsql.ToString(), connection)) {
                    command.Parameters.AddWithValue("@seat", seat);
                    command.ExecuteNonQuery();
                }
                connection.Close();    // 接続の解除
                return true;
            }
            catch {
                Console.WriteLine("情報が登録できませんでした！");
            }
            return false;
        }
    }
}
