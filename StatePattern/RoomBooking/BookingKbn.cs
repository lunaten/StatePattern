using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatePattern.RoomBooking
{
    /// <summary>
    /// 予約区分
    /// </summary>
    public class BookingKbn
    {
        /// <summary>
        /// 講義
        /// </summary>
        public const string Kogi = "0";
        /// <summary>
        /// 休講
        /// </summary>
        public const string Kyuko = "1";
        /// <summary>
        /// 補講
        /// </summary>
        public const string Hoko = "2";
        /// <summary>
        /// スポット
        /// </summary>
        public const string Spot = "3";
    }

    /// <summary>
    /// 予約状態
    /// </summary>
    public class BookingState
    {
        /// <summary>
        /// 予約済み
        /// </summary>
        public const string YoyakuZumi = "1";
        /// <summary>
        /// 予約中
        /// </summary>
        public const string YoyakuChu = "0";
        /// <summary>
        /// 却下
        /// </summary>
        public const string Kyakka = "-1";
        /// <summary>
        /// 却下中
        /// </summary>
        public const string KyakkaChu = "-2";
    }
}
