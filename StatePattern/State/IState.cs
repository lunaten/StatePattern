using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.State
{
    /// <summary>
    /// 休講補講　申請インターフェース
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 申請の登録
        /// </summary>
        IState Shinsei();
        /// <summary>
        /// 修正申請の登録
        /// </summary>
        IState ShuseiShinsei();
        /// <summary>
        /// 承認の登録
        /// </summary>
        IState Shonin();
        /// <summary>
        /// 却下の登録
        /// </summary>
        IState Kyakka();
        /// <summary>
        /// 取消の登録
        /// </summary>
        IState Torikeshi();
    }
}

       
