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
	#region SYSOperate
	/// <summary>
	/// This object represents the properties and navigation list of a SYSOperate.
	/// </summary>
    [Serializable]
    [Table("SYS_Operate")]
	public class SYSOperate
	{
		
		public SYSOperate()
		{
		}
        
        #region Public Properties
        
        [Column("OperateID")]
		public string OperateID
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

        [Column("OperateName")]
		public string OperateName
		{
			get;
			set;
		}

        [Column("OperateType")]
		public string OperateType
		{
			get;
			set;
		}

        [Column("ModelID")]
		public string ModelID
		{
			get;
			set;
		}

        [Column("IsDeptSpan")]
		public short IsDeptSpan
		{
			get;
			set;
		}

        [Column("DelFlag")]
		public short DelFlag
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





