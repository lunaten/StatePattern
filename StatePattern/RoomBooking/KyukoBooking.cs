using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace StatePattern.RoomBooking
{
    /// <summary>
    /// 休講予約クラス
    /// </summary>
    public class KyukoBooking : IBooking
    {
        #region プロパティ
        /// <summary>
        /// 予約区分
        /// </summary>
        private const string bookingKbn = BookingKbn.Kyuko; //休講
        #endregion

        /// <summary>
        /// 休講予約コンストラクタ
        /// </summary>
        public KyukoBooking()
        {
        }

        /// <summary>
        /// 休講予約のデータ取得
        /// </summary>
        public void GetData()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine(" select * from IVF5030_ROOM ");
            sql.AppendFormat(" where BOOKING_KBN = '{0}' \n", bookingKbn);

            Console.WriteLine(sql);
        }

        /// <summary>
        /// 休講予約の重複チェック
        /// </summary>
        public bool CheckBooking()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("select * from IVF5030_ROOM ");
            sql.AppendLine("where DEL_FLG = '0' ");
            sql.AppendFormat("and BOOKING_KBN <> '{0}' \n", BookingKbn.Kyuko);  //休講以外            
            sql.AppendLine("and ROOM_CD = :ROOM_CD ");                          //教室が同一
            sql.AppendLine("and START_DATE <= :TARGET_DATE ");                  //日付が開始日以降
            sql.AppendLine("and START_TIME <= :TARGET_TIME ");                  //時間が開始時間以降
            sql.AppendLine("and END_DATE >= :TARGET_DATE ");                    //日付が終了日以内
            sql.AppendLine("and END_TIME >= :TARGET_TIME ");                    //時間が終了時間以内

            Console.WriteLine(sql);

            //データが存在した場合
            if (sql.Length > 0)
            {
                return false;   //NG：重複あり
            }
            else
            {
                return true;    //OK：重複なし
            }
        }

        /// <summary>
        /// 休講予約の仮登録
        /// </summary>
        public bool TempolaryRegist()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("insert into IVF5030_ROOM ( ");
            sql.AppendLine("     BOOKING_ID ");
            sql.AppendLine("    ,BOOKING_KBN ");
            sql.AppendLine("    ,BOOKING_STATE ");
            sql.AppendLine("    ,ROOM_CD ");
            sql.AppendLine("    ,START_DATE ");
            sql.AppendLine("    ,START_TIME ");
            sql.AppendLine("    ,END_DATE ");
            sql.AppendLine("    ,END_TIME ");
            sql.AppendLine(") values ( ");
            sql.AppendLine("     :BOOKING_ID ");
            sql.AppendLine("    ,'" + BookingKbn.Kyuko + "'");
            sql.AppendLine("    ,'" + BookingState.YoyakuChu + "'");
            sql.AppendLine("    ,:ROOM_CD ");
            sql.AppendLine("    ,:START_DATE ");
            sql.AppendLine("    ,:START_TIME ");
            sql.AppendLine("    ,:END_DATE ");
            sql.AppendLine("    ,:END_TIME ");
            sql.AppendLine("); ");

            Console.WriteLine(sql);

            return true;
        }

        /// <summary>
        /// 休講予約の登録
        /// </summary>
        public bool Regist()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("update IVF5030_ROOM set ( ");
            sql.AppendLine("     BOOKING_KBN    = :'" + BookingKbn.Kyuko + "'");
            sql.AppendLine("    ,BOOKING_STATE  = :'" + BookingState.YoyakuZumi + "'");
            sql.AppendLine("    ,ROOM_CD        = :ROOM_CD  ");
            sql.AppendLine("    ,START_DATE     = :START_DATE  ");
            sql.AppendLine("    ,START_TIME     = :START_TIME  ");
            sql.AppendLine("    ,END_DATE       = :END_DATE  ");
            sql.AppendLine("    ,END_TIME       = :END_TIME  ");
            sql.AppendLine("where ");
            sql.AppendLine("     BOOKING_ID     = :BOOKING_ID ");
            Console.WriteLine(sql);

            return true;
        }

        /// <summary>
        /// 新規申請
        /// </summary>
        public void Shinsei()
        {
        }
    }
}
