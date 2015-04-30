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
	#region FINAccountFlowHistory
	/// <summary>
	/// This object represents the properties and navigation list of a FINAccountFlowHistory.
	/// </summary>
    [Serializable]
    [Table("FIN_AccountFlowHistory",PrimaryKeyColumn="FlowID")]
	public class FINAccountFlowHistory
	{
		
		public FINAccountFlowHistory()
		{
		}
        
        #region Public Properties
         
        [Column("FlowID")]
		public string FlowID
		{
			get;
            set;
		}
        
        [Column("FlowMoney")]
		public decimal FlowMoney
		{
			get;
			set;
		}

        [Column("FlowDate")]
		public DateTime FlowDate
		{
			get;
			set;
		}

        [Column("BankAccountID")]
		public string BankAccountID
		{
			get;
			set;
		}

        [Column("DeptID")]
		public string DeptID
		{
			get;
			set;
		}

        [Column("EmpID")]
		public string EmpID
		{
			get;
			set;
		}

        [Column("RecordDate")]
		public DateTime RecordDate
		{
			get;
			set;
		}

        [Column("RecordEmpID")]
		public string RecordEmpID
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

        [Column("PropertyID")]
		public string PropertyID
		{
			get;
			set;
		}

        [Column("BuyerName")]
		public string BuyerName
		{
			get;
			set;
		}

        [Column("BuyerIDCardNo")]
		public string BuyerIDCardNo
		{
			get;
			set;
		}

        [Column("SellerName")]
		public string SellerName
		{
			get;
			set;
		}

        [Column("SellerIDCardNo")]
		public string SellerIDCardNo
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

        [Column("PayerType")]
		public short? PayerType
		{
			get;
			set;
		}

        [Column("FlowDirection")]
		public short FlowDirection
		{
			get;
			set;
		}

        [Column("FlowType")]
		public short FlowType
		{
			get;
			set;
		}

        [Column("AccountType")]
		public short AccountType
		{
			get;
			set;
		}

        [Column("MoneyType")]
		public short MoneyType
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

        [Column("ApproveOpinion")]
		public string ApproveOpinion
		{
			get;
			set;
		}

        [Column("FlowFlag")]
		public short FlowFlag
		{
			get;
			set;
		}

        [Column("IsSystemGenerate")]
		public short IsSystemGenerate
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

        [Column("IsTransfered")]
		public short? IsTransfered
		{
			get;
			set;
		}

        [Column("IsUploadReceipt")]
		public short? IsUploadReceipt
		{
			get;
			set;
		}

        [Column("IsUploadIncome")]
		public short? IsUploadIncome
		{
			get;
			set;
		}

        [Column("IsNoReceipt")]
		public short? IsNoReceipt
		{
			get;
			set;
		}

        [Column("DepositDate")]
		public DateTime? DepositDate
		{
			get;
			set;
		}

        [Column("IsCheck")]
		public short IsCheck
		{
			get;
			set;
		}

        [Column("CheckEmpName")]
		public string CheckEmpName
		{
			get;
			set;
		}

        [Column("CheckTime")]
		public DateTime? CheckTime
		{
			get;
			set;
		}

        [Column("IsReCheck")]
		public short? IsReCheck
		{
			get;
			set;
		}

        [Column("ReCheckEmpName")]
		public string ReCheckEmpName
		{
			get;
			set;
		}

        [Column("ReCheckTime")]
		public DateTime? ReCheckTime
		{
			get;
			set;
		}

        [Column("IsLastConfirm")]
		public short? IsLastConfirm
		{
			get;
			set;
		}

        [Column("LastConfirmEmpName")]
		public string LastConfirmEmpName
		{
			get;
			set;
		}

        [Column("LastConfirmTime")]
		public DateTime? LastConfirmTime
		{
			get;
			set;
		}

        [Column("IsNeedSync")]
		public short? IsNeedSync
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

        [Column("ApproveEmpName")]
		public string ApproveEmpName
		{
			get;
			set;
		}

        [Column("Purpose")]
		public string Purpose
		{
			get;
			set;
		}

        [Column("AllocateStatus")]
		public short AllocateStatus
		{
			get;
			set;
		}

        [Column("ReceiptWay")]
		public short? ReceiptWay
		{
			get;
			set;
		}

        [Column("CheckCode")]
		public string CheckCode
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

        [Column("InvoiceCode")]
		public string InvoiceCode
		{
			get;
			set;
		}

        [Column("WaiyongReceiptCode")]
		public string WaiyongReceiptCode
		{
			get;
			set;
		}

        [Column("OtherReceiptCode")]
		public string OtherReceiptCode
		{
			get;
			set;
		}

        [Column("ReceiptID")]
		public Guid? ReceiptID
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

        [Column("OperateDateTime")]
		public DateTime? OperateDateTime
		{
			get;
			set;
		}

        [Column("SlotCardDept")]
		public string SlotCardDept
		{
			get;
			set;
		}

        [Column("LogNo")]
		public string LogNo
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

        [Column("CreateDate")]
		public DateTime CreateDate
		{
			get;
			set;
		}

        [Column("LastConfBankName")]
		public string LastConfBankName
		{
			get;
			set;
		}

        [Column("OldFlowID")]
		public string OldFlowID
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





