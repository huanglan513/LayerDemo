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
	#region WFApplyInstanceStateDetail
	/// <summary>
	/// This object represents the properties and navigation list of a WFApplyInstanceStateDetail.
	/// </summary>
    [Serializable]
    [Table("WF_ApplyInstanceStateDetail")]
	public class WFApplyInstanceStateDetail
	{
		
		public WFApplyInstanceStateDetail()
		{
		}
        
        #region Public Properties
        
        [Column("DetailID")]
		public Guid DetailID
		{
			get;
			set;
		}

        [Column("ApplyID")]
		public Guid ApplyID
		{
			get;
			set;
		}

        [Column("CurWorkFlowStep")]
		public string CurWorkFlowStep
		{
			get;
			set;
		}

        [Column("CurAuditor")]
		public string CurAuditor
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





