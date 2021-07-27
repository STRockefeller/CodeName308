using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeName308.Characters.TrustGameCharaters;

namespace CodeName308.Characters
{
    public interface ICharacter
    {
        /// <summary>
        /// 回傳TrustGame用的角色資料
        /// </summary>
        /// <returns></returns>
        public TrustGameCharatersBase GetTrustGameCharaters();
    }}