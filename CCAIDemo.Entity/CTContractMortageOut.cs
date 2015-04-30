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
	#region CTContractMortageOut
	/// <summary>
	/// This object represents the properties and navigation list of a CTContractMortageOut.
	/// </summary>
    [Serializable]
    [Table("CT_ContractMortageOut")]
	public class CTContractMortageOut
	{
		
		public CTContractMortageOut()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("CustomerLoanMoney")]
		public decimal CustomerLoanMoney
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





