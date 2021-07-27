using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeName308.Games.TrustGame;
using CodeName308.Storage;

namespace CodeName308.Characters.TrustGameCharaters
{
    public class Betrayer_TG : TrustGameCharatersBase
    {
        public Betrayer_TG() : base()
        {
            InitName();
        }

        private void InitName()
        {
            Name = StorageHandler.NameStorage.Betrayer;
        }

        public override string Description() => $"{Name}在達成[背叛-合作]時獲得[+1]分數" +
            $"\r\nNPC邏輯：全部選擇背叛";

        public override GameStatus ResultPhaseEffect(GameStatus status)
        {
            if (GameLog.Last() != EnumTrustGameStrategyResult.BC) { return status; }
            if (PlayerNoInGame) { status.Player2.Score++; }
            else { status.Player1.Score++; }
            return status;
        }
        public override EnumTrustGameStrategy NPCStrategy() => PickStrategy(EnumTrustGameStrategy.Betray);
    }
}