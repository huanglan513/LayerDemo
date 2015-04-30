/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:48
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region FDeptWorkInfo
	/// <summary>
	/// This object represents the properties and navigation list of a FDeptWorkInfo.
	/// </summary>
    [Serializable]
    [Table("F_Dept_WorkInfo")]
	public class FDeptWorkInfo
	{
		
		public FDeptWorkInfo()
		{
		}
        
        #region Public Properties
        
        [Column("WorkInfoID")]
		public string WorkInfoID
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

        [Column("ParentID")]
		public string ParentID
		{
			get;
			set;
		}

        [Column("BeginDate")]
		public DateTime? BeginDate
		{
			get;
			set;
		}

        [Column("EndDate")]
		public DateTime? EndDate
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





