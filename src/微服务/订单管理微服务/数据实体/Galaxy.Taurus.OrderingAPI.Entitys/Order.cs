﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galaxy.Taurus.OrderingAPI.Entitys
{
    [Table("Order")]
    public class Order
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [Key]
        [MaxLength(32)]
        public string OrderId { get; set; }

        /// <summary>
        /// 店铺Id
        /// </summary>
        [MaxLength(32)]
        [Required]
        public string ShopId { get; set; }

        /// <summary>
        /// 会员Id
        /// </summary>
        [MaxLength(32)]
        [Required]
        public string MemberId { get; set; }

        /// <summary>
        /// 会员名
        /// </summary>
        [MaxLength(60)]
        [Required]
        public string MemberName { get; set; }

        /// <summary>
        /// 订单状态：0->待付款；1->待发货；2->已发货；3->已完成；4->已关闭；5->无效订单
        /// </summary>
        [Required]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        public DateTime? PaymentTime { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [Required]
        public double TotalAmount { get; set; }

        /// <summary>
        /// 订单实际支付金额
        /// </summary>
        [Required]
        public double PayAmount { get; set; }

        /// <summary>
        /// 送货人
        /// </summary>
        [Required]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 送货人联系电话
        /// </summary>
        [Required]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收货人邮编
        /// </summary>
        [Required]
        public string ReceiverCode { get; set; }

        /// <summary>
        /// 收货人地址—地区
        /// </summary>
        [Required]
        public string ReceiverRegion { get; set; }

        /// <summary>
        /// 收货人地址—详细地址
        /// </summary>
        [Required]
        public string ReceiverDetailAddresss { get; set; }
    }
}
