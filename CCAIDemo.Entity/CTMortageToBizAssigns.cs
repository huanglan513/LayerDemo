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
	#region CTMortageToBizAssigns
	/// <summary>
	/// This object represents the properties and navigation list of a CTMortageToBizAssigns.
	/// </summary>
    [Serializable]
    [Table("CT_MortageToBizAssigns")]
	public class CTMortageToBizAssigns
	{
		
		public CTMortageToBizAssigns()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
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

        [Column("ReportDate")]
		public DateTime? ReportDate
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
		public decimal? CommRatePer
		{
			get;
			set;
		}

        [Column("ModDate")]
		public DateTime? ModDate
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





