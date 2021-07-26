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

        public TrustGame(GameStatus status)
        {
            _status = status;
            ToPhase(EnumGamePhase.Match);
        }

        /// <summary>
        /// 進入指定階段
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
    }
}