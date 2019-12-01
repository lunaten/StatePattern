//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace StatePattern.KyuhokoShinsei
//{
//    public class ShinseiContext
//    {
//        #region プロパティ
//        /// <summary>
//        /// 予約クラス
//        /// </summary>
//        private IShinsei kyuhokoShinsei = null;
//        /// <summary>
//        /// 申請区分
//        /// </summary>
//        private string shinseiKbn = null;
//        #endregion
//        private string shinseiState = null;
//        #region コンストラクタ
//        /// <summary>
//        /// コンストラクタ
//        /// </summary>
//        /// <param name="kbn"></param>
//        public ShinseiContext(string kind, string state)
//        {
//            if(kyuhokoShinsei == null)
//            {
//                //申請クラス生成
//                switch (kind)
//                {
//                    case ShinseiKind.Kyuhoko:     //休講・補講
//                        kyuhokoShinsei = new KyuhokoShinsei(kind, state);
//                        break;
//                    //case ShinseiKind.Shusei:     //修正
//                    //    kyuhokoShinsei = new KyukoBooking();
//                    //    break;
//                    //case ShinseiKbn.Hokobi:     //補講日
//                    //    kyuhokoShinsei = new HokoBooking();
//                    //    break;
//                    //case ShinseiKbn.Torikeshi:  //取消
//                    //    kyuhokoShinsei = new SpotBooking();
//                    //    break;
//                }

//                //申請区分のセット
//                shinseiKbn = kbn;
//                //申請状態のセット
//                shinseiState = state;
//            }
//        }
//        #endregion

//        /// <summary>
//        /// 新規申請　申請の登録
//        /// </summary>
//        public bool Shinsei()
//        {
//            return kyuhokoShinsei.Shinsei();
//        }

//        /// <summary>
//        /// 新規申請　承認の登録
//        /// </summary>
//        public void Shonin()
//        {

//            kyuhokoShinsei.Shonin();
//        }

//        /// <summary>
//        /// 新規申請　却下の登録
//        /// </summary>
//        public void Kyakka()
//        {

//            kyuhokoShinsei.Kyakka();
//        }

//        /// <summary>
//        /// 新規申請　取消の登録
//        /// </summary>
//        public void Torikeshi()
//        {

//            kyuhokoShinsei.Torikeshi();
//        }
//    }
//}