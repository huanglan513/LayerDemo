/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:49
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region FWorkSpaceItem
	/// <summary>
	/// This object represents the properties and navigation list of a FWorkSpaceItem.
	/// </summary>
    [Serializable]
    [Table("F_WorkSpaceItem")]
	public class FWorkSpaceItem
	{
		
		public FWorkSpaceItem()
		{
		}
        
        #region Public Properties
        
        [Column("WorkItemID")]
		public Guid WorkItemID
		{
			get;
			set;
		}

        [Column("WorkItemName")]
		public string WorkItemName
		{
			get;
			set;
		}

        [Column("OperateNo")]
		public string OperateNo
		{
			get;
			set;
		}

        [Column("FullURL")]
		public string FullURL
		{
			get;
			set;
		}

        [Column("ParentID")]
		public Guid? ParentID
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





