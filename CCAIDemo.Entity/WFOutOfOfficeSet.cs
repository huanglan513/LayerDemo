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
	#region WFOutOfOfficeSet
	/// <summary>
	/// This object represents the properties and navigation list of a WFOutOfOfficeSet.
	/// </summary>
    [Serializable]
    [Table("WF_OutOfOfficeSet")]
	public class WFOutOfOfficeSet
	{
		
		public WFOutOfOfficeSet()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("Type")]
		public string Type
		{
			get;
			set;
		}

        [Column("StartDate")]
		public DateTime? StartDate
		{
			get;
			set;
		}

        [Column("EndDate")]
		public DateTime? EndDate
		{
			get;
			set;
		}

        [Column("ModDate")]
		public DateTime ModDate
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





