using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletOrder {
    class ProductList {
        
        // 牛の商品リスト
        public List<string> setCow(int count) {
            List<string> nameList = new List<string>();
            switch (count) {
                case 1:
                    nameList.Add("牛タン塩");
                    nameList.Add("ねぎ牛タン塩");
                    nameList.Add("上タン塩");
                    nameList.Add("カルビ");
                    nameList.Add("熟成カルビ");
                    nameList.Add("中落ちカルビ");
                    break;
                case 2:
                    nameList.Add("ハラミ");
                    nameList.Add("上ハラミ");
                    nameList.Add("王様ハラミ");
                    nameList.Add("ロース");
                    nameList.Add("上ロース");
                    nameList.Add("鴨ロース");
                    break;
            }
            return nameList;
        }

        // 豚の商品リスト
        public List<string> setPig(int count) {
            List<string> nameList = new List<string>();
            switch (count) {
                case 1:
                    nameList.Add("ねぎ塩豚カルビ");
                    nameList.Add("豚カルビ");
                    nameList.Add("ピートロ");
                    nameList.Add("はちみつ黒胡椒焼き");
                    break;
            }
            return nameList;
        }

        // 鶏の商品リスト
        public List<string> setBird(int count) {
            List<string> nameList = new List<string>();
            switch (count) {
                case 1:
                    nameList.Add("鶏ももカルビ");
                    nameList.Add("ぼんちり");
                    nameList.Add("やげん軟骨");
                    nameList.Add("チキンバジル");
                    nameList.Add("チキンバジル ﾁｰｽﾞ");
                    break;
            }
            return nameList;
        }

        // サイドの商品リスト
        public List<string> setSide(int count) {
            List<string> nameList = new List<string>();
            switch (count) {
                case 1:
                    nameList.Add("温玉サラダ");
                    nameList.Add("サンチュセット");
                    nameList.Add("桜ユッケ");
                    nameList.Add("塩キャベツ");
                    nameList.Add("枝豆");
                    nameList.Add("韓国のり");
                    break;
                case 2:
                    nameList.Add("キムチ");
                    nameList.Add("辛もやし");
                    nameList.Add("辛きゅうり");
                    nameList.Add("カクテキ");
                    break;
            }
            return nameList;
        }

        // 飲み物の商品リスト
        public List<string> setDrink(int count) {
            List<string> nameList = new List<string>();
            switch (count) {
                case 1:
                    nameList.Add("烏龍茶");
                    nameList.Add("コーラ");
                    nameList.Add("ビール");
                    nameList.Add("ハイボール");
                    nameList.Add("オレンジジュース");
                    nameList.Add("お冷");
                    break;
            }
            return nameList;
        }

        // デザートの商品リスト
        public List<string> setDessert(int count) {
            List<string> nameList = new List<string>();
            switch (count) {
                case 1:
                    nameList.Add("メロンパンアイス");
                    nameList.Add("焼きパイン");
                    nameList.Add("バニラアイス");
                    nameList.Add("抹茶アイス");
                    nameList.Add("杏仁豆腐");
                    nameList.Add("ポンデバニラ");
                    break;
            }
            return nameList;
        }
    }
}
