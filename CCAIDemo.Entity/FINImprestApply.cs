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
	#region FINImprestApply
	/// <summary>
	/// This object represents the properties and navigation list of a FINImprestApply.
	/// </summary>
    [Serializable]
    [Table("FIN_ImprestApply")]
	public class FINImprestApply
	{
		
		public FINImprestApply()
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

        [Column("ImprestMoney")]
		public decimal ImprestMoney
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





