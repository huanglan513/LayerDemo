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
	#region FINCommisionTransferApplyDetail
	/// <summary>
	/// This object represents the properties and navigation list of a FINCommisionTransferApplyDetail.
	/// </summary>
    [Serializable]
    [Table("FIN_CommisionTransferApplyDetail")]
	public class FINCommisionTransferApplyDetail
	{
		
		public FINCommisionTransferApplyDetail()
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

        [Column("TransferDate")]
		public DateTime? TransferDate
		{
			get;
			set;
		}

        [Column("TransferMoney")]
		public decimal TransferMoney
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

        [Column("TransferDeptID")]
		public string TransferDeptID
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





