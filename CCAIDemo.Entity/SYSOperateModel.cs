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
	#region SYSOperateModel
	/// <summary>
	/// This object represents the properties and navigation list of a SYSOperateModel.
	/// </summary>
    [Serializable]
    [Table("SYS_OperateModel")]
	public class SYSOperateModel
	{
		
		public SYSOperateModel()
		{
		}
        
        #region Public Properties
        
        [Column("ModelID")]
		public string ModelID
		{
			get;
			set;
		}

        [Column("ModelName")]
		public string ModelName
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





