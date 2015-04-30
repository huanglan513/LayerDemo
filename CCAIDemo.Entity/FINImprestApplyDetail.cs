/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:50
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region FINImprestApplyDetail
	/// <summary>
	/// This object represents the properties and navigation list of a FINImprestApplyDetail.
	/// </summary>
    [Serializable]
    [Table("FIN_ImprestApplyDetail")]
	public class FINImprestApplyDetail
	{
		
		public FINImprestApplyDetail()
		{
		}
        
        #region Public Properties
        
        [Column("DataID")]
		public string DataID
		{
			get;
			set;
		}

        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("ImprestDate")]
		public DateTime? ImprestDate
		{
			get;
			set;
		}

        [Column("ImprestMoney")]
		public decimal ImprestMoney
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

        [Column("ReceiptWay")]
		public short ReceiptWay
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

        [Column("Remark")]
		public string Remark
		{
			get;
			set;
		}

        [Column("IsContract")]
		public short IsContract
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





