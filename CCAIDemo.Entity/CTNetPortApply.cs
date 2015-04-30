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
	#region CTNetPortApply
	/// <summary>
	/// This object represents the properties and navigation list of a CTNetPortApply.
	/// </summary>
    [Serializable]
    [Table("CT_NetPortApply")]
	public class CTNetPortApply
	{
		
		public CTNetPortApply()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("ApplyDeptID")]
		public string ApplyDeptID
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

        [Column("ApplyDate")]
		public DateTime ApplyDate
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

        [Column("ApplyType")]
		public short ApplyType
		{
			get;
			set;
		}

        [Column("SiteName")]
		public string SiteName
		{
			get;
			set;
		}

        [Column("AccountName")]
		public string AccountName
		{
			get;
			set;
		}

        [Column("RegisterName")]
		public string RegisterName
		{
			get;
			set;
		}

        [Column("RegisterMobileNo")]
		public string RegisterMobileNo
		{
			get;
			set;
		}

        [Column("Fee")]
		public decimal Fee
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

        [Column("RemainDays")]
		public int RemainDays
		{
			get;
			set;
		}

        [Column("ReceivedDeptID")]
		public string ReceivedDeptID
		{
			get;
			set;
		}

        [Column("ReceivedEmpID")]
		public string ReceivedEmpID
		{
			get;
			set;
		}

        [Column("ReleaseDate")]
		public DateTime? ReleaseDate
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





