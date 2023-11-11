// ページが読み込まれたときに実行
window.addEventListener('load', function () {
    var xhr = new XMLHttpRequest();
    xhr.onload = function () {
        var userName = document.querySelector('.get-name p');               // HTMLのget-name pを取得
        userName.textContent = this.responseText.trim()+'さん、ようこそ';    // HTMLのget-name pに取得した名前を表示
    };
    xhr.open('GET', '/typing_game/PHP/getName.php');                        // AjaxでgetName.phpにリクエストを送信
    xhr.send();
});

var levelButtons = document.querySelectorAll('.dungeon-level-button');      // 全ての難易度ボタンClass(.dungeon-level-button)を格納する
var startGameContainer = document.getElementById('start-game-container');   // 開始ボタンid(start-game-container)を格納する
var selectedLevel = '';                                                     // 選択された難易度を保存する変数

levelButtons.forEach(function (button) {                                    // 全ての難易度ボタンClassに対し
    button.addEventListener('click', function () {                          // クリックされたら      
        selectedLevel = this.dataset.level;                                 // データ属性から難易度を取得
        startGameContainer.classList.remove('hidden');                      // 開始ボタンを表示する
    });                                                                     // 機能を追加する
});

document.getElementById('start-game-button').addEventListener('click', function () {  // 開始ボタンidがクリックされたら
    if (selectedLevel === 'easy') {                                                   // 難易度が初級だった場合
        window.location.href = 'goDungeon.html';                                      // easyDungeon.htmlにリダイレクト
    }
});