/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:47
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CTCommisionAdjust
	/// <summary>
	/// This object represents the properties and navigation list of a CTCommisionAdjust.
	/// </summary>
    [Serializable]
    [Table("CT_CommisionAdjust")]
	public class CTCommisionAdjust
	{
		
		public CTCommisionAdjust()
		{
		}
        
        #region Public Properties
        
        [Column("AdjustID")]
		public string AdjustID
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

        [Column("AdjustDate")]
		public DateTime AdjustDate
		{
			get;
			set;
		}

        [Column("AdjustType")]
		public short AdjustType
		{
			get;
			set;
		}

        [Column("FeeOwner")]
		public decimal FeeOwner
		{
			get;
			set;
		}

        [Column("FeeCustomer")]
		public decimal FeeCustomer
		{
			get;
			set;
		}

        [Column("AdjustReason")]
		public string AdjustReason
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

        [Column("AdjustFlag")]
		public short AdjustFlag
		{
			get;
			set;
		}

        [Column("IsCurrentMonth")]
		public short IsCurrentMonth
		{
			get;
			set;
		}

        [Column("AdjustReportDate")]
		public DateTime? AdjustReportDate
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

        [Column("IsNeedWorkFlow")]
		public short IsNeedWorkFlow
		{
			get;
			set;
		}

        [Column("IsAdjusted")]
		public short? IsAdjusted
		{
			get;
			set;
		}

        [Column("FinConfirmEmpID")]
		public string FinConfirmEmpID
		{
			get;
			set;
		}

        [Column("FinConfirmDate")]
		public DateTime? FinConfirmDate
		{
			get;
			set;
		}

        [Column("FinConfirmRemark")]
		public string FinConfirmRemark
		{
			get;
			set;
		}

        [Column("DocumentNo")]
		public string DocumentNo
		{
			get;
			set;
		}

        [Column("OwnerFee")]
		public decimal OwnerFee
		{
			get;
			set;
		}

        [Column("CustomerFee")]
		public decimal CustomerFee
		{
			get;
			set;
		}

        [Column("LastAdjustID")]
		public string LastAdjustID
		{
			get;
			set;
		}

        [Column("AdjustTimes")]
		public int AdjustTimes
		{
			get;
			set;
		}

        [Column("CertFeeSelf")]
		public decimal CertFeeSelf
		{
			get;
			set;
		}

        [Column("CertFeeDecrease")]
		public decimal CertFeeDecrease
		{
			get;
			set;
		}

        [Column("CertFeeSelfAdjust")]
		public decimal CertFeeSelfAdjust
		{
			get;
			set;
		}

        [Column("CertFeeDecreaseAdjust")]
		public decimal CertFeeDecreaseAdjust
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





