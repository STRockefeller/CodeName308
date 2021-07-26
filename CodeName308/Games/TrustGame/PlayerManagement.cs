using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeName308.Characters.TrustGameCharaters;

namespace CodeName308.Games.TrustGame
{
    /// <summary>
    /// 參賽者管理
    /// </summary>
    public class PlayerManagement
    {
        public List<TrustGameCharatersBase> Players;
        private GameSetting _setting;

        /// <summary>
        /// 建構式，初始化玩家清單
        /// </summary>
        public PlayerManagement()
        {
            _setting = new GameSetting();
            _setting.UseDefault();
            Players = new List<TrustGameCharatersBase>();
        }

        /// <summary>
        /// 建構式，包含GameSetting物件
        /// </summary>
        /// <param name="setting"></param>
        public PlayerManagement(GameSetting setting)
        {
            _setting = setting;
            Players = new List<TrustGameCharatersBase>();
        }

        /// <summary>
        /// 加入玩家
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(TrustGameCharatersBase player)
        {
            player.Score = _setting.InitScore;
            player.ErrorRate = _setting.ErrorRate;
            player.Playable = true;
            Players.Add(player);
        }

        /// <summary>
        /// 加入NPC(隱藏身分)
        /// </summary>
        /// <param name="player"></param>
        public void AddNPC(TrustGameCharatersBase player)
        {
            player.Score = _setting.InitScore;
            player.ErrorRate = _setting.ErrorRate;
            player.HideName = true;
            Players.Add(player);
        }

        /// <summary>
        /// 更新玩家資訊
        /// </summary>
        /// <param name="index">位置</param>
        /// <param name="player">新的角色物件</param>
        public void UpdatePlayer(int index, TrustGameCharatersBase player)
        {
            Players.RemoveAt(index);
            Players.Insert(index, player);
        }
    }
}