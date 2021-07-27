using CodeName308.Characters.TrustGameCharaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Games.TrustGame
{
    /// <summary>
    /// 遊戲狀態，目前與TrustGameCharatersBase相互依賴，待改善
    /// </summary>
    public class GameStatus
    {
        public TrustGameCharatersBase Player1;
        public TrustGameCharatersBase Player2;
        public EnumGamePhase Phase;

        public GameStatus(TrustGameCharatersBase Player1, TrustGameCharatersBase Player2)
        {
            this.Player1 = Player1;
            this.Player2 = Player2;
            Player1.PlayerNoInGame = false;
            Player2.PlayerNoInGame = true;
            Phase = EnumGamePhase.Match;
        }
    }

    /// <summary>
    /// 遊戲流程
    /// </summary>
    public enum EnumGamePhase
    {
        /// <summary>
        /// 排到對手(判斷是否淘汰)，接著是策略選擇
        /// </summary>
        Match,

        /// <summary>
        /// 策略選擇(出錯)，接著是決策結果
        /// </summary>
        Strategy,

        /// <summary>
        /// 決策結果，視情況回策略選擇或遊戲結束
        /// </summary>
        Result,

        /// <summary>
        /// 遊戲結束，視情況排下一個對手
        /// </summary>
        End
    }
}