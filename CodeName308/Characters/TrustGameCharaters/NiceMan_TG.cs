using CodeName308.Games.TrustGame;
using CodeName308.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters.TrustGameCharaters
{
    class NiceMan_TG:TrustGameCharatersBase
    {
        public NiceMan_TG() : base()
        {
            InitName();
        }

        private void InitName()
        {
            Name = StorageHandler.NameStorage.NiceMan;
        }

        public override string Description() => $"{Name}心地善良不會排擠任何人" +
            $"\r\n特性：{Name}在達成[合作-合作]時獲得[+1]分數" +
            $"\r\nNPC邏輯：全部選擇合作";

        public override GameStatus ResultPhaseEffect(GameStatus status)
        {
            if (GameLog.Last() != EnumTrustGameStrategyResult.CC) { return status; }
            if (PlayerNoInGame) { status.Player2.Score++; }
            else { status.Player1.Score++; }
            return status;
        }
        public override EnumTrustGameStrategy NPCStrategy() => PickStrategy(EnumTrustGameStrategy.Cooperate);
    }
}
