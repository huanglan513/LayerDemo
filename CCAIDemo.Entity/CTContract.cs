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
	#region CTContract
	/// <summary>
	/// This object represents the properties and navigation list of a CTContract.
	/// </summary>
    [Serializable]
    [Table("CT_Contract",PrimaryKeyColumn="ContractID")]
	public class CTContract
	{
		
		public CTContract()
		{
		}
        
        #region Public Properties
         
        [Column("ContractID")]
		public string ContractID
		{
			get;
            set;
		}
        
        [Column("ReportType")]
		public short ReportType
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

        [Column("Trade")]
		public string Trade
		{
			get;
			set;
		}

        [Column("PropertyID")]
		public string PropertyID
		{
			get;
			set;
		}

        [Column("ContractNo")]
		public string ContractNo
		{
			get;
			set;
		}

        [Column("ContractDate")]
		public DateTime ContractDate
		{
			get;
			set;
		}

        [Column("EmpID")]
		public string EmpID
		{
			get;
			set;
		}

        [Column("DeptID")]
		public string DeptID
		{
			get;
			set;
		}

        [Column("Price")]
		public decimal? Price
		{
			get;
			set;
		}

        [Column("PriceUnitName")]
		public string PriceUnitName
		{
			get;
			set;
		}

        [Column("UnitPrice")]
		public decimal UnitPrice
		{
			get;
			set;
		}

        [Column("OwnerTradeFee")]
		public decimal OwnerTradeFee
		{
			get;
			set;
		}

        [Column("FeeOwnerDiscount")]
		public decimal FeeOwnerDiscount
		{
			get;
			set;
		}

        [Column("FeeOwner")]
		public decimal FeeOwner
		{
			get;
			set;
		}

        [Column("CustomerTradeFee")]
		public decimal CustomerTradeFee
		{
			get;
			set;
		}

        [Column("FeeCustomerDiscount")]
		public decimal FeeCustomerDiscount
		{
			get;
			set;
		}

        [Column("FeeCustomer")]
		public decimal FeeCustomer
		{
			get;
			set;
		}

        [Column("AuditFlag")]
		public short? AuditFlag
		{
			get;
			set;
		}

        [Column("PropertyPayWay")]
		public string PropertyPayWay
		{
			get;
			set;
		}

        [Column("PropertyLoanYear")]
		public int? PropertyLoanYear
		{
			get;
			set;
		}

        [Column("PropertyLoanMoney")]
		public decimal? PropertyLoanMoney
		{
			get;
			set;
		}

        [Column("PropertySurplusYear")]
		public decimal? PropertySurplusYear
		{
			get;
			set;
		}

        [Column("PropertyPayMoney")]
		public decimal? PropertyPayMoney
		{
			get;
			set;
		}

        [Column("ReportNo")]
		public string ReportNo
		{
			get;
			set;
		}

        [Column("ReportFlag")]
		public short? ReportFlag
		{
			get;
			set;
		}

        [Column("ContractNumber")]
		public string ContractNumber
		{
			get;
			set;
		}

        [Column("OwnerSignDate")]
		public DateTime? OwnerSignDate
		{
			get;
			set;
		}

        [Column("CustomerSignDate")]
		public DateTime? CustomerSignDate
		{
			get;
			set;
		}

        [Column("RentStartDate")]
		public DateTime? RentStartDate
		{
			get;
			set;
		}

        [Column("RentEndDate")]
		public DateTime? RentEndDate
		{
			get;
			set;
		}

        [Column("RentTerm")]
		public string RentTerm
		{
			get;
			set;
		}

        [Column("OrderNo")]
		public string OrderNo
		{
			get;
			set;
		}

        [Column("OwnerFeePromiseDate")]
		public DateTime? OwnerFeePromiseDate
		{
			get;
			set;
		}

        [Column("CustomerFeePromiseDate")]
		public DateTime? CustomerFeePromiseDate
		{
			get;
			set;
		}

        [Column("EstimatePaymentDate")]
		public DateTime? EstimatePaymentDate
		{
			get;
			set;
		}

        [Column("EstimatePaymentMoney")]
		public decimal? EstimatePaymentMoney
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

        [Column("FeePropertyPercent")]
		public decimal FeePropertyPercent
		{
			get;
			set;
		}

        [Column("FeeCustomerPercent")]
		public decimal FeeCustomerPercent
		{
			get;
			set;
		}

        [Column("ModDate")]
		public DateTime? ModDate
		{
			get;
			set;
		}

        [Column("Creator")]
		public string Creator
		{
			get;
			set;
		}

        [Column("IsMoneyCustody")]
		public short? IsMoneyCustody
		{
			get;
			set;
		}

        [Column("IsAudit")]
		public short IsAudit
		{
			get;
			set;
		}

        [Column("IsAchievementReport")]
		public short IsAchievementReport
		{
			get;
			set;
		}

        [Column("IsNeedMortageFollow")]
		public short IsNeedMortageFollow
		{
			get;
			set;
		}

        [Column("CanReport")]
		public short CanReport
		{
			get;
			set;
		}

        [Column("CanAllocate")]
		public short CanAllocate
		{
			get;
			set;
		}

        [Column("ContractSignDate")]
		public DateTime? ContractSignDate
		{
			get;
			set;
		}

        [Column("IntentSignDate")]
		public DateTime? IntentSignDate
		{
			get;
			set;
		}

        [Column("PropertyAddress")]
		public string PropertyAddress
		{
			get;
			set;
		}

        [Column("SubTrade")]
		public short SubTrade
		{
			get;
			set;
		}

        [Column("FeePercent")]
		public decimal? FeePercent
		{
			get;
			set;
		}

        [Column("ContractKind")]
		public short ContractKind
		{
			get;
			set;
		}

        [Column("ReportDate")]
		public DateTime? ReportDate
		{
			get;
			set;
		}

        [Column("ContractType")]
		public string ContractType
		{
			get;
			set;
		}

        [Column("SecondhandContractNo")]
		public string SecondhandContractNo
		{
			get;
			set;
		}

        [Column("FundsSuperviseNo")]
		public string FundsSuperviseNo
		{
			get;
			set;
		}

        [Column("CheckCommisionState")]
		public short CheckCommisionState
		{
			get;
			set;
		}

        [Column("TransferState")]
		public string TransferState
		{
			get;
			set;
		}

        [Column("ReceivedOwner")]
		public decimal ReceivedOwner
		{
			get;
			set;
		}

        [Column("ReceivedOwnerDate")]
		public DateTime? ReceivedOwnerDate
		{
			get;
			set;
		}

        [Column("ReceivedOwnerPayType")]
		public string ReceivedOwnerPayType
		{
			get;
			set;
		}

        [Column("ReceivedCustomer")]
		public decimal ReceivedCustomer
		{
			get;
			set;
		}

        [Column("ReceivedCustomerDate")]
		public DateTime? ReceivedCustomerDate
		{
			get;
			set;
		}

        [Column("ReceivedCustomerPayType")]
		public string ReceivedCustomerPayType
		{
			get;
			set;
		}

        [Column("OwnerRemain")]
		public decimal OwnerRemain
		{
			get;
			set;
		}

        [Column("OwnerRemainPayDate")]
		public DateTime? OwnerRemainPayDate
		{
			get;
			set;
		}

        [Column("OwnerRemainPayType")]
		public string OwnerRemainPayType
		{
			get;
			set;
		}

        [Column("CustomerRemain")]
		public decimal CustomerRemain
		{
			get;
			set;
		}

        [Column("CustomerRemainPayDate")]
		public DateTime? CustomerRemainPayDate
		{
			get;
			set;
		}

        [Column("CustomerRemainPayType")]
		public string CustomerRemainPayType
		{
			get;
			set;
		}

        [Column("CanReleaseApplyFlag")]
		public short CanReleaseApplyFlag
		{
			get;
			set;
		}

        [Column("CheckCommState")]
		public short CheckCommState
		{
			get;
			set;
		}

        [Column("CustomerVisitDate")]
		public DateTime? CustomerVisitDate
		{
			get;
			set;
		}

        [Column("OldContractID")]
		public string OldContractID
		{
			get;
			set;
		}

        [Column("DiscountReason")]
		public string DiscountReason
		{
			get;
			set;
		}

        [Column("IsChangeOwner")]
		public short IsChangeOwner
		{
			get;
			set;
		}

        [Column("CertFeeType")]
		public short CertFeeType
		{
			get;
			set;
		}

        [Column("CertFee")]
		public decimal CertFee
		{
			get;
			set;
		}

        [Column("IsAgent")]
		public short IsAgent
		{
			get;
			set;
		}

        [Column("AdditionalRemark")]
		public string AdditionalRemark
		{
			get;
			set;
		}

        [Column("CertFeeSelf")]
		public decimal CertFeeSelf
		{
			get;
			set;
		}

        [Column("CertFeeDecrease")]
		public decimal CertFeeDecrease
		{
			get;
			set;
		}

        [Column("PropertyType")]
		public short PropertyType
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





