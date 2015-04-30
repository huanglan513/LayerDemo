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
	#region CTContractCommisionAssigns
	/// <summary>
	/// This object represents the properties and navigation list of a CTContractCommisionAssigns.
	/// </summary>
    [Serializable]
    [Table("CT_ContractCommisionAssigns")]
	public class CTContractCommisionAssigns
	{
		
		public CTContractCommisionAssigns()
		{
		}
        
        #region Public Properties
        
        [Column("AssignID")]
		public string AssignID
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

        [Column("Sequence")]
		public int Sequence
		{
			get;
			set;
		}

        [Column("CertConfirm")]
		public short CertConfirm
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





