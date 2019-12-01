using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.KyuhokoShinsei
{
    /// <summary>
    /// 休講補講　申請インターフェース
    /// </summary>
    interface IShinsei
    {
        /// <summary>
        /// 申請の登録
        /// </summary>
        bool Shinsei();
        /// <summary>
        /// 承認の登録
        /// </summary>
        void Shonin();
        /// <summary>
        /// 却下の登録
        /// </summary>
        void Kyakka();
        /// <summary>
        /// 取消の登録
        /// </summary>
        void Torikeshi();
    }
}

       
