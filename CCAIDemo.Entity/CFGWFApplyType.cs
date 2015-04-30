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
	#region CFGWFApplyType
	/// <summary>
	/// This object represents the properties and navigation list of a CFGWFApplyType.
	/// </summary>
    [Serializable]
    [Table("CFG_WFApplyType")]
	public class CFGWFApplyType
	{
		
		public CFGWFApplyType()
		{
		}
        
        #region Public Properties
        
        [Column("ApplyTypeID")]
		public string ApplyTypeID
		{
			get;
			set;
		}

        [Column("ApplyType")]
		public string ApplyType
		{
			get;
			set;
		}

        [Column("K2WorkflowName")]
		public string K2WorkflowName
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





