/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:45
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGDeptYearAim
	/// <summary>
	/// This object represents the properties and navigation list of a CFGDeptYearAim.
	/// </summary>
    [Serializable]
    [Table("CFG_DeptYearAim")]
	public class CFGDeptYearAim
	{
		
		public CFGDeptYearAim()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("YearName")]
		public string YearName
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

        [Column("Aim")]
		public decimal Aim
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





