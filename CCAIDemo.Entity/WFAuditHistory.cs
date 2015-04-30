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
	#region WFAuditHistory
	/// <summary>
	/// This object represents the properties and navigation list of a WFAuditHistory.
	/// </summary>
    [Serializable]
    [Table("WF_AuditHistory")]
	public class WFAuditHistory
	{
		
		public WFAuditHistory()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("UserName")]
		public string UserName
		{
			get;
			set;
		}

        [Column("DomainAccount")]
		public string DomainAccount
		{
			get;
			set;
		}

        [Column("ApprovalResult")]
		public string ApprovalResult
		{
			get;
			set;
		}

        [Column("ApprovalComment")]
		public string ApprovalComment
		{
			get;
			set;
		}

        [Column("ApprovalDate")]
		public DateTime ApprovalDate
		{
			get;
			set;
		}

        [Column("ActivityName")]
		public string ActivityName
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





