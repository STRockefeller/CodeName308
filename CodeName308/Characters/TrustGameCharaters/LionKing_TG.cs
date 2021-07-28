using CodeName308.Games.TrustGame;
using CodeName308.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters.TrustGameCharaters
{
    class LionKing_TG:TrustGameCharatersBase
    {
        public LionKing_TG() : base()
        {
            InitName();
        }

        private void InitName()
        {
            Name = StorageHandler.NameStorage.LionKing;
        }

        public override string Description() => $"{Name}身為草原上的王者，令對手為牠的氣勢為之顫抖" +
            $"\r\n特性：與{Name}對局的對手，出錯機率暫時提高15%" +
            $"\r\nNPC邏輯：80%機率選擇合作，一旦遭受背叛則全部選擇背叛";

        public override GameStatus MatchingPhaseEffect(GameStatus status)
        {
            if (!PlayerNoInGame) { status.Player2.ErrorRate += 0.15; }
            else { status.Player1.ErrorRate += 0.15; }
            return status;
        }
        public override GameStatus EndPhaseEffect(GameStatus status)
        {
            if (!PlayerNoInGame) { status.Player2.ErrorRate -= 0.15; }
            else { status.Player1.ErrorRate -= 0.15; }
            return status;
        }

        public override EnumTrustGameStrategy NPCStrategy()
        {
            Random random = new Random();
            if (GameLog.Contains(EnumTrustGameStrategyResult.BB) || GameLog.Contains(EnumTrustGameStrategyResult.CB))
                return PickStrategy(EnumTrustGameStrategy.Betray);
            return PickStrategy(random.Next() % 100 < 80 ?
                EnumTrustGameStrategy.Cooperate : EnumTrustGameStrategy.Betray);
        }
    }
}
