/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:51
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region FINInvoicingApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINInvoicingApply.
	/// </summary>
    [Serializable]
    [Table("FIN_InvoicingApply",PrimaryKeyColumn="ItemID")]
	public class FINInvoicingApply
	{
		
		public FINInvoicingApply()
		{
		}
        
        #region Public Properties
         
        [Column("ItemID")]
		public string ItemID
		{
			get;
            set;
		}
        
        [Column("AccountFlowID")]
		public string AccountFlowID
		{
			get;
			set;
		}

        [Column("ContractID")]
		public string ContractID
		{
			get;
			set;
		}

        [Column("ApplyDeptID")]
		public string ApplyDeptID
		{
			get;
			set;
		}

        [Column("ApplyEmpID")]
		public string ApplyEmpID
		{
			get;
			set;
		}

        [Column("InvoiceTitle")]
		public string InvoiceTitle
		{
			get;
			set;
		}

        [Column("InvoiceMoney")]
		public decimal InvoiceMoney
		{
			get;
			set;
		}

        [Column("InvoiceType")]
		public string InvoiceType
		{
			get;
			set;
		}

        [Column("InvoiceCode")]
		public string InvoiceCode
		{
			get;
			set;
		}

        [Column("FlowDate")]
		public DateTime? FlowDate
		{
			get;
			set;
		}

        [Column("PreFetchDate")]
		public DateTime? PreFetchDate
		{
			get;
			set;
		}

        [Column("ApproveEmpID")]
		public string ApproveEmpID
		{
			get;
			set;
		}

        [Column("ApproveDate")]
		public DateTime? ApproveDate
		{
			get;
			set;
		}

        [Column("FetchDate")]
		public DateTime? FetchDate
		{
			get;
			set;
		}

        [Column("FetchMan")]
		public string FetchMan
		{
			get;
			set;
		}

        [Column("InvoiceFlag")]
		public short InvoiceFlag
		{
			get;
			set;
		}

        [Column("DelFlag")]
		public short? DelFlag
		{
			get;
			set;
		}

        [Column("PayerName")]
		public string PayerName
		{
			get;
			set;
		}

        [Column("PayerIDCard")]
		public string PayerIDCard
		{
			get;
			set;
		}

        [Column("PayerTel")]
		public string PayerTel
		{
			get;
			set;
		}

        [Column("PayerAddr")]
		public string PayerAddr
		{
			get;
			set;
		}

        [Column("PayerZipCode")]
		public string PayerZipCode
		{
			get;
			set;
		}

        [Column("Remark")]
		public string Remark
		{
			get;
			set;
		}

        [Column("ApplyDate")]
		public DateTime? ApplyDate
		{
			get;
			set;
		}

        [Column("ReceiptID")]
		public string ReceiptID
		{
			get;
			set;
		}

        [Column("ReceiptCode")]
		public string ReceiptCode
		{
			get;
			set;
		}

        [Column("RejectReason")]
		public string RejectReason
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





