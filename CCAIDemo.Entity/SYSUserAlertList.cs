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
	#region SYSUserAlertList
	/// <summary>
	/// This object represents the properties and navigation list of a SYSUserAlertList.
	/// </summary>
    [Serializable]
    [Table("SYS_UserAlertList")]
	public class SYSUserAlertList
	{
		
		public SYSUserAlertList()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("AlertBatchID")]
		public string AlertBatchID
		{
			get;
			set;
		}

        [Column("AlertDate")]
		public DateTime AlertDate
		{
			get;
			set;
		}

        [Column("AlertTypeID")]
		public string AlertTypeID
		{
			get;
			set;
		}

        [Column("RoleID")]
		public string RoleID
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

        [Column("Content")]
		public string Content
		{
			get;
			set;
		}

        [Column("FullURL")]
		public string FullURL
		{
			get;
			set;
		}

        [Column("IsReadFlag")]
		public bool IsReadFlag
		{
			get;
			set;
		}

        [Column("ApplyDeptID")]
		public string ApplyDeptID
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

        [Column("IsHandled")]
		public short IsHandled
		{
			get;
			set;
		}

        [Column("HandledEmpID")]
		public string HandledEmpID
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





