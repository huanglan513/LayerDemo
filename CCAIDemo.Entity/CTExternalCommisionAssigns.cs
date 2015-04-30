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
	#region CTExternalCommisionAssigns
	/// <summary>
	/// This object represents the properties and navigation list of a CTExternalCommisionAssigns.
	/// </summary>
    [Serializable]
    [Table("CT_ExternalCommisionAssigns")]
	public class CTExternalCommisionAssigns
	{
		
		public CTExternalCommisionAssigns()
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

        [Column("CooperateFeeType")]
		public string CooperateFeeType
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





