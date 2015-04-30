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
	#region SysSet
	/// <summary>
	/// This object represents the properties and navigation list of a SysSet.
	/// </summary>
    [Serializable]
    [Table("SysSet")]
	public class SysSet
	{
		
		public SysSet()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public Guid ItemID
		{
			get;
			set;
		}

        [Column("ParamDesc")]
		public string ParamDesc
		{
			get;
			set;
		}

        [Column("ParamName")]
		public string ParamName
		{
			get;
			set;
		}

        [Column("ParamData")]
		public string ParamData
		{
			get;
			set;
		}

        [Column("ModDate")]
		public DateTime? ModDate
		{
			get;
			set;
		}

        [Column("ParamType")]
		public int ParamType
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





