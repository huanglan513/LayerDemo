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
	#region SYSUserOpScope
	/// <summary>
	/// This object represents the properties and navigation list of a SYSUserOpScope.
	/// </summary>
    [Serializable]
    [Table("SYS_UserOpScope")]
	public class SYSUserOpScope
	{
		
		public SYSUserOpScope()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public Guid ItemID
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





