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
	#region WFApplyInstance
	/// <summary>
	/// This object represents the properties and navigation list of a WFApplyInstance.
	/// </summary>
    [Serializable]
    [Table("WF_ApplyInstance")]
	public class WFApplyInstance
	{
		
		public WFApplyInstance()
		{
		}
        
        #region Public Properties
        
        [Column("ApplyID")]
		public string ApplyID
		{
			get;
			set;
		}

        [Column("ApplyTypeID")]
		public string ApplyTypeID
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

        [Column("CurState")]
		public string CurState
		{
			get;
			set;
		}

        [Column("ApplyBy")]
		public string ApplyBy
		{
			get;
			set;
		}

        [Column("ApplicantName")]
		public string ApplicantName
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

        [Column("ApplyDate")]
		public DateTime ApplyDate
		{
			get;
			set;
		}

        [Column("K2SN")]
		public string K2SN
		{
			get;
			set;
		}

        [Column("IsWFSubmit")]
		public short IsWFSubmit
		{
			get;
			set;
		}

        [Column("IsFinished")]
		public short IsFinished
		{
			get;
			set;
		}

        [Column("ProcInstID")]
		public int? ProcInstID
		{
			get;
			set;
		}

        [Column("CurrentStepOrder")]
		public decimal CurrentStepOrder
		{
			get;
			set;
		}

        [Column("Folio")]
		public string Folio
		{
			get;
			set;
		}

        [Column("ApplyEmpID")]
		public string ApplyEmpID
		{
			get;
			set;
		}

        [Column("LastAuditDate")]
		public DateTime? LastAuditDate
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





