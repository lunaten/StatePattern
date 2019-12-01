using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatePattern.State
{
    /// <summary>
    /// 休講・補講　取消済
    /// </summary>
    public class KyuhokoTorikeshizumi: IState
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KyuhokoTorikeshizumi()
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
            return this;
        }

        /// <summary>
        /// 承認の登録
        /// </summary>
        public IState Shonin()
        {
            return this;
        }

        /// <summary>
        /// 却下の登録
        /// </summary>
        public IState Kyakka()
        {
            return this;
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