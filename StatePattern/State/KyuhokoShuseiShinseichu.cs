using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatePattern.State
{
    /// <summary>
    /// 休講・補講　修正申請中
    /// </summary>
    public class KyuhokoShuseiShinseichu : IState
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KyuhokoShuseiShinseichu()
        {
        }
        #endregion

        /// <summary>
        /// 申請の登録
        /// </summary>
        public IState Shinsei()
        {
            return this;
        }

        /// <summary>
        /// 修正申請の登録
        /// </summary>
        public IState ShuseiShinsei()
        {
            return new KyuhokoShinseichu();
        }

        /// <summary>
        /// 承認の登録
        /// </summary>
        public IState Shonin()
        {
            return new KyuhokoShoninzumi();
        }

        /// <summary>
        /// 却下の登録
        /// </summary>
        public IState Kyakka()
        {
            return new KyuhokoKyakkazumi();
        }

        /// <summary>
        /// 取消の登録
        /// </summary>
        public IState Torikeshi()
        {
            return this;
        }
    }
}