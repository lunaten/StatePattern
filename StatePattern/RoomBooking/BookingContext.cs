using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatePattern.RoomBooking
{
    public class BookingContext
    {
        #region プロパティ
        /// <summary>
        /// 予約クラス
        /// </summary>
        private IBooking booking = null;
        /// <summary>
        /// 予約区分
        /// </summary>
        private string bookingKbn = null;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="kbn"></param>
        public BookingContext(string kbn)
        {
            if(booking == null)
            {
                //予約クラス生成
                switch (kbn)
                {
                    case BookingKbn.Kogi:   //講義
                        booking = new KogiBooking(null, null);
                        break;
                    case BookingKbn.Kyuko:  //休講
                        booking = new KyukoBooking();
                        break;
                    case BookingKbn.Hoko:   //補講
                        booking = new HokoBooking();
                        break;
                    case BookingKbn.Spot:   //スポット
                        booking = new SpotBooking();
                        break;
                }

                //予約区分のセット
                bookingKbn = kbn;
            }
        }
        #endregion

        /// <summary>
        /// データ取得
        /// </summary>
        public void GetData()
        {
            booking.GetData();
        }
        
        /// <summary>
        /// 予約のチェック
        /// </summary>
        public bool CheckBooking()
        {
            //予約の重複チェック
            if (!booking.CheckBooking())
            {
                Console.WriteLine("教室予約が既に登録されています。");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 予約の仮登録
        /// </summary>
        /// <returns></returns>
        public bool TempolaryRegist()
        {
            //予約の登録処理
            if (!booking.TempolaryRegist())
            {
                Console.WriteLine("教室予約の登録に失敗しました。");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 予約の登録
        /// </summary>
        public bool Regist()
        { 
            //予約の登録処理
            if(!booking.Regist())
            {
                Console.WriteLine("教室予約の登録に失敗しました。");
                return false;
            }

            return true;
        }
    }
}