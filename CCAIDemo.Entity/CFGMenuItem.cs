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
	#region CFGMenuItem
	/// <summary>
	/// This object represents the properties and navigation list of a CFGMenuItem.
	/// </summary>
    [Serializable]
    [Table("CFG_MenuItem")]
	public class CFGMenuItem
	{
		
		public CFGMenuItem()
		{
		}
        
        #region Public Properties
        
        [Column("MenuGUID")]
		public string MenuGUID
		{
			get;
			set;
		}

        [Column("MenuCode")]
		public int MenuCode
		{
			get;
			set;
		}

        [Column("MenuFullCode")]
		public string MenuFullCode
		{
			get;
			set;
		}

        [Column("MenuName")]
		public string MenuName
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

        [Column("MenuURL")]
		public string MenuURL
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

        [Column("MenuOrder")]
		public short MenuOrder
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





