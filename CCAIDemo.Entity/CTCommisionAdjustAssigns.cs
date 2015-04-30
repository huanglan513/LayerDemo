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
	#region CTCommisionAdjustAssigns
	/// <summary>
	/// This object represents the properties and navigation list of a CTCommisionAdjustAssigns.
	/// </summary>
    [Serializable]
    [Table("CT_CommisionAdjustAssigns")]
	public class CTCommisionAdjustAssigns
	{
		
		public CTCommisionAdjustAssigns()
		{
		}
        
        #region Public Properties
        
        [Column("AssignID")]
		public string AssignID
		{
			get;
			set;
		}

        [Column("AdjustID")]
		public string AdjustID
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

        [Column("EmpID")]
		public string EmpID
		{
			get;
			set;
		}

        [Column("CommRatePer")]
		public decimal CommRatePer
		{
			get;
			set;
		}

        [Column("CommAdjust")]
		public decimal CommAdjust
		{
			get;
			set;
		}

        [Column("Sequence")]
		public short Sequence
		{
			get;
			set;
		}

        [Column("Comment")]
		public string Comment
		{
			get;
			set;
		}

        [Column("CommCase")]
		public decimal CommCase
		{
			get;
			set;
		}

        [Column("CommCaseAdjust")]
		public decimal CommCaseAdjust
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





