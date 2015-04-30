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
	#region CTContractAssistant
	/// <summary>
	/// This object represents the properties and navigation list of a CTContractAssistant.
	/// </summary>
    [Serializable]
    [Table("CT_ContractAssistant")]
	public class CTContractAssistant
	{
		
		public CTContractAssistant()
		{
		}
        
        #region Public Properties
        
        [Column("AssistantID")]
		public Guid AssistantID
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

        [Column("AgentName")]
		public string AgentName
		{
			get;
			set;
		}

        [Column("AgentTel")]
		public string AgentTel
		{
			get;
			set;
		}

        [Column("CustomerType")]
		public short CustomerType
		{
			get;
			set;
		}

        [Column("CustomerID")]
		public Guid CustomerID
		{
			get;
			set;
		}

        [Column("TradePurpose")]
		public string TradePurpose
		{
			get;
			set;
		}

        [Column("TradeTime")]
		public string TradeTime
		{
			get;
			set;
		}

        [Column("PropertySource")]
		public string PropertySource
		{
			get;
			set;
		}

        [Column("CustomerNo")]
		public string CustomerNo
		{
			get;
			set;
		}

        [Column("TradeCount")]
		public int? TradeCount
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





