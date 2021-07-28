using CodeName308.Games.TrustGame;
using CodeName308.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters.TrustGameCharaters
{
    class Anti80_TG:TrustGameCharatersBase
    {
        public Anti80_TG() : base()
        {
            InitName();
        }

        private void InitName()
        {
            Name = StorageHandler.NameStorage.Anti80;
        }

        public override string Description() => $"{Name}召開反80委員會制裁欺負弱小的人，單方面被背叛時可以減少損失" +
            $"\r\n特性[1]：{Name}在達成[合作-背叛]時" +
            $"\r\n自己獲得[+1]分數，對手獲得[-1]分數" +
            $"\r\n特性[2]：{Name}在達成[合作-背叛]且對手為{StorageHandler.NameStorage.King80}時" +
            $"\r\n自己獲得[+4]分數，對手獲得[-8]分數" +
            $"\r\nNPC邏輯：70%機率選擇合作";

        public override GameStatus ResultPhaseEffect(GameStatus status)
        {
            if (GameLog.Last() != EnumTrustGameStrategyResult.CB) { return status; }
            if (!PlayerNoInGame)
            {
                if(status.Player2.Name==StorageHandler.NameStorage.King80)
                {
                    status.Player1.Score += 4;
                    status.Player2.Score -= 8;
                }
                else
                {
                    status.Player1.Score += 1;
                    status.Player2.Score -= 1;
                }
            }
            else
            {
                if (status.Player1.Name == StorageHandler.NameStorage.King80)
                {
                    status.Player2.Score += 4;
                    status.Player1.Score -= 8;
                }
                else
                {
                    status.Player2.Score += 1;
                    status.Player1.Score -= 1;
                }
            }
            return status;
        }
        public override EnumTrustGameStrategy NPCStrategy()
        {
            Random random = new Random();
            return PickStrategy(random.Next() % 100 < 70 ?
                EnumTrustGameStrategy.Cooperate : EnumTrustGameStrategy.Betray);
        }
    }
}
