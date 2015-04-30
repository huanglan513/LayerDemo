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
	#region FINInvoiceBook
	/// <summary>
	/// This object represents the properties and navigation list of a FINInvoiceBook.
	/// </summary>
    [Serializable]
    [Table("FIN_InvoiceBook")]
	public class FINInvoiceBook
	{
		
		public FINInvoiceBook()
		{
		}
        
        #region Public Properties
        
        [Column("BookID")]
		public Guid BookID
		{
			get;
			set;
		}

        [Column("BookCode")]
		public string BookCode
		{
			get;
			set;
		}

        [Column("MinNum")]
		public int MinNum
		{
			get;
			set;
		}

        [Column("MaxNum")]
		public int MaxNum
		{
			get;
			set;
		}

        [Column("FetchDeptID")]
		public string FetchDeptID
		{
			get;
			set;
		}

        [Column("FetchEmpID")]
		public string FetchEmpID
		{
			get;
			set;
		}

        [Column("DeliverDate")]
		public DateTime? DeliverDate
		{
			get;
			set;
		}

        [Column("DeliverEmpID")]
		public string DeliverEmpID
		{
			get;
			set;
		}

        [Column("CloseEmpID")]
		public string CloseEmpID
		{
			get;
			set;
		}

        [Column("CloseDate")]
		public DateTime? CloseDate
		{
			get;
			set;
		}

        [Column("BookType")]
		public short BookType
		{
			get;
			set;
		}

        [Column("BookFlag")]
		public short BookFlag
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

        [Column("BookNo")]
		public string BookNo
		{
			get;
			set;
		}

        [Column("PurchaseDate")]
		public DateTime? PurchaseDate
		{
			get;
			set;
		}

        [Column("CompanyName")]
		public string CompanyName
		{
			get;
			set;
		}

        [Column("District")]
		public string District
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

        [Column("CreatedBy")]
		public string CreatedBy
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

        [Column("IsDelivered")]
		public short IsDelivered
		{
			get;
			set;
		}

        [Column("IsRecycled")]
		public short IsRecycled
		{
			get;
			set;
		}

        [Column("RecycleDate")]
		public DateTime? RecycleDate
		{
			get;
			set;
		}

        [Column("RecycleBy")]
		public string RecycleBy
		{
			get;
			set;
		}

        [Column("IsCanceled")]
		public short IsCanceled
		{
			get;
			set;
		}

        [Column("CanceledBy")]
		public string CanceledBy
		{
			get;
			set;
		}

        [Column("CancelDate")]
		public DateTime? CancelDate
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





