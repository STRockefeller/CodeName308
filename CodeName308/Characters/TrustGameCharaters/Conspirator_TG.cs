using CodeName308.Games.TrustGame;
using CodeName308.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters.TrustGameCharaters
{
    class Conspirator_TG : TrustGameCharatersBase
    {
        public Conspirator_TG() : base()
        {
            InitName();
        }

        private void InitName()
        {
            Name = StorageHandler.NameStorage.Conspirator;
        }

        public override string Description() => $"{Name}笑裡藏刀，會在對手卸下心房時給予凌厲的一擊" +
            $"\r\n特性：{Name}在達成[背叛-合作]且上一回為[合作-合作]時獲得[+4]分數" +
            $"\r\nNPC邏輯：70%選擇合作，若上一回合為[合作-合作]則一定背叛";

        public override GameStatus ResultPhaseEffect(GameStatus status)
        {
            if (GameLog.Count < 2) { return status; }
            if (GameLog[GameLog.Count - 2] != EnumTrustGameStrategyResult.CC) { return status; }
            if (GameLog.Last() != EnumTrustGameStrategyResult.BC) { return status; }
            if (PlayerNoInGame) { status.Player2.Score += 4; }
            else { status.Player1.Score += 4; }
            return status;
        }
        public override EnumTrustGameStrategy NPCStrategy()
        {
            if (GameLog.Count > 0)
                if (GameLog.Last() == EnumTrustGameStrategyResult.CC)
                    return PickStrategy(EnumTrustGameStrategy.Betray);
            Random random = new Random();
            return PickStrategy(random.Next() % 100 < 70 ? EnumTrustGameStrategy.Cooperate : EnumTrustGameStrategy.Betray);
        }
    }
}
