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
	#region FINPaymentApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINPaymentApply.
	/// </summary>
    [Serializable]
    [Table("FIN_PaymentApply")]
	public class FINPaymentApply
	{
		
		public FINPaymentApply()
		{
		}
        
        #region Public Properties
        
        [Column("PaymentID")]
		public string PaymentID
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

        [Column("ApplyDate")]
		public DateTime ApplyDate
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

        [Column("PaymentMoney")]
		public decimal PaymentMoney
		{
			get;
			set;
		}

        [Column("PaymentWay")]
		public short PaymentWay
		{
			get;
			set;
		}

        [Column("IsContract")]
		public short IsContract
		{
			get;
			set;
		}

        [Column("Purpose")]
		public string Purpose
		{
			get;
			set;
		}

        [Column("PaymentDate")]
		public DateTime? PaymentDate
		{
			get;
			set;
		}

        [Column("PaymentFlag")]
		public short PaymentFlag
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

        [Column("PayerBank")]
		public string PayerBank
		{
			get;
			set;
		}

        [Column("PayerBankAccount")]
		public string PayerBankAccount
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

        [Column("ModDate")]
		public DateTime ModDate
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





