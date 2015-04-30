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
	#region CFGTradeAccessoryType
	/// <summary>
	/// This object represents the properties and navigation list of a CFGTradeAccessoryType.
	/// </summary>
    [Serializable]
    [Table("CFG_TradeAccessoryType")]
	public class CFGTradeAccessoryType
	{
		
		public CFGTradeAccessoryType()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public Guid ItemID
		{
			get;
			set;
		}

        [Column("Trade")]
		public string Trade
		{
			get;
			set;
		}

        [Column("AccessoryType")]
		public string AccessoryType
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





