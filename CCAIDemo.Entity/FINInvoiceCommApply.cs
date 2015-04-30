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
	#region FINInvoiceCommApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINInvoiceCommApply.
	/// </summary>
    [Serializable]
    [Table("FIN_InvoiceCommApply")]
	public class FINInvoiceCommApply
	{
		
		public FINInvoiceCommApply()
		{
		}
        
        #region Public Properties
        
        [Column("AccountFlowID")]
		public string AccountFlowID
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

        [Column("ReceiptID")]
		public string ReceiptID
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

        [Column("InvoiceCode")]
		public string InvoiceCode
		{
			get;
			set;
		}

        [Column("InvoiceWay")]
		public short? InvoiceWay
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





