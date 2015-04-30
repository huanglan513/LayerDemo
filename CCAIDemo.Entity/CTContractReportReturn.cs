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
	#region CTContractReportReturn
	/// <summary>
	/// This object represents the properties and navigation list of a CTContractReportReturn.
	/// </summary>
    [Serializable]
    [Table("CT_ContractReportReturn",PrimaryKeyColumn="ItemID")]
	public class CTContractReportReturn
	{
		
		public CTContractReportReturn()
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

        [Column("ReturnDate")]
		public DateTime ReturnDate
		{
			get;
			set;
		}

        [Column("ReturnBy")]
		public string ReturnBy
		{
			get;
			set;
		}

        [Column("ReturnReason")]
		public string ReturnReason
		{
			get;
			set;
		}

        [Column("IsHandled")]
		public short IsHandled
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





