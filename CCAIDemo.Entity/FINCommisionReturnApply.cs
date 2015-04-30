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
	#region FINCommisionReturnApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINCommisionReturnApply.
	/// </summary>
    [Serializable]
    [Table("FIN_CommisionReturnApply")]
	public class FINCommisionReturnApply
	{
		
		public FINCommisionReturnApply()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("ApplyDate")]
		public DateTime ApplyDate
		{
			get;
			set;
		}

        [Column("ApplyFlag")]
		public short ApplyFlag
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

        [Column("ApplyEmpID")]
		public string ApplyEmpID
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

        [Column("CustomerDate")]
		public DateTime CustomerDate
		{
			get;
			set;
		}

        [Column("CustomerComm")]
		public decimal CustomerComm
		{
			get;
			set;
		}

        [Column("OwnerDate")]
		public DateTime OwnerDate
		{
			get;
			set;
		}

        [Column("OwnerComm")]
		public decimal OwnerComm
		{
			get;
			set;
		}

        [Column("OwnerInvoiceFlag")]
		public short OwnerInvoiceFlag
		{
			get;
			set;
		}

        [Column("CustomerInvoiceFlag")]
		public short CustomerInvoiceFlag
		{
			get;
			set;
		}

        [Column("ApplyReason")]
		public string ApplyReason
		{
			get;
			set;
		}

        [Column("ModDate")]
		public DateTime? ModDate
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





