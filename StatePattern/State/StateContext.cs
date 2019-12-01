using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatePattern.State
{
    public class StateContext
    {
        #region プロパティ
        /// <summary>
        /// 予約クラス
        /// </summary>
        private IState state = null;
        #endregion
        
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="kbn"></param>
        public StateContext()
        {
            if(state == null)
            {
                state = new KyuhokoMiShinsei();
            }
        }
        #endregion

        /// <summary>
        /// 新規申請　申請の登録
        /// </summary>
        public void Shinsei()
        {
            this.state = this.state.Shinsei();
        }

        /// <summary>
        /// 新規申請　承認の登録
        /// </summary>
        public void Shonin()
        {
            this.state = this.state.Shonin();
        }

        /// <summary>
        /// 新規申請　却下の登録
        /// </summary>
        public void Kyakka()
        {
            this.state = this.state.Kyakka();
        }

        /// <summary>
        /// 新規申請　取消の登録
        /// </summary>
        public void Torikeshi()
        {
            this.state = this.state.Torikeshi();
        }
    }
}