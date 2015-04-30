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
	#region WFApplyInstanceDetail
	/// <summary>
	/// This object represents the properties and navigation list of a WFApplyInstanceDetail.
	/// </summary>
    [Serializable]
    [Table("WF_ApplyInstanceDetail")]
	public class WFApplyInstanceDetail
	{
		
		public WFApplyInstanceDetail()
		{
		}
        
        #region Public Properties
        
        [Column("DetailID")]
		public string DetailID
		{
			get;
			set;
		}

        [Column("ApplyID")]
		public string ApplyID
		{
			get;
			set;
		}

        [Column("BizDataID")]
		public string BizDataID
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





