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
	#region FINCommisionAllocateApplyDetail
	/// <summary>
	/// This object represents the properties and navigation list of a FINCommisionAllocateApplyDetail.
	/// </summary>
    [Serializable]
    [Table("FIN_CommisionAllocateApplyDetail")]
	public class FINCommisionAllocateApplyDetail
	{
		
		public FINCommisionAllocateApplyDetail()
		{
		}
        
        #region Public Properties
        
        [Column("DataID")]
		public string DataID
		{
			get;
			set;
		}

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

        [Column("EmpID")]
		public string EmpID
		{
			get;
			set;
		}

        [Column("Ratio")]
		public decimal Ratio
		{
			get;
			set;
		}

        [Column("Commision")]
		public decimal Commision
		{
			get;
			set;
		}

        [Column("ThisCalcFee")]
		public decimal ThisCalcFee
		{
			get;
			set;
		}

        [Column("FinAuditedFee")]
		public decimal FinAuditedFee
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





