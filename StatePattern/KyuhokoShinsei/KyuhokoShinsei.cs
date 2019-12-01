//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace StatePattern.KyuhokoShinsei
//{
//    /// <summary>
//    /// 新規申請クラス
//    /// </summary>
//    public class ShinkiShinsei : IKyuhokoShinsei
//    {
//        #region プロパティ
//        /// <summary>
//        /// 申請状態
//        /// </summary>
//        private string reqState = null;
//        #endregion

//        #region コンストラクタ
//        /// <summary>
//        /// 新規申請　コンストラクタ
//        /// </summary>
//        public ShinkiShinsei(string kbn, string state)
//        {
//            if (reqState == null)
//            {
//                reqState = state;
//            }
//        }
//        #endregion

//        /// <summary>
//        /// 新規申請　申請の登録
//        /// </summary>
//        public bool Shinsei()
//        {
            
//            return true;
//        }

//        /// <summary>
//        /// 新規申請　承認の登録
//        /// </summary>
//        public void Shonin()
//        {

//        }

//        /// <summary>
//        /// 新規申請　却下の登録
//        /// </summary>
//        public void Kyakka()
//        {

//        }

//        /// <summary>
//        /// 新規申請　取消の登録
//        /// </summary>
//        public void Torikeshi()
//        {

//        }
//    }
//}