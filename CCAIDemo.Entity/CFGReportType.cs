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
	#region CFGReportType
	/// <summary>
	/// This object represents the properties and navigation list of a CFGReportType.
	/// </summary>
    [Serializable]
    [Table("CFG_ReportType")]
	public class CFGReportType
	{
		
		public CFGReportType()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("Code")]
		public short Code
		{
			get;
			set;
		}

        [Column("ReportType")]
		public string ReportType
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





