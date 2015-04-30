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
	#region SYSFeedBack
	/// <summary>
	/// This object represents the properties and navigation list of a SYSFeedBack.
	/// </summary>
    [Serializable]
    [Table("SYS_FeedBack",PrimaryKeyColumn="ItemID")]
	public class SYSFeedBack
	{
		
		public SYSFeedBack()
		{
		}
        
        #region Public Properties
         
        [Column("ItemID")]
		public Guid ItemID
		{
			get;
            set;
		}
        
        [Column("UpdateDate")]
		public DateTime UpdateDate
		{
			get;
			set;
		}

        [Column("Subject")]
		public string Subject
		{
			get;
			set;
		}

        [Column("Opinion")]
		public string Opinion
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

        [Column("DeptID")]
		public string DeptID
		{
			get;
			set;
		}

        [Column("FeedBackFlag")]
		public short FeedBackFlag
		{
			get;
			set;
		}

        [Column("HandleOpinion")]
		public string HandleOpinion
		{
			get;
			set;
		}

        [Column("HandleEmpID")]
		public string HandleEmpID
		{
			get;
			set;
		}

        [Column("HandleDate")]
		public DateTime? HandleDate
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





