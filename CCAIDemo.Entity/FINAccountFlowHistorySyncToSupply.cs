/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:49
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region FINAccountFlowHistorySyncToSupply
	/// <summary>
	/// This object represents the properties and navigation list of a FINAccountFlowHistorySyncToSupply.
	/// </summary>
    [Serializable]
    [Table("FIN_AccountFlowHistorySyncToSupply",PrimaryKeyColumn="ItemID")]
	public class FINAccountFlowHistorySyncToSupply
	{
		
		public FINAccountFlowHistorySyncToSupply()
		{
		}
        
        #region Public Properties
         
        [Column("ItemID")]
		public Guid ItemID
		{
			get;
            set;
		}
        
        [Column("FlowID")]
		public Guid FlowID
		{
			get;
			set;
		}

        [Column("BianHao")]
		public string BianHao
		{
			get;
			set;
		}

        [Column("Building")]
		public string Building
		{
			get;
			set;
		}

        [Column("Department")]
		public string Department
		{
			get;
			set;
		}

        [Column("Happen_Date")]
		public DateTime? Happen_Date
		{
			get;
			set;
		}

        [Column("if_in")]
		public short? if_in
		{
			get;
			set;
		}

        [Column("DingJinVoucher")]
		public string DingJinVoucher
		{
			get;
			set;
		}

        [Column("waiyongvoucher")]
		public string waiyongvoucher
		{
			get;
			set;
		}

        [Column("invoice")]
		public string invoice
		{
			get;
			set;
		}

        [Column("othervoucher")]
		public string othervoucher
		{
			get;
			set;
		}

        [Column("tran_type")]
		public string tran_type
		{
			get;
			set;
		}

        [Column("purpose_name")]
		public string purpose_name
		{
			get;
			set;
		}

        [Column("cashe_anme")]
		public string cashe_anme
		{
			get;
			set;
		}

        [Column("curry")]
		public decimal? curry
		{
			get;
			set;
		}

        [Column("bank_name")]
		public string bank_name
		{
			get;
			set;
		}

        [Column("money_name")]
		public string money_name
		{
			get;
			set;
		}

        [Column("buy_name")]
		public string buy_name
		{
			get;
			set;
		}

        [Column("buy_cate")]
		public string buy_cate
		{
			get;
			set;
		}

        [Column("buy_tel")]
		public string buy_tel
		{
			get;
			set;
		}

        [Column("sale_name")]
		public string sale_name
		{
			get;
			set;
		}

        [Column("sale_cate")]
		public string sale_cate
		{
			get;
			set;
		}

        [Column("sale_tel")]
		public string sale_tel
		{
			get;
			set;
		}

        [Column("account")]
		public string account
		{
			get;
			set;
		}

        [Column("rec_name")]
		public string rec_name
		{
			get;
			set;
		}

        [Column("memo")]
		public string memo
		{
			get;
			set;
		}

        [Column("Moddate")]
		public DateTime? Moddate
		{
			get;
			set;
		}

        [Column("IsSync")]
		public short? IsSync
		{
			get;
			set;
		}

        [Column("SyncTime")]
		public DateTime? SyncTime
		{
			get;
			set;
		}

        [Column("Voucher_Date")]
		public DateTime? Voucher_Date
		{
			get;
			set;
		}

        [Column("RecordDate")]
		public DateTime? RecordDate
		{
			get;
			set;
		}

        [Column("ReceiptWay")]
		public short ReceiptWay
		{
			get;
			set;
		}

        [Column("approveDate")]
		public DateTime? approveDate
		{
			get;
			set;
		}

        [Column("approveempname")]
		public string approveempname
		{
			get;
			set;
		}

        [Column("PosFee")]
		public decimal? PosFee
		{
			get;
			set;
		}
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





