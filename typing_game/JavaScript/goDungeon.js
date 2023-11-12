// モンスターのリストを格納する配列
let monsters = [
    { name: "モンスター1", hp: 10, attack: 1, image: "../Image/monster1.jpg", attackSpeed: 1 },
    { name: "モンスター2", hp: 20, attack: 2, image: "../Image/monster2.jpg", attackSpeed: 1 },
    { name: "モンスター3", hp: 30, attack: 3, image: "../Image/monster3.jpg", attackSpeed: 1 },
    { name: "モンスター4", hp: 40, attack: 4, image: "../Image/monster4.jpg", attackSpeed: 1 },
    { name: "モンスター5", hp: 50, attack: 5, image: "../Image/monster5.jpg", attackSpeed: 1 }
];

// プレイヤーの体力と現在のモンスターの情報を格納する変数
let playerHealth = 100;                                     // プレイヤーの体力を格納
let currentMonsterIndex = 0;                                // 現在のモンスターのインデックスを格納
let currentMonster;                                         // 現在のモンスターを格納
let attackTimer = null;                                     // attackTimerをnullで初期化
let selectList = null;                                      // 現在の問題を格納
let furigana = null;                                        // 現在の問題のフリガナを格納
let problem = null;                                         // 現在の問題文を格納


// 全てのHTMLが読み込まれた後に実行される関数
$(document).ready(function () {
    wanakana.bind(document.getElementById('typing-area'));                      // wanakanaを使用する
    $('#typing-area').on('input', function () {                                 // ユーザーが入力したローマ字をひらがなに変換
        let input = $(this).val();                                              // 入力された文字をひらがなとして取得
        let lastChar = null;
        if (isSmallKana(input[input.length - 1]) && input.length > 1) {           // 入力された文字列の最後の文字が拗音の場合
            lastChar = input[input.length - 2] + input[input.length - 1];         // 入力された文字列の最後の2文字を取得    
        } else if (isSmallKanaT(input[input.length - 2]) && input.length > 1) {   // 入力された文字列の最後の文字が促音の場合
            lastChar = input[input.length - 2] + input[input.length - 1];         // 入力された文字列の最後の2文字を取得
        } else {
            lastChar = input[input.length - 1];                                 // 入力された文字列の最後の1文字を取得
        }
        updateInput(lastChar);                                                  // updateChallenge関数を使用
    });

    // モンスターの画像と体力を表示する関数
    function displayMonster() {
        currentMonster = monsters[currentMonsterIndex];         // 現在のモンスターを取得
        $('#monster-image').attr('src', currentMonster.image);  // モンスターの画像を表示
        $('#monster-health span').text(currentMonster.hp);      // モンスターの体力を表示

        if (attackTimer !== null) {                             // 以前のモンスターのattackTimerが残っている場合
            clearInterval(attackTimer);                         // attackTimerをClear
        }

        attackTimer = setInterval(function () {                 // attackTimerをセット
            if (playerHealth > 0) {                             // プレイヤーの体力が残っている場合
                playerHealth -= currentMonster.attack;          // プレイヤーの体力を減らす
                updateHealthDisplay();                          // プレイヤーの体力の表示を更新する (updateHealthDisplay関数を使用)
            }
        }, currentMonster.attackSpeed * 1000);                  // attackSpeedの値に応じてattackTimerをセット
    }

    // プレイヤーの体力の表示を更新する関数
    function updateHealthDisplay() {
        $('#player-health span').text(playerHealth);            // プレイヤーの体力を表示
    }

    // 問題文を表示する関数
    function displayNewChallenge() {
        selectList = typing_easy[Math.floor(Math.random() * typing_easy.length)];     // 問題文のリストをランダムに取得
        problem = selectList[0];                                                      // 問題文を取得
        furigana = setFurigana(selectList[1]);                                        // 問題文のフリガナを取得
        $('#typing-challenge').text(problem);                                         // HTMLのtyping-challengeに表示
        $('#furigana-display').text(selectList[1]);                                   // HTMLのfurigana-displayに表示
    }

    // furiganaをそれぞれ個々に分ける関数
    function setFurigana(furigana) {
        let furiganaList = [];                                                                    // furiganaを格納する配列を作成
        for (let i = 0; i < furigana.length; i++) {                                               // furiganaの文字数分繰り返す
            furiganaList.push(furigana[i]);                                                       // 配列に追加
        }
        return furiganaList;                                                                      // furiganaListを返す
    }

    // 拗音かどうかを判定する関数
    function isSmallKana(kana) {
        return ['ゃ', 'ゅ', 'ょ'].includes(kana);                             // 拗音の場合はtrueを返す
    }

    // 促音かどうかを判定する関数
    function isSmallKanaT(kana) {
        return ['っ'].includes(kana);                                         // 促音の場合はtrueを返す
    }

    function isRomaji(input) {
        const romajiRegex = /^[A-Za-z0-9]+$/;
        return romajiRegex.test(input);
    }

    // 入力情報をもとに問題文を更新する関数
    function updateInput(input) {
        if (isRomaji(input) == false) {
            if (furigana.length > 0 && input == furigana[0]) {                    // 入力された文字がフリガナの先頭の文字と一致する場合
                furigana.shift();                                                 // フリガナの先頭の文字を削除
                $('#furigana-display').text(furigana.join(''));                   // 問題文のひらがなを更新
                currentMonster.hp -= 1;                                           // モンスターの体力を減らす
                $('#monster-health span').text(currentMonster.hp);                // モンスターの体力表示を更新
            } else if (input.length = 2 && input == furigana[0] + furigana[1]) {  // 入力された文字がフリガナの先頭の文字と一致する場合
                furigana.shift();                                                 // フリガナの先頭の文字を削除
                furigana.shift();                                                 // フリガナの先頭の文字を削除
                $('#furigana-display').text(furigana.join(''));                   // 問題文のひらがなを更新
                currentMonster.hp -= 2;                                           // モンスターの体力を減らす
                $('#monster-health span').text(currentMonster.hp);                // モンスターの体力表示を更新
            } else {                                                              // 入力された文字を間違えた場合
                playerHealth -= 1;                                                // プレイヤーの体力を減らす
                updateHealthDisplay();                                            // プレイヤーの体力表示を更新
            }

            if (furigana.length == 0) {                                           // フリガナがなくなった場合
                displayNewChallenge();                                            // displayNewChallenge関数を使用
            }

            if (currentMonster.hp <= 0) {                                         // モンスターの体力が0以下になった場合
                currentMonsterIndex++;                                            // 次のモンスターに進む
                if (currentMonsterIndex < monsters.length) {                      // 次のモンスターが存在する場合
                    displayMonster();                                             // displayMonster関数を使用           
                } else {
                }
            }
        }
    }

    // 実行
    displayMonster();
    displayNewChallenge();
});

