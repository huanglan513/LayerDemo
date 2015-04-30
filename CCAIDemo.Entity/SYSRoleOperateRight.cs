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
	#region SYSRoleOperateRight
	/// <summary>
	/// This object represents the properties and navigation list of a SYSRoleOperateRight.
	/// </summary>
    [Serializable]
    [Table("SYS_RoleOperateRight")]
	public class SYSRoleOperateRight
	{
		
		public SYSRoleOperateRight()
		{
		}
        
        #region Public Properties
        
        [Column("RightID")]
		public Guid RightID
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

        [Column("OperateID")]
		public string OperateID
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





