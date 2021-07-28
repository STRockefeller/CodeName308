using CodeName308.Games.TrustGame;
using CodeName308.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters.TrustGameCharaters
{
    class Chaos_TG:TrustGameCharatersBase
    {
        public Chaos_TG() : base()
        {
            InitName();
        }

        private void InitName()
        {
            Name = StorageHandler.NameStorage.Chaos;
        }

        public override string Description() => $"{Name}唯恐天下不亂" +
            $"\r\n特性：雙方的失誤率增加25%"+
            $"\r\nNPC邏輯：選擇合作或背叛的機率各為50%";
        public override GameStatus MatchingPhaseEffect(GameStatus status)
        {
            status.Player1.ErrorRate += 0.25;
            status.Player2.ErrorRate += 0.25;
            return status;
        }
        public override GameStatus EndPhaseEffect(GameStatus status)
        {
            status.Player1.ErrorRate -= 0.25;
            status.Player2.ErrorRate -= 0.25;
            return status;
        }
    }
}
