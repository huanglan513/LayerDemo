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
	#region FDepartmentSYB
	/// <summary>
	/// This object represents the properties and navigation list of a FDepartmentSYB.
	/// </summary>
    [Serializable]
    [Table("F_Department_SYB")]
	public class FDepartmentSYB
	{
		
		public FDepartmentSYB()
		{
		}
        
        #region Public Properties
        
        [Column("DeptID")]
		public string DeptID
		{
			get;
			set;
		}

        [Column("DeptNo")]
		public string DeptNo
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

        [Column("DeptTel")]
		public string DeptTel
		{
			get;
			set;
		}

        [Column("CityName")]
		public string CityName
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

        [Column("ManagerID")]
		public string ManagerID
		{
			get;
			set;
		}

        [Column("DeptType")]
		public short DeptType
		{
			get;
			set;
		}

        [Column("DelFlag")]
		public short DelFlag
		{
			get;
			set;
		}

        [Column("DeptLevel")]
		public string DeptLevel
		{
			get;
			set;
		}

        [Column("DeptTeam")]
		public short? DeptTeam
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

        [Column("ContractNoPrefix")]
		public string ContractNoPrefix
		{
			get;
			set;
		}

        [Column("DeptGUID")]
		public Guid? DeptGUID
		{
			get;
			set;
		}

        [Column("DeptCode")]
		public int DeptCode
		{
			get;
			set;
		}

        [Column("DeptFullCode")]
		public string DeptFullCode
		{
			get;
			set;
		}

        [Column("HRK3DeptID")]
		public Guid? HRK3DeptID
		{
			get;
			set;
		}

        [Column("HRK3DeptName")]
		public string HRK3DeptName
		{
			get;
			set;
		}

        [Column("CreateDate")]
		public DateTime? CreateDate
		{
			get;
			set;
		}

        [Column("MainWorkInfoID")]
		public Guid? MainWorkInfoID
		{
			get;
			set;
		}

        [Column("PersonnelDeptName")]
		public string PersonnelDeptName
		{
			get;
			set;
		}

        [Column("TMID")]
		public string TMID
		{
			get;
			set;
		}

        [Column("K3UnitCode")]
		public string K3UnitCode
		{
			get;
			set;
		}

        [Column("MovedDeptID")]
		public string MovedDeptID
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





