using CodeName308.Games.TrustGame;
using CodeName308.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters.TrustGameCharaters
{
    class King80_TG:TrustGameCharatersBase
    {
        public King80_TG() : base()
        {
            InitName();
        }

        private void InitName()
        {
            Name = StorageHandler.NameStorage.King80;
        }

        public override string Description() => $"{Name}喜歡對弱小的同學開玩笑" +
            $"\r\n特性：{Name}在對局結束時會淘汰分數小於0的對手" +
            $"\r\nNPC邏輯：70%選擇背叛";

        public override GameStatus EndPhaseEffect(GameStatus status)
        {
            if(!PlayerNoInGame)
                status.Player2.IsDefeated = status.Player2.Score <= 0 ? true : false;
            else
                status.Player1.IsDefeated = status.Player1.Score <= 0 ? true : false;
            return status;
        }
        public override EnumTrustGameStrategy NPCStrategy()
        {
            Random random = new Random();
            return PickStrategy(random.Next() % 100 < 70 ?
                EnumTrustGameStrategy.Betray : EnumTrustGameStrategy.Cooperate);
        }
    }
}
