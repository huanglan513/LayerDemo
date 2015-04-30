/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:45
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGAssureCompanyBank
	/// <summary>
	/// This object represents the properties and navigation list of a CFGAssureCompanyBank.
	/// </summary>
    [Serializable]
    [Table("CFG_AssureCompanyBank")]
	public class CFGAssureCompanyBank
	{
		
		public CFGAssureCompanyBank()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("AssureCompany")]
		public string AssureCompany
		{
			get;
			set;
		}

        [Column("LoanBank")]
		public string LoanBank
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





