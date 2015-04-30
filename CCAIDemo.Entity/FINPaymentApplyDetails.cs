/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:51
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region FINPaymentApplyDetails
	/// <summary>
	/// This object represents the properties and navigation list of a FINPaymentApplyDetails.
	/// </summary>
    [Serializable]
    [Table("FIN_PaymentApplyDetails",PrimaryKeyColumn="ItemID")]
	public class FINPaymentApplyDetails
	{
		
		public FINPaymentApplyDetails()
		{
		}
        
        #region Public Properties
         
        [Column("ItemID")]
		public Guid ItemID
		{
			get;
            set;
		}
        
        [Column("PaymentID")]
		public string PaymentID
		{
			get;
			set;
		}

        [Column("OldAccountFlowID")]
		public Guid OldAccountFlowID
		{
			get;
			set;
		}

        [Column("MoneyType")]
		public short? MoneyType
		{
			get;
			set;
		}

        [Column("ReceivedMoney")]
		public decimal ReceivedMoney
		{
			get;
			set;
		}

        [Column("FlowMoney")]
		public decimal FlowMoney
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





