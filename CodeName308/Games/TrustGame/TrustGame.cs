using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Games.TrustGame
{
    /// <summary>
    /// 賽局類別
    /// </summary>
    internal class TrustGame
    {
        private GameStatus _status;
        public EnumTrustGameType GameType { get; set; }

        public TrustGame(GameStatus status)
        {
            _status = status;
            ToPhase(EnumGamePhase.Match);
            _status.Player1.GameLog = new List<EnumTrustGameStrategyResult>();
            _status.Player2.GameLog = new List<EnumTrustGameStrategyResult>();
        }

        public EnumGamePhase CurrentPhase() => _status.Phase;

        /// <summary>
        /// 進入指定階段，進入Result Phase之前先呼叫GameResult方法
        /// </summary>
        /// <param name="phase"></param>
        public void ToPhase(EnumGamePhase phase)
        {
            _status.Phase = phase;
            switch (phase)
            {
                case EnumGamePhase.Match:
                    _status = _status.Player1.MatchingPhaseEffect(_status);
                    _status = _status.Player2.MatchingPhaseEffect(_status);
                    break;

                case EnumGamePhase.Result:
                    _status = _status.Player1.ResultPhaseEffect(_status);
                    _status = _status.Player2.ResultPhaseEffect(_status);
                    break;

                case EnumGamePhase.End:
                    _status = _status.Player1.EndPhaseEffect(_status);
                    _status = _status.Player2.EndPhaseEffect(_status);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 賽局結果邏輯，在進入Result Phase之前執行
        /// </summary>
        /// <param name="setting"></param>
        public void GameResult(GameSetting setting)
        {
            #region 決策結果

            EnumTrustGameStrategyResult result;
            if (_status.Player1.CurrentStrategy == EnumTrustGameStrategy.Cooperate)
                result = _status.Player2.CurrentStrategy == EnumTrustGameStrategy.Cooperate ?
                     EnumTrustGameStrategyResult.CC : EnumTrustGameStrategyResult.CB;
            else
                result = _status.Player2.CurrentStrategy == EnumTrustGameStrategy.Cooperate ?
                     EnumTrustGameStrategyResult.BC : EnumTrustGameStrategyResult.BB;

            #endregion 決策結果

            #region 分數計算

            (int, int) scoreChange;
            setting.ScoreChange.TryGetValue(result, out scoreChange);
            _status.Player1.Score += scoreChange.Item1;
            _status.Player2.Score += scoreChange.Item2;

            #endregion 分數計算

            #region 紀錄

            _status.Player1.GameLog.Add(result);
            _status.Player2.GameLog.Add(OppositeLog(result));

            #endregion 紀錄
        }

        /// <summary>
        /// Player2結果記錄用
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        private EnumTrustGameStrategyResult OppositeLog(EnumTrustGameStrategyResult result)
        {
            if (result == EnumTrustGameStrategyResult.BC)
                return EnumTrustGameStrategyResult.CB;
            if (result == EnumTrustGameStrategyResult.CB)
                return EnumTrustGameStrategyResult.BC;
            return result;
        }

        /// <summary>
        /// 指定Player1策略
        /// </summary>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public (bool, EnumTrustGameStrategy) SetPlayer1Strategy(EnumTrustGameStrategy strategy)
        {
            EnumTrustGameStrategy result = _status.Player1.PickStrategy(strategy);
            bool isWrong = _status.Player1.IsWrong;
            return (isWrong, result);
        }

        /// <summary>
        /// 指定Player2策略
        /// </summary>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public (bool, EnumTrustGameStrategy) SetPlayer2Strategy(EnumTrustGameStrategy strategy)
        {
            EnumTrustGameStrategy result = _status.Player2.PickStrategy(strategy);
            bool isWrong = _status.Player2.IsWrong;
            return (isWrong, result);
        }

        /// <summary>
        /// 指定Player1NPC策略
        /// </summary>
        /// <returns></returns>
        public EnumTrustGameStrategy SetPlayer1NPCStrategy() => _status.Player1.NPCStrategy();

        /// <summary>
        /// 指定Player2NPC策略
        /// </summary>
        /// <returns></returns>
        public EnumTrustGameStrategy SetPlayer2NPCStrategy() => _status.Player2.NPCStrategy();

        /// <summary>
        /// 取得當前分數
        /// </summary>
        /// <returns></returns>
        public (int, int) ShowScore() => (_status.Player1.Score, _status.Player2.Score);

        /// <summary>
        /// 取得玩家名字
        /// </summary>
        /// <returns></returns>
        public (string, string) GetName() => (_status.Player1.HideName ? "匿名" : _status.Player1.Name,
            _status.Player2.HideName ? "匿名" : _status.Player2.Name);

        /// <summary>
        /// 取得圖片位址
        /// </summary>
        public (string, string) GetImagePath() => (_status.Player1.GetImagePath(), _status.Player2.GetImagePath());

        /// <summary>
        /// 取得角色資料(用於更新資訊)
        /// </summary>
        /// <returns></returns>
        public (Characters.TrustGameCharaters.TrustGameCharatersBase, Characters.TrustGameCharaters.TrustGameCharatersBase) GetPlayers() =>
            (_status.Player1, _status.Player2);
    }

    public enum EnumTrustGameType
    {
        Tutorial01 = 1,
        Tutorial02 = 2,
        Tutorial03 = 3,
        Tutorial04 = 4,
        Tutorial05 = 5,
        Tutorial06 = 6,
        Tutorial07 = 7,
        Tutorial08 = 8,
        Normal
    }
}