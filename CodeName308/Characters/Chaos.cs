using CodeName308.Characters.TrustGameCharaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters
{
    class Chaos : ICharacter
    {
        public TrustGameCharatersBase GetTrustGameCharaters() => new Chaos_TG();
    }
}
