/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:51
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region SYSDeptOpScope
	/// <summary>
	/// This object represents the properties and navigation list of a SYSDeptOpScope.
	/// </summary>
    [Serializable]
    [Table("SYS_DeptOpScope")]
	public class SYSDeptOpScope
	{
		
		public SYSDeptOpScope()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public Guid ItemID
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

        [Column("OpObjectID")]
		public string OpObjectID
		{
			get;
			set;
		}

        [Column("DeptOrArea")]
		public short DeptOrArea
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





