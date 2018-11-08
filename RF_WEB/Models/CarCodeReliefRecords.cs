using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RF_WEB.Models
{
    /// <summary>
    /// 减免记录
    /// </summary>
    public class CarCodeReliefRecords
    {
        /// <summary>
        /// auto_increment
        /// </summary>
        public int RecordID
        {
            set; get;
        }
        /// <summary>
        /// 车牌号码
        /// </summary>
        public string CarCode
        {
            set; get;
        }
        /// <summary>
        /// 减免时间
        /// </summary>
        public int? ReliefHour
        {
            set; get;
        }
        /// <summary>
        /// 操作员
        /// </summary>
        public int? OperatorID
        {
            set; get;
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? OperationDate
        {
            set; get;
        }
        /// <summary>
        /// 减免使用时间
        /// </summary>
        public DateTime? RelifeDate
        {
            set; get;
        }
        /// <summary>
        /// 收费员ID
        /// </summary>
        public int? ChargeUserID
        {
            set; get;
        }
        /// <summary>
        /// 通道ID
        /// </summary>
        public int? ChannelID
        {
            set; get;
        }

        /// <summary>
        /// 有效开始时间
        /// </summary>
        public DateTime StartTime
        {
            set; get;
        }

        /// <summary>
        /// 有效结束时间
        /// </summary>
        public DateTime EndTime
        {
            set; get;
        }
        /// <summary>
        /// 进场时间
        /// </summary>
        public DateTime InTime
        {
            set; get;
        }

        public int MerchantType
        {
            set; get;
        }
    }
}