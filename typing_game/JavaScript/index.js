// ページが読み込まれたときに実行
window.addEventListener('load', function() {
    var xhr = new XMLHttpRequest();                         // サーバー通信用のオブジェクト
    xhr.onload = function() {                               // オブジェクトが読み込まれ
        if (this.responseText.trim() === "true") {          // 内容がtrue (登録失敗) なら
            var newUserParagraph = document.querySelector('.new-user p');
            newUserParagraph.textContent = '名前がすでに存在しています';
            newUserParagraph.style.color = 'red';
            clearSession();
        }
        else if(this.responseText.trim() === "false") {     // 内容がfalse (ログイン失敗) なら
            var newUserParagraph = document.querySelector('.existing-user p');
            newUserParagraph.textContent = 'ログインできませんでした';
            newUserParagraph.style.color = 'red';
            clearSession();
        }
    };
    xhr.open('GET', '/typing_game/PHP/check_user.php');     // Ajaxでcheck_user.phpにリクエストを送信
    xhr.send();
});

function clearSession() {                                   // セッションをクリアする関数
    var xhr = new XMLHttpRequest();                         // サーバー通信用のオブジェクト
    xhr.open('GET', '/typing_game/PHP/clear_session.php');  // Ajaxでclear_session.phpにリクエストを送信
    xhr.send();
}

// Ajaxを使用すると、Webページをリロードせずに動的に情報を更新出来る
// xhr.openは第一引数にHTTPメソッド、第二引数にURLを指定し、sendでリクエストを送信する
