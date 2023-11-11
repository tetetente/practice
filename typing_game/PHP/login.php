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

// nameとpassのチェック
$stmt = $conn->prepare("SELECT * FROM users WHERE name = ? AND pass = ?");
$stmt->bind_param("ss", $user_name, $user_password);
$stmt->execute();
$result = $stmt->get_result();
if ($result->num_rows > 0) {                                // ユーザー名とパスワードが一致する場合
    $row = $result->fetch_assoc();  // この行を追加
    $user_id = $row['ID'];                                  // 10桁のIDを取得
    setcookie("userid", $user_id , time() + 3600);          // 1時間有効なクッキーに保存
    header("Location: /typing_game/HTML/selectDungeon.html");     // dungeon.htmlへ
    exit;
} else {                                                    // ユーザー名とパスワードが一致しない場合
    session_start();                                        // セッションを開始
    $_SESSION['user_check'] = true;                         // セッション変数 'user_check' に true を代入
    header("Location: /typing_game/HTML/index.html");       // index.htmlへ
}

$conn->close();
?>