/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:45
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGCommonAlertType
	/// <summary>
	/// This object represents the properties and navigation list of a CFGCommonAlertType.
	/// </summary>
    [Serializable]
    [Table("CFG_CommonAlertType")]
	public class CFGCommonAlertType
	{
		
		public CFGCommonAlertType()
		{
		}
        
        #region Public Properties
        
        [Column("AlertTypeID")]
		public string AlertTypeID
		{
			get;
			set;
		}

        [Column("AlertTypeName")]
		public string AlertTypeName
		{
			get;
			set;
		}

        [Column("AlertTypeType")]
		public short AlertTypeType
		{
			get;
			set;
		}

        [Column("BaseURL")]
		public string BaseURL
		{
			get;
			set;
		}

        [Column("OperateNo")]
		public string OperateNo
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





