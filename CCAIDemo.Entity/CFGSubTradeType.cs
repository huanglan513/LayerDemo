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
	#region CFGSubTradeType
	/// <summary>
	/// This object represents the properties and navigation list of a CFGSubTradeType.
	/// </summary>
    [Serializable]
    [Table("CFG_SubTradeType")]
	public class CFGSubTradeType
	{
		
		public CFGSubTradeType()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("SubTradeType")]
		public string SubTradeType
		{
			get;
			set;
		}

        [Column("TradeValue")]
		public string TradeValue
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





