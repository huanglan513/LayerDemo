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
	#region CFGJobNameToRole
	/// <summary>
	/// This object represents the properties and navigation list of a CFGJobNameToRole.
	/// </summary>
    [Serializable]
    [Table("CFG_JobNameToRole",PrimaryKeyColumn="ItemID")]
	public class CFGJobNameToRole
	{
		
		public CFGJobNameToRole()
		{
		}
        
        #region Public Properties
         
        [Column("ItemID")]
		public string ItemID
		{
			get;
            set;
		}
        
        [Column("JobName")]
		public string JobName
		{
			get;
			set;
		}

        [Column("RoleName")]
		public string RoleName
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





