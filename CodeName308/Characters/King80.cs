using CodeName308.Characters.TrustGameCharaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters
{
    class King80 : ICharacter
    {
        public TrustGameCharatersBase GetTrustGameCharaters() => new King80_TG();
    }
}
