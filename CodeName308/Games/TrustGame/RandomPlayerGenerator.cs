using CodeName308.Characters.TrustGameCharaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Games.TrustGame
{
    class RandomPlayerGenerator
    {
        /// <summary>
        /// 產生指定人數的隨機參賽者(不包含user)
        /// </summary>
        /// <param name="amount">人數</param>
        /// <returns></returns>
        public static IEnumerable<TrustGameCharatersBase> Generate(int amount)
        {
            for (int i = 0; i < amount; i++)
                yield return GetRandomPlayer();
        }
        /// <summary>
        /// 若有新增角色需要修改這個方法
        /// </summary>
        /// <returns></returns>
        private static TrustGameCharatersBase GetRandomPlayer()
        {
            Random random = new Random();
            return (random.Next() % 7) switch
            {
                0 => new Anti80_TG(),
                1 => new Betrayer_TG(),
                2 => new Chaos_TG(),
                3 => new Conspirator_TG(),
                4 => new King80_TG(),
                5 => new LionKing_TG(),
                6 => new NiceMan_TG(),
                //理論上不會進來
                _ => new User_TG(),
            };
        }
    }
}
