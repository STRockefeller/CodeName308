using CodeName308.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Characters.TrustGameCharaters
{
    public class User_TG : TrustGameCharatersBase
    {
        public User_TG() : base()
        {
            InitName();
        }

        private void InitName()
        {
            Name = StorageHandler.NameStorage.User;
        }

        public override string Description() => $"{Name}是一個平凡人沒有任何特殊能力" +
            $"\r\nNPC邏輯:選擇合作或背叛的機率各為50%";
    }
}