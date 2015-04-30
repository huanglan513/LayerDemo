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
	#region WFOutOfOfficeSetDetail
	/// <summary>
	/// This object represents the properties and navigation list of a WFOutOfOfficeSetDetail.
	/// </summary>
    [Serializable]
    [Table("WF_OutOfOfficeSetDetail")]
	public class WFOutOfOfficeSetDetail
	{
		
		public WFOutOfOfficeSetDetail()
		{
		}
        
        #region Public Properties
        
        [Column("DataID")]
		public string DataID
		{
			get;
			set;
		}

        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("ForwardEmpID")]
		public string ForwardEmpID
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





