using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatePattern.KyuhokoShinsei
{
    public class KyuhokoShinseiKbn
    {

    }

    /// <summary>
    /// 申請種別
    /// </summary>
    public class ShinseiKind
    {
        /// <summary>
        /// 休講・補講
        /// </summary>
        public const string Kyuhoko = "0";
        /// <summary>
        /// 休講
        /// </summary>
        public const string Kyuko = "1";
        /// <summary>
        /// 補講
        /// </summary>
        public const string Hoko = "2";
    }

    /// <summary>
    /// 申請区分
    /// </summary>
    public class ShinseiKbn
    {
        /// <summary>
        /// 新規申請
        /// </summary>
        public const string Shinki = "1";
        /// <summary>
        /// 修正申請
        /// </summary>
        public const string Shusei = "2";
        /// <summary>
        /// 補講日申請
        /// </summary>
        public const string Hokobi = "3";
        /// <summary>
        /// 取消申請
        /// </summary>
        public const string Torikeshi = "4";
    }

    /// <summary>
    /// 承認区分
    /// </summary>
    public class ShoninKbn
    {
        /// <summary>
        /// 申請中
        /// </summary>
        public const string ShinseiChu = "0";
        /// <summary>
        /// 承認
        /// </summary>
        public const string Shonin = "1";
        /// <summary>
        /// 却下
        /// </summary>
        public const string Kyakka = "2";
    }
}