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
	#region FINInvoiceCommission
	/// <summary>
	/// This object represents the properties and navigation list of a FINInvoiceCommission.
	/// </summary>
    [Serializable]
    [Table("FIN_InvoiceCommission",PrimaryKeyColumn="ItemID")]
	public class FINInvoiceCommission
	{
		
		public FINInvoiceCommission()
		{
		}
        
        #region Public Properties
         
        [Column("ItemID")]
		public string ItemID
		{
			get;
            set;
		}
        
        [Column("InvoiceNo")]
		public string InvoiceNo
		{
			get;
			set;
		}

        [Column("FlowID")]
		public string FlowID
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

        [Column("InvoiceDate")]
		public DateTime InvoiceDate
		{
			get;
			set;
		}

        [Column("Status")]
		public int Status
		{
			get;
			set;
		}

        [Column("Remarks")]
		public string Remarks
		{
			get;
			set;
		}

        [Column("IsWriteBack")]
		public bool? IsWriteBack
		{
			get;
			set;
		}

        [Column("Creator")]
		public string Creator
		{
			get;
			set;
		}

        [Column("CreateDate")]
		public DateTime? CreateDate
		{
			get;
			set;
		}

        [Column("DelFlag")]
		public int? DelFlag
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





