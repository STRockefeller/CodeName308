using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Games.TrustGame
{
    /// <summary>
    /// 遊戲設定，SamdBox Mode可以客製化調整
    /// </summary>
    public class GameSetting
    {
        /// <summary>
        /// 出錯率
        /// </summary>
        public double ErrorRate { get; set; }

        /// <summary>
        /// 初始分數
        /// </summary>
        public int InitScore { get; set; }

        /// <summary>
        /// 決策結果影響分數變化
        /// </summary>
        public Dictionary<EnumTrustGameStrategyResult, (int, int)> ScoreChange { get; set; }

        /// <summary>
        /// 對局次數
        /// </summary>
        public int GameCount { get; set; }

        /// <summary>
        /// 使用預設設定
        /// </summary>
        public void UseDefault()
        {
            ErrorRate = 0.05;
            InitScore = 10;
            ScoreChange = new Dictionary<EnumTrustGameStrategyResult, (int, int)>
            {
                { EnumTrustGameStrategyResult.CC, (1, 1) },
                { EnumTrustGameStrategyResult.CB, (-2, 2) },
                { EnumTrustGameStrategyResult.BC, (2, -2) },
                { EnumTrustGameStrategyResult.BB, (-1, -1) }
            };
            GameCount = 10;
        }

        public GameSetting() => UseDefault();
    }
}