// 問題文格納用のテーブル
let typing_easy = [
    ["軽快なステップで", "けいかいなすてっぷで"],
    ["青い空を見上げて", "あおいそらをみあげて"],
    ["夕暮れ時の散歩", "ゆうぐれときのさんぽ"],
    ["満開の桜の木の下", "まんかいのさくらのきのした"],
    ["猫のしっぽを追いかける", "ねこのしっぽをおいかける"],
    ["砂浜を走り抜ける", "すなはまをはしりぬける"],
    ["新鮮な果物のジュース", "しんせんなくだもののじゅーす"],
    ["冷たい風が吹き抜ける", "つめたいかぜがふきぬける"],
    ["暖かい太陽の光", "あたたかいたいようのひかり"],
    ["星空に願いを", "ほしぞらにねがいを"],
    ["山の頂への登山", "やまのいただきへのとざん"],
    ["波の音を聞きながら", "なみのおとをききながら"],
    ["風車が回る丘", "ふうしゃがまわるおか"],
    ["古い本のページをめくる", "ふるいほんのぺーじをめくる"],
    ["ピアノの優しい旋律", "ぴあののやさしいせんりつ"],
    ["手紙を封筒に入れて", "てがみをふうとうにいれて"],
    ["星座を探す夜に", "せいざをさがすよるに"],
    ["朝露に濡れた草花", "あさつゆにぬれたくさばな"],
    ["虹のかかる空に", "にじのかかるそらに"],
    ["夜の市場を歩く", "よるのいちばをあるく"]
];

let typing_normal = [
    

];