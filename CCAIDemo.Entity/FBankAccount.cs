/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:48
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region FBankAccount
	/// <summary>
	/// This object represents the properties and navigation list of a FBankAccount.
	/// </summary>
    [Serializable]
    [Table("F_BankAccount")]
	public class FBankAccount
	{
		
		public FBankAccount()
		{
		}
        
        #region Public Properties
        
        [Column("BankAccountID")]
		public Guid BankAccountID
		{
			get;
			set;
		}

        [Column("BankAccountName")]
		public string BankAccountName
		{
			get;
			set;
		}

        [Column("BankName")]
		public string BankName
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

        [Column("BankAccountType")]
		public short BankAccountType
		{
			get;
			set;
		}

        [Column("BankAccountCatalog")]
		public string BankAccountCatalog
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

        [Column("DelFlag")]
		public short DelFlag
		{
			get;
			set;
		}

        [Column("BankAccountNickName")]
		public string BankAccountNickName
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





