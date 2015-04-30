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
	#region FCustomer
	/// <summary>
	/// This object represents the properties and navigation list of a FCustomer.
	/// </summary>
    [Serializable]
    [Table("F_Customer")]
	public class FCustomer
	{
		
		public FCustomer()
		{
		}
        
        #region Public Properties
        
        [Column("CustomerID")]
		public string CustomerID
		{
			get;
			set;
		}

        [Column("IDCard")]
		public string IDCard
		{
			get;
			set;
		}

        [Column("Name")]
		public string Name
		{
			get;
			set;
		}

        [Column("IDCard18")]
		public string IDCard18
		{
			get;
			set;
		}

        [Column("ContactMan")]
		public string ContactMan
		{
			get;
			set;
		}

        [Column("Tel")]
		public string Tel
		{
			get;
			set;
		}

        [Column("Mobile")]
		public string Mobile
		{
			get;
			set;
		}

        [Column("Email")]
		public string Email
		{
			get;
			set;
		}

        [Column("Address")]
		public string Address
		{
			get;
			set;
		}

        [Column("Postcode")]
		public string Postcode
		{
			get;
			set;
		}

        [Column("CustomerProperty")]
		public string CustomerProperty
		{
			get;
			set;
		}

        [Column("Sex")]
		public string Sex
		{
			get;
			set;
		}

        [Column("Birthday")]
		public DateTime? Birthday
		{
			get;
			set;
		}

        [Column("TradeCount")]
		public string TradeCount
		{
			get;
			set;
		}

        [Column("CustomerPaperType")]
		public string CustomerPaperType
		{
			get;
			set;
		}

        [Column("Profession")]
		public string Profession
		{
			get;
			set;
		}

        [Column("Register")]
		public string Register
		{
			get;
			set;
		}

        [Column("Age")]
		public short? Age
		{
			get;
			set;
		}

        [Column("Purpose")]
		public string Purpose
		{
			get;
			set;
		}

        [Column("CentaTradeCount")]
		public string CentaTradeCount
		{
			get;
			set;
		}

        [Column("OwnedProperty")]
		public string OwnedProperty
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

        [Column("AgentIDCard")]
		public string AgentIDCard
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

        [Column("IsVIP")]
		public short IsVIP
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




