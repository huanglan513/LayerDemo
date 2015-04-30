/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:45
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGDeptHRCount
	/// <summary>
	/// This object represents the properties and navigation list of a CFGDeptHRCount.
	/// </summary>
    [Serializable]
    [Table("CFG_DeptHRCount")]
	public class CFGDeptHRCount
	{
		
		public CFGDeptHRCount()
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

        [Column("ReportDate")]
		public DateTime ReportDate
		{
			get;
			set;
		}

        [Column("HrCount")]
		public decimal HrCount
		{
			get;
			set;
		}

        [Column("CalcCount")]
		public decimal CalcCount
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





