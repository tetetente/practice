<?php
$servername = "localhost";
$username = "root";
$password = "root";
$dbname = "typing_game";

// データベース接続の設定
$conn = new mysqli($servername, $username, $password, $dbname);

// 接続チェック
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// POSTされたデータを変数に入れる
$user_name = $_POST['name'];
$user_password = $_POST['password'];

// ユーザー名のチェック
$stmt = $conn->prepare("SELECT * FROM users WHERE name = ?");
$stmt->bind_param("s", $user_name);
$stmt->execute();
$result = $stmt->get_result();
if ($result->num_rows > 0) {                            // ユーザー名が存在する場合
    session_start();                                    // セッションを開始
    $_SESSION['user_exists'] = true;                    // セッション変数 'user_exists' に true を代入
    header("Location: /typing_game/HTML/index.html");   // index.htmlへ
    exit;
} else {                                                // ユーザー名が存在しない場合
    $user_id = mt_rand(1000000000, 9999999999);         // 10桁のIDを生成
    $stmt = $conn->prepare("INSERT INTO users (name, pass ,id) VALUES (?, ? ,?)");
    $stmt->bind_param("sss", $user_name, $user_password, $user_id);
    $stmt->execute();
    setcookie("userid", $user_id , time() + 3600);              // 1時間有効なクッキーに保存
    header("Location: /typing_game/HTML/selectDungeon.html");
}

// 接続終了
$conn->close();
