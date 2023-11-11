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

// クッキーからユーザーIDを取得
$user_id = $_COOKIE['userid'];

// データベースからユーザー名を取得
$sql = "SELECT name FROM users WHERE id = ?";
$stmt = $conn->prepare($sql);
$stmt->bind_param("s", $user_id);
$stmt->execute();
$result = $stmt->get_result();
if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $name = $row["name"];
    echo $name;
} 

// 接続終了
$conn->close();
?>