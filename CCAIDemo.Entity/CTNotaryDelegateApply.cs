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
	#region CTNotaryDelegateApply
	/// <summary>
	/// This object represents the properties and navigation list of a CTNotaryDelegateApply.
	/// </summary>
    [Serializable]
    [Table("CT_NotaryDelegateApply")]
	public class CTNotaryDelegateApply
	{
		
		public CTNotaryDelegateApply()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("ContractID")]
		public string ContractID
		{
			get;
			set;
		}

        [Column("DelegateType")]
		public short DelegateType
		{
			get;
			set;
		}

        [Column("DelegatorName")]
		public string DelegatorName
		{
			get;
			set;
		}

        [Column("DelegatorCardID")]
		public string DelegatorCardID
		{
			get;
			set;
		}

        [Column("BizEmpDeptName")]
		public string BizEmpDeptName
		{
			get;
			set;
		}

        [Column("BizEmpName")]
		public string BizEmpName
		{
			get;
			set;
		}

        [Column("EmpCardID")]
		public string EmpCardID
		{
			get;
			set;
		}

        [Column("EmpJob")]
		public string EmpJob
		{
			get;
			set;
		}

        [Column("ContractNumber")]
		public string ContractNumber
		{
			get;
			set;
		}

        [Column("SignDate")]
		public DateTime SignDate
		{
			get;
			set;
		}

        [Column("PropertyAddress")]
		public string PropertyAddress
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

        [Column("ApplyDeptID")]
		public string ApplyDeptID
		{
			get;
			set;
		}

        [Column("Description")]
		public string Description
		{
			get;
			set;
		}

        [Column("ApplyFlag")]
		public short ApplyFlag
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





