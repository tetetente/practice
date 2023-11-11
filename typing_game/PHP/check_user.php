
<?php
session_start();   // セッションを開始
if (isset($_SESSION['user_exists'])) { 
    echo "true"; 
} else if(isset($_SESSION['user_check'])) {
    echo "false";
}
?>