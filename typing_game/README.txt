目標：タイピングゲームの作成
① HTML・Css・JavaScript・PHP・MySQLを使用
② xammpを使用し、全てのフォルダはxammpフォルダ内のhtdocsに格納
③ 上記理由によりhttp://localhost/typing_game/HTML/index.htmlで起動
④ goDungeon.jsにはjQueryを使用 (勉強中)
⑤ 登録時に10桁のID番号を生成し、それをクッキーに保存
⑥ 現状ガバガバセキュリティなので、ハッシュ化など対策を検討中
⑦ 時間があればLaravelなどを使用したい

ファイル名 : 説明
index.html:登録・ログイン画面
selectDungeon.html:ダンジョン選択画面
goDungeon.html:タイピング画面

register.php:登録用
login.php:ログイン用
getName.php:名前取得用
clear_session.php:セッションクリア用
check_user:セッション判定用