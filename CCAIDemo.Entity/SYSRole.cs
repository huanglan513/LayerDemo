/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:52
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region SYSRole
	/// <summary>
	/// This object represents the properties and navigation list of a SYSRole.
	/// </summary>
    [Serializable]
    [Table("SYS_Role")]
	public class SYSRole
	{
		
		public SYSRole()
		{
		}
        
        #region Public Properties
        
        [Column("RoleID")]
		public string RoleID
		{
			get;
			set;
		}

        [Column("RoleNo")]
		public string RoleNo
		{
			get;
			set;
		}

        [Column("RoleName")]
		public string RoleName
		{
			get;
			set;
		}

        [Column("RoleLevel")]
		public int RoleLevel
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





