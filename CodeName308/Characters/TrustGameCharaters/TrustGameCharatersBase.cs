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

        /// <summary>
        /// 是否隱藏身分
        /// </summary>
        public bool HideName;

        /// <summary>
        /// 是否由玩家操作
        /// </summary>
        public bool Playable;

        /// <summary>
        /// 是否決策錯誤
        /// </summary>
        public bool IsWrong;

        #endregion 由類別初始化屬性

        #region 由GameSetting初始化屬性

        public int Score;
        public double ErrorRate;

        #endregion 由GameSetting初始化屬性

        /// <summary>
        /// 遊戲紀錄每次賽局初始化
        /// </summary>
        public List<EnumTrustGameStrategyResult> GameLog;

        /// <summary>
        /// 現在的決策，由PickStrategy方法定義
        /// </summary>
        public EnumTrustGameStrategy CurrentStrategy;
        /// <summary>
        /// 開始遊戲時設定，0為P1 / 1為P2
        /// </summary>
        public bool PlayerNoInGame;

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
        /// 策略選擇，包含出錯計算以及將結果存到CurrentStrategy
        /// </summary>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public EnumTrustGameStrategy PickStrategy(EnumTrustGameStrategy strategy)
        {
            IsWrong = false;
            CurrentStrategy = strategy;
            Random random = new Random();
            EnumTrustGameStrategy wrongStrategy = strategy == EnumTrustGameStrategy.Cooperate ?
                EnumTrustGameStrategy.Betray : EnumTrustGameStrategy.Cooperate;
            if (random.Next() % 100 > ErrorRate * 100)
                return strategy;
            CurrentStrategy = wrongStrategy;
            IsWrong = true;
            return wrongStrategy;
        }

        /// <summary>
        /// NPC動作 預設50%隨機
        /// </summary>
        /// <returns></returns>
        public virtual EnumTrustGameStrategy NPCStrategy()
        {
            Random random = new Random();
            return random.Next() % 2 == 1 ? PickStrategy(EnumTrustGameStrategy.Cooperate) : PickStrategy(EnumTrustGameStrategy.Betray);
        }
    }
}