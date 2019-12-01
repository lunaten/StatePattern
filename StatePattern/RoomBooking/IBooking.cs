using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatePattern.RoomBooking
{
    /// <summary>
    /// 予約インターフェース
    /// </summary>
    public interface IBooking
    {
        /// <summary>
        /// 予約のデータ取得
        /// </summary>
        void GetData();

        /// <summary>
        /// 予約の重複チェック
        /// </summary>
        /// <returns></returns>
        bool CheckBooking();

        /// <summary>
        /// 予約の登録
        /// </summary>
        bool Regist();

        /// <summary>
        /// 予約の仮登録
        /// </summary>
        /// <returns></returns>
        bool TempolaryRegist();
    }

}