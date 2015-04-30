/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:48
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CTExternalCommisionAdjustAssigns
	/// <summary>
	/// This object represents the properties and navigation list of a CTExternalCommisionAdjustAssigns.
	/// </summary>
    [Serializable]
    [Table("CT_ExternalCommisionAdjustAssigns")]
	public class CTExternalCommisionAdjustAssigns
	{
		
		public CTExternalCommisionAdjustAssigns()
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

        [Column("CooperateFeeType")]
		public string CooperateFeeType
		{
			get;
			set;
		}

        [Column("CooperateName")]
		public string CooperateName
		{
			get;
			set;
		}

        [Column("CommRatePer")]
		public double CommRatePer
		{
			get;
			set;
		}

        [Column("CommType")]
		public short CommType
		{
			get;
			set;
		}

        [Column("CommAdjust")]
		public double CommAdjust
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

        [Column("IsOldAssign")]
		public short IsOldAssign
		{
			get;
			set;
		}

        [Column("DeptName")]
		public string DeptName
		{
			get;
			set;
		}

        [Column("ManagerName")]
		public string ManagerName
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





