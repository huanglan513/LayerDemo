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
	#region CFGBizHaltDays
	/// <summary>
	/// This object represents the properties and navigation list of a CFGBizHaltDays.
	/// </summary>
    [Serializable]
    [Table("CFG_BizHaltDays")]
	public class CFGBizHaltDays
	{
		
		public CFGBizHaltDays()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("DeptName")]
		public string DeptName
		{
			get;
			set;
		}

        [Column("EmpName")]
		public string EmpName
		{
			get;
			set;
		}

        [Column("EmployeeDate")]
		public DateTime? EmployeeDate
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

        [Column("RecentCaseDate")]
		public DateTime? RecentCaseDate
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





