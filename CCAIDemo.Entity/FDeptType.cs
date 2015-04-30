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
	#region FDeptType
	/// <summary>
	/// This object represents the properties and navigation list of a FDeptType.
	/// </summary>
    [Serializable]
    [Table("F_DeptType")]
	public class FDeptType
	{
		
		public FDeptType()
		{
		}
        
        #region Public Properties
        
        [Column("DeptType")]
		public short DeptType
		{
			get;
			set;
		}

        [Column("DeptTypeName")]
		public string DeptTypeName
		{
			get;
			set;
		}

        [Column("SortID")]
		public short? SortID
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





