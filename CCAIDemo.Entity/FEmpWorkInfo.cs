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
	#region FEmpWorkInfo
	/// <summary>
	/// This object represents the properties and navigation list of a FEmpWorkInfo.
	/// </summary>
    [Serializable]
    [Table("F_Emp_WorkInfo")]
	public class FEmpWorkInfo
	{
		
		public FEmpWorkInfo()
		{
		}
        
        #region Public Properties
        
        [Column("WorkInfoID")]
		public string WorkInfoID
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

        [Column("DeptID")]
		public string DeptID
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

        [Column("RoleID")]
		public string RoleID
		{
			get;
			set;
		}

        [Column("EmployeeJob")]
		public string EmployeeJob
		{
			get;
			set;
		}

        [Column("IsOnDuty")]
		public short? IsOnDuty
		{
			get;
			set;
		}

        [Column("IsPluralist")]
		public short? IsPluralist
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

        [Column("IsCalculateAchievement")]
		public short? IsCalculateAchievement
		{
			get;
			set;
		}

        [Column("RedeployType")]
		public string RedeployType
		{
			get;
			set;
		}

        [Column("IsChief")]
		public short IsChief
		{
			get;
			set;
		}

        [Column("ImportID")]
		public string ImportID
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





