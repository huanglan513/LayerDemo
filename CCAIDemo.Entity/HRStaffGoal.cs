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
	#region HRStaffGoal
	/// <summary>
	/// This object represents the properties and navigation list of a HRStaffGoal.
	/// </summary>
    [Serializable]
    [Table("HR_StaffGoal",PrimaryKeyColumn="ItemID")]
	public class HRStaffGoal
	{
		
		public HRStaffGoal()
		{
		}
        
        #region Public Properties
         
        [Column("ItemID")]
		public Guid ItemID
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

        [Column("YearMonth")]
		public string YearMonth
		{
			get;
			set;
		}

        [Column("Goal")]
		public decimal Goal
		{
			get;
			set;
		}

        [Column("Number")]
		public decimal Number
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

        [Column("BizDeptID")]
		public string BizDeptID
		{
			get;
			set;
		}

        [Column("RegionID")]
		public string RegionID
		{
			get;
			set;
		}

        [Column("LargeAreaID")]
		public string LargeAreaID
		{
			get;
			set;
		}

        [Column("AreaID")]
		public string AreaID
		{
			get;
			set;
		}

        [Column("BranchID")]
		public string BranchID
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





