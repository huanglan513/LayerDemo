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
	#region FemployeeBak
	/// <summary>
	/// This object represents the properties and navigation list of a FemployeeBak.
	/// </summary>
    [Serializable]
    [Table("F_employeeBak")]
	public class FemployeeBak
	{
		
		public FemployeeBak()
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
		public short? IsDelFlag
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





