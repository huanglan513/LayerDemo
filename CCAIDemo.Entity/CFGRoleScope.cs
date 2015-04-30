/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:46
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGRoleScope
	/// <summary>
	/// This object represents the properties and navigation list of a CFGRoleScope.
	/// </summary>
    [Serializable]
    [Table("CFG_RoleScope")]
	public class CFGRoleScope
	{
		
		public CFGRoleScope()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public Guid ItemID
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

        [Column("ScopeRoleID")]
		public string ScopeRoleID
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





