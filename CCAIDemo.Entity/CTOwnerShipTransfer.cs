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
	#region CTOwnerShipTransfer
	/// <summary>
	/// This object represents the properties and navigation list of a CTOwnerShipTransfer.
	/// </summary>
    [Serializable]
    [Table("CT_OwnerShipTransfer")]
	public class CTOwnerShipTransfer
	{
		
		public CTOwnerShipTransfer()
		{
		}
        
        #region Public Properties
        
        [Column("TransferID")]
		public string TransferID
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

        [Column("PropertyGTJ")]
		public string PropertyGTJ
		{
			get;
			set;
		}

        [Column("PayWay")]
		public string PayWay
		{
			get;
			set;
		}

        [Column("LoanMoney")]
		public decimal? LoanMoney
		{
			get;
			set;
		}

        [Column("LoanMoneyPercent")]
		public decimal? LoanMoneyPercent
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

        [Column("LoanYear")]
		public int? LoanYear
		{
			get;
			set;
		}

        [Column("OwedMoney")]
		public decimal? OwedMoney
		{
			get;
			set;
		}

        [Column("TransferDate")]
		public DateTime? TransferDate
		{
			get;
			set;
		}

        [Column("Progress")]
		public string Progress
		{
			get;
			set;
		}

        [Column("FinishDate")]
		public DateTime? FinishDate
		{
			get;
			set;
		}

        [Column("Charge")]
		public decimal? Charge
		{
			get;
			set;
		}

        [Column("State")]
		public string State
		{
			get;
			set;
		}

        [Column("ReceivePaperDate")]
		public DateTime? ReceivePaperDate
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

        [Column("CustodyMoney")]
		public double? CustodyMoney
		{
			get;
			set;
		}

        [Column("LandCertNo")]
		public string LandCertNo
		{
			get;
			set;
		}

        [Column("PropertyCertNo")]
		public string PropertyCertNo
		{
			get;
			set;
		}

        [Column("CustodyBank")]
		public string CustodyBank
		{
			get;
			set;
		}

        [Column("IsOriginDocUpload")]
		public short? IsOriginDocUpload
		{
			get;
			set;
		}

        [Column("EstimateTransferDate")]
		public DateTime? EstimateTransferDate
		{
			get;
			set;
		}

        [Column("IsNetSign")]
		public short? IsNetSign
		{
			get;
			set;
		}

        [Column("District")]
		public string District
		{
			get;
			set;
		}

        [Column("IsSignedAssureCompany")]
		public short? IsSignedAssureCompany
		{
			get;
			set;
		}

        [Column("AssureFee")]
		public decimal? AssureFee
		{
			get;
			set;
		}

        [Column("LoanPercent")]
		public string LoanPercent
		{
			get;
			set;
		}

        [Column("EvalPrice")]
		public decimal? EvalPrice
		{
			get;
			set;
		}

        [Column("EvalCompany")]
		public string EvalCompany
		{
			get;
			set;
		}

        [Column("RedemptiveInterest")]
		public string RedemptiveInterest
		{
			get;
			set;
		}

        [Column("RedeemFloorInterest")]
		public string RedeemFloorInterest
		{
			get;
			set;
		}

        [Column("BondingAmount")]
		public decimal BondingAmount
		{
			get;
			set;
		}

        [Column("ReturnReceiptForMortgage")]
		public string ReturnReceiptForMortgage
		{
			get;
			set;
		}

        [Column("ReturnReceiptFortTransfer")]
		public string ReturnReceiptFortTransfer
		{
			get;
			set;
		}

        [Column("IsBankSelf")]
		public short IsBankSelf
		{
			get;
			set;
		}

        [Column("IsAssureSelf")]
		public short IsAssureSelf
		{
			get;
			set;
		}

        [Column("LoanBankBranch")]
		public string LoanBankBranch
		{
			get;
			set;
		}

        [Column("ReleaseMoneyDate")]
		public DateTime? ReleaseMoneyDate
		{
			get;
			set;
		}

        [Column("ReleaseAssureDate")]
		public DateTime? ReleaseAssureDate
		{
			get;
			set;
		}

        [Column("CertServiceItem")]
		public string CertServiceItem
		{
			get;
			set;
		}

        [Column("Remark")]
		public string Remark
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
		#endregion
        
        #region Navigation List
        #endregion

    }
#endregion
}





