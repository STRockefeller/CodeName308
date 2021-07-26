using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeName308.Games.TrustGame;

namespace CodeName308.Characters.TrustGameCharaters
{
    public class TrustGameCharatersBase
    {
        #region 由類別初始化屬性

        public string Name;
        public bool IsDefeated;
        public bool HideName;
        public bool Playable;

        #endregion 由類別初始化屬性

        #region 由GameSetting初始化屬性

        public int Score;
        public double ErrorRate;

        #endregion 由GameSetting初始化屬性

        public TrustGameCharatersBase()
        {
            IsDefeated = false;
            HideName = false;
            Playable = false;
        }

        /// <summary>
        /// 角色在TrustGame的能力說明
        /// </summary>
        /// <returns></returns>
        public virtual string Description() => "角色在TrustGame的能力說明";

        /// <summary>
        /// 對局開始前效果
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public virtual GameStatus MatchingPhaseEffect(GameStatus status) => status;

        /// <summary>
        /// 策略選擇後到結果出來前效果
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public virtual GameStatus ResultPhaseEffect(GameStatus status) => status;

        /// <summary>
        /// 對局結束前效果(對局開始前效果重置)
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public virtual GameStatus EndPhaseEffect(GameStatus status) => status;
        /// <summary>
        /// 策略選擇，包含出錯
        /// </summary>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public EnumTrustGameStrategy PickStrategy(EnumTrustGameStrategy strategy)
        {
            Random random = new Random();
            EnumTrustGameStrategy wrongStrategy = strategy == EnumTrustGameStrategy.Cooperate ?
                EnumTrustGameStrategy.Betray : EnumTrustGameStrategy.Cooperate;
            return random.Next() % 100 < ErrorRate * 100 ? strategy : wrongStrategy;
        }
    }
}