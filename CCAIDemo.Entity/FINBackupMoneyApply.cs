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
	#region FINBackupMoneyApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINBackupMoneyApply.
	/// </summary>
    [Serializable]
    [Table("FIN_BackupMoneyApply")]
	public class FINBackupMoneyApply
	{
		
		public FINBackupMoneyApply()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("BankAccountDeptID")]
		public string BankAccountDeptID
		{
			get;
			set;
		}

        [Column("AccountID")]
		public string AccountID
		{
			get;
			set;
		}

        [Column("ApplyFlag")]
		public short ApplyFlag
		{
			get;
			set;
		}

        [Column("ApplyDate")]
		public DateTime ApplyDate
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

        [Column("Remark")]
		public string Remark
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

        [Column("Purpose")]
		public string Purpose
		{
			get;
			set;
		}

        [Column("OtherPurpose")]
		public string OtherPurpose
		{
			get;
			set;
		}

        [Column("IsPayEarnest")]
		public short IsPayEarnest
		{
			get;
			set;
		}

        [Column("QueryDocument")]
		public string QueryDocument
		{
			get;
			set;
		}

        [Column("CertDelivered")]
		public short CertDelivered
		{
			get;
			set;
		}

        [Column("NewPropertyCert")]
		public short NewPropertyCert
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

        [Column("OtherReceiptCode")]
		public string OtherReceiptCode
		{
			get;
			set;
		}

        [Column("TotalMoney")]
		public decimal TotalMoney
		{
			get;
			set;
		}

        [Column("CapitalMoney")]
		public string CapitalMoney
		{
			get;
			set;
		}

        [Column("ModDate")]
		public DateTime ModDate
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





