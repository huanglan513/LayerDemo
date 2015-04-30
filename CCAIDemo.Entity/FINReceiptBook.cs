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
	#region FINReceiptBook
	/// <summary>
	/// This object represents the properties and navigation list of a FINReceiptBook.
	/// </summary>
    [Serializable]
    [Table("FIN_ReceiptBook")]
	public class FINReceiptBook
	{
		
		public FINReceiptBook()
		{
		}
        
        #region Public Properties
        
        [Column("BookID")]
		public string BookID
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

        [Column("FetchEmpName")]
		public string FetchEmpName
		{
			get;
			set;
		}

        [Column("DeliverDate")]
		public DateTime DeliverDate
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





