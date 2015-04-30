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
	#region FINCheckCommisionInvoice
	/// <summary>
	/// This object represents the properties and navigation list of a FINCheckCommisionInvoice.
	/// </summary>
    [Serializable]
    [Table("FIN_CheckCommisionInvoice")]
	public class FINCheckCommisionInvoice
	{
		
		public FINCheckCommisionInvoice()
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

        [Column("InvoiceID")]
		public string InvoiceID
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

        [Column("ModDate")]
		public DateTime ModDate
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





