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
	#region FINReceipt
	/// <summary>
	/// This object represents the properties and navigation list of a FINReceipt.
	/// </summary>
    [Serializable]
    [Table("FIN_Receipt")]
	public class FINReceipt
	{
		
		public FINReceipt()
		{
		}
        
        #region Public Properties
        
        [Column("ReceiptID")]
		public string ReceiptID
		{
			get;
			set;
		}

        [Column("BookID")]
		public string BookID
		{
			get;
			set;
		}

        [Column("ReceiptNo")]
		public int ReceiptNo
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

        [Column("ContractID")]
		public string ContractID
		{
			get;
			set;
		}

        [Column("AccountFlowID")]
		public string AccountFlowID
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

        [Column("DeptID")]
		public string DeptID
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

        [Column("PayerName")]
		public string PayerName
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

        [Column("ReceiptDate")]
		public DateTime? ReceiptDate
		{
			get;
			set;
		}

        [Column("ReceiptFlag")]
		public short? ReceiptFlag
		{
			get;
			set;
		}

        [Column("RecordDate")]
		public DateTime? RecordDate
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

        [Column("CustomerPageFlag")]
		public short? CustomerPageFlag
		{
			get;
			set;
		}

        [Column("LostReason")]
		public string LostReason
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

        [Column("ReceiptCloseFlag")]
		public short ReceiptCloseFlag
		{
			get;
			set;
		}

        [Column("ApprovalComment")]
		public string ApprovalComment
		{
			get;
			set;
		}

        [Column("PropertyAddress")]
		public string PropertyAddress
		{
			get;
			set;
		}

        [Column("EventFlag")]
		public short? EventFlag
		{
			get;
			set;
		}

        [Column("EventRemark")]
		public string EventRemark
		{
			get;
			set;
		}

        [Column("ReceiptStatus")]
		public short? ReceiptStatus
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





