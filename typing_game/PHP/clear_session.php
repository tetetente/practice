
<?php
session_start();
if (isset($_SESSION['user_exists'])) {
    unset($_SESSION['user_exists']);
}
if (isset($_SESSION['user_check'])) {
    unset($_SESSION['user_check']);
}
?>