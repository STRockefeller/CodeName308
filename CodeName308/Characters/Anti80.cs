using CodeName308.Characters.TrustGameCharaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters
{
    class Anti80 : ICharacter
    {
        public TrustGameCharatersBase GetTrustGameCharaters() => new Anti80_TG();
    }
}
