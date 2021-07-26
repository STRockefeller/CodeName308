using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeName308.Text
{
    interface IArticle
    {
        /// <summary>
        /// 顯示當前文章
        /// </summary>
        /// <returns></returns>
        public string Show();
        /// <summary>
        /// 顯示下一篇文章
        /// </summary>
        /// <returns></returns>
        public string Next();
        /// <summary>
        /// 顯示上一篇文章
        /// </summary>
        /// <returns></returns>
        public string Previous();
    }
}
