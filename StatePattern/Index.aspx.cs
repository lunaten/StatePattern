using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StatePattern.RoomBooking;
using StatePattern.KyuhokoShinsei;

namespace StatePattern
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 予約ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lnkBtnBooking_Click(object sender, EventArgs e)
        {
            //選択条件の取得
            string bookingKbn = rbBookingKbn.SelectedValue; //予約区分
            
            //予約クラスの生成
            BookingContext Booking = new BookingContext(bookingKbn);


            ////申請の登録
            //ShinseiContext Kyuhoko = new ShinseiContext(bookingKbn, shinseiKbn);
            //if(Kyuhoko.Shinsei())
            //{
            //    Console.WriteLine("休補講の申請が完了しました。");
            //}

            ////仮予約の登録
            //if (Booking.TempolaryRegist())
            //{

            //}
            ////予約の登録
            //if (Booking.Regist())
            //{
            //    Console.WriteLine("教室予約の登録が完了しました。");
            //}

        }

        /// <summary>
        /// 申請ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lnkBtnShinsei_Click(object sender, EventArgs e)
        {
            //選択条件の取得
            string shinseiKind = rbShinseiKind.SelectedValue;   //申請種別
            string shinseiKbn = rbShinseiKbn.SelectedValue;     //申請区分

            ////申請の登録
            //ShinseiContext Kyuhoko = new ShinseiContext(shinseiKind, shinseiKbn);

            //if (Kyuhoko.Shinsei())
            //{
            //    Console.WriteLine("休補講の申請が完了しました。");
            //}

            ////仮予約の登録
            //if (Booking.TempolaryRegist())
            //{

            //}
            ////予約の登録
            //if (Booking.Regist())
            //{
            //    Console.WriteLine("教室予約の登録が完了しました。");
            //}
        }
    }
}