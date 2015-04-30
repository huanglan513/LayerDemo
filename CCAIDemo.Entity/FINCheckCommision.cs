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
	#region FINCheckCommision
	/// <summary>
	/// This object represents the properties and navigation list of a FINCheckCommision.
	/// </summary>
    [Serializable]
    [Table("FIN_CheckCommision")]
	public class FINCheckCommision
	{
		
		public FINCheckCommision()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("ReceivableCommision")]
		public decimal ReceivableCommision
		{
			get;
			set;
		}

        [Column("CommisionType")]
		public short CommisionType
		{
			get;
			set;
		}

        [Column("CheckCommision")]
		public decimal CheckCommision
		{
			get;
			set;
		}

        [Column("InvoiceNumber")]
		public string InvoiceNumber
		{
			get;
			set;
		}

        [Column("InvoiceMoney")]
		public string InvoiceMoney
		{
			get;
			set;
		}

        [Column("ArchiveFileNumber")]
		public string ArchiveFileNumber
		{
			get;
			set;
		}

        [Column("ReceiveCommType")]
		public short ReceiveCommType
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

        [Column("Currency")]
		public string Currency
		{
			get;
			set;
		}

        [Column("CheckDate")]
		public DateTime CheckDate
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

        [Column("ModDate")]
		public DateTime ModDate
		{
			get;
			set;
		}

        [Column("CheckBy")]
		public string CheckBy
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

        [Column("IsConfirm")]
		public short IsConfirm
		{
			get;
			set;
		}

        [Column("ConfirmEmpID")]
		public string ConfirmEmpID
		{
			get;
			set;
		}

        [Column("ConfirmTime")]
		public DateTime? ConfirmTime
		{
			get;
			set;
		}

        [Column("ConfirmRemark")]
		public string ConfirmRemark
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





