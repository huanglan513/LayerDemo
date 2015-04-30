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
	#region FINReceiptCommApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINReceiptCommApply.
	/// </summary>
    [Serializable]
    [Table("FIN_ReceiptCommApply")]
	public class FINReceiptCommApply
	{
		
		public FINReceiptCommApply()
		{
		}
        
        #region Public Properties
        
        [Column("AccountFlowID")]
		public string AccountFlowID
		{
			get;
			set;
		}

        [Column("ReceiptID")]
		public string ReceiptID
		{
			get;
			set;
		}

        [Column("ContractID")]
		public Guid? ContractID
		{
			get;
			set;
		}

        [Column("checkCode")]
		public string checkCode
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

        [Column("InvoiceID")]
		public Guid? InvoiceID
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

        [Column("ReceiptCode")]
		public string ReceiptCode
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





