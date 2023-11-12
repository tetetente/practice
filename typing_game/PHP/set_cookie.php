<?php
$user_name = $_POST['name'];
setcookie("userid", 0 , time() + 3600); // 1時間有効なクッキーに保存
header("Location: /typing_game/HTML/selectDungeon.html"); // dungeon.htmlへ
exit;
?>