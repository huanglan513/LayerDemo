﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 /*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2015/8/3 12:02:43
*/
namespace CCAIDemo.Entity
{
	#region FEmployee
	/// <summary>
	/// This object represents the properties and navigation list of a FEmployee.
	/// </summary>
    [Serializable]
    [Table("F_Employee","EmpID")]
	public class FEmployee
	{
		
		public FEmployee()
		{
		}
        
        #region Public Properties
        
        [Column("EmpID")]
		public string EmpID
		{
			get;
			set;
		}

        [Column("Password")]
		public string Password
		{
			get;
			set;
		}

        [Column("EmpNo")]
		public string EmpNo
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

        [Column("DeptID")]
		public string DeptID
		{
			get;
			set;
		}

        [Column("AuthenticationType")]
		public short AuthenticationType
		{
			get;
			set;
		}

        [Column("ADUserID")]
		public string ADUserID
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

        [Column("Email")]
		public string Email
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

        [Column("UpdateTime")]
		public DateTime UpdateTime
		{
			get;
			set;
		}

        [Column("Job")]
		public string Job
		{
			get;
			set;
		}

        [Column("Sex")]
		public string Sex
		{
			get;
			set;
		}

        [Column("IsDeptManager")]
		public short IsDeptManager
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

        [Column("IdentityCardNO")]
		public string IdentityCardNO
		{
			get;
			set;
		}

        [Column("IsRun")]
		public short IsRun
		{
			get;
			set;
		}

        [Column("IsDelFlag")]
		public short IsDelFlag
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

        [Column("IDCardNo")]
		public string IDCardNo
		{
			get;
			set;
		}

        [Column("ResignDate")]
		public DateTime? ResignDate
		{
			get;
			set;
		}

        [Column("DeptGUID")]
		public string DeptGUID
		{
			get;
			set;
		}

        [Column("HREmpID")]
		public string HREmpID
		{
			get;
			set;
		}

        [Column("EmpGUID")]
		public string EmpGUID
		{
			get;
			set;
		}

        [Column("AllowUseCCAI")]
		public int AllowUseCCAI
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



