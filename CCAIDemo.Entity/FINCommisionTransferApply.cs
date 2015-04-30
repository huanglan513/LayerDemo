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
	#region FINCommisionTransferApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINCommisionTransferApply.
	/// </summary>
    [Serializable]
    [Table("FIN_CommisionTransferApply")]
	public class FINCommisionTransferApply
	{
		
		public FINCommisionTransferApply()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("ApplyFlag")]
		public short ApplyFlag
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

        [Column("TransferMoney")]
		public decimal TransferMoney
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

        [Column("PaymentWay")]
		public short PaymentWay
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





