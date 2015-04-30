/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:47
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGRoleWorkSpace
	/// <summary>
	/// This object represents the properties and navigation list of a CFGRoleWorkSpace.
	/// </summary>
    [Serializable]
    [Table("CFG_RoleWorkSpace")]
	public class CFGRoleWorkSpace
	{
		
		public CFGRoleWorkSpace()
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

        [Column("WorkItemID")]
		public string WorkItemID
		{
			get;
			set;
		}

        [Column("OrderNo")]
		public short OrderNo
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





