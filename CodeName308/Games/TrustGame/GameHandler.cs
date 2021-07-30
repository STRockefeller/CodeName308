using CodeName308.Characters.TrustGameCharaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Games.TrustGame
{
    class GameHandler
    {
        private int player1;
        private int player2;
        private int playerCount;

        /// <summary>
        /// 建構式傳入遊戲人數
        /// </summary>
        /// <param name="playerCount">參賽人數</param>
        public GameHandler(int playerCount)
        {
            player1 = 0;
            player2 = 1;
            this.playerCount = playerCount;
        }
        /// <summary>
        /// 取得下一場比賽的選手編號，回傳-1則沒有下一場。
        /// </summary>
        /// <returns></returns>
        public (int, int) Next()
        {
            if (player1 == -1) { return (-1, -1); }
            (int, int) res = (player1, player2);
            if (player2 < playerCount - 1)
                player2++;
            else if (player1 < playerCount - 2)
            {
                player1++;
                player2 = player1 + 1;
            }
            else //中止
            {
                player1 = -1;
                player2 = -1;
            }
            return res;
        }
    }
}
