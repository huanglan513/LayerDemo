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
	#region FINBackupMoneyBankAccount
	/// <summary>
	/// This object represents the properties and navigation list of a FINBackupMoneyBankAccount.
	/// </summary>
    [Serializable]
    [Table("FIN_BackupMoneyBankAccount")]
	public class FINBackupMoneyBankAccount
	{
		
		public FINBackupMoneyBankAccount()
		{
		}
        
        #region Public Properties
        
        [Column("AccountID")]
		public string AccountID
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

        [Column("LimitMoney")]
		public decimal LimitMoney
		{
			get;
			set;
		}

        [Column("OpeningBank")]
		public string OpeningBank
		{
			get;
			set;
		}

        [Column("BankAccountCode")]
		public string BankAccountCode
		{
			get;
			set;
		}

        [Column("IsValid")]
		public short IsValid
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

        [Column("moddate")]
		public DateTime moddate
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





