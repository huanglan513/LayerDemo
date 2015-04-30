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
	#region FINCommisionAllocateApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINCommisionAllocateApply.
	/// </summary>
    [Serializable]
    [Table("FIN_CommisionAllocateApply")]
	public class FINCommisionAllocateApply
	{
		
		public FINCommisionAllocateApply()
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

        [Column("ApplyEmpID")]
		public string ApplyEmpID
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

        [Column("ContractID")]
		public string ContractID
		{
			get;
			set;
		}

        [Column("CalcFeeCustomer")]
		public decimal CalcFeeCustomer
		{
			get;
			set;
		}

        [Column("CalcFeeOwner")]
		public decimal CalcFeeOwner
		{
			get;
			set;
		}

        [Column("CalcFeeTotal")]
		public decimal CalcFeeTotal
		{
			get;
			set;
		}

        [Column("ThisFeeCustomer")]
		public decimal ThisFeeCustomer
		{
			get;
			set;
		}

        [Column("ThisFeeOwner")]
		public decimal ThisFeeOwner
		{
			get;
			set;
		}

        [Column("ThisFeeTotal")]
		public decimal ThisFeeTotal
		{
			get;
			set;
		}

        [Column("ExternalComm")]
		public decimal ExternalComm
		{
			get;
			set;
		}

        [Column("PersueCommFee")]
		public decimal PersueCommFee
		{
			get;
			set;
		}

        [Column("ThisActualBase")]
		public decimal ThisActualBase
		{
			get;
			set;
		}

        [Column("NewCertNo")]
		public string NewCertNo
		{
			get;
			set;
		}

        [Column("HaveConnectList")]
		public short HaveConnectList
		{
			get;
			set;
		}

        [Column("Reason")]
		public string Reason
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





