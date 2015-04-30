using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region GroupByGroup
	/// <summary>
	/// This object represents the properties and navigation list of a GroupByGroup.
	/// </summary>
	public class GroupByGroup
	{
		
		public GroupByGroup()
		{
		}
        
        #region Public Properties
		public int GroupByGroupID
		{
			get;
            set;
		}
		
		public string? GroupByGroupName
		{
			get;
			set;
		}

		public int? CustomerID
		{
			get;
			set;
		}

		public int? SubIndustryID
		{
			get;
			set;
		}

		public decimal? OriginalPrice
		{
			get;
			set;
		}

		public string? GroupByContent
		{
			get;
			set;
		}

		public int? SettlementType
		{
			get;
			set;
		}

		public int? SettlementDate
		{
			get;
			set;
		}

		public int? RefundType
		{
			get;
			set;
		}

		public decimal? LogisticCharge
		{
			get;
			set;
		}

		public int? Status
		{
			get;
			set;
		}

		public string? GroupByContractNo
		{
			get;
			set;
		}

		public string? CreateBy
		{
			get;
			set;
		}

		public DateTime? CreateTime
		{
			get;
			set;
		}

		public string? LastModifyBy
		{
			get;
			set;
		}

		public DateTime? LastModifyTime
		{
			get;
			set;
		}

		public int? DeleteInd
		{
			get;
			set;
		}

		public string? GroupByCodeNo
		{
			get;
			set;
		}

		public decimal? FinalProfit
		{
			get;
			set;
		}

		public decimal? PriceMarket
		{
			get;
			set;
		}

		public decimal? PriceSettlement
		{
			get;
			set;
		}

		public decimal? PriceSuggest
		{
			get;
			set;
		}

		public decimal? PriceOther
		{
			get;
			set;
		}

		public int? ShopCount
		{
			get;
			set;
		}

		public string? ShopNames
		{
			get;
			set;
		}

		public int? ProductPicture1FileID
		{
			get;
			set;
		}

		public int? ProductPicture2FileID
		{
			get;
			set;
		}

		public int? MaterialFileID
		{
			get;
			set;
		}

		public string? OtherHistryCase
		{
			get;
			set;
		}

		public string? DPOrKBAddress
		{
			get;
			set;
		}

		public int? ApproveBMJLUserID
		{
			get;
			set;
		}

		public DateTime? ApproveBMJLActionTime
		{
			get;
			set;
		}

		public string? ApproveBMJLResult
		{
			get;
			set;
		}

		public string? ApproveBMJLMemo
		{
			get;
			set;
		}

		public int? ApproveFKRBUserID
		{
			get;
			set;
		}

		public DateTime? ApproveFKRBActionTime
		{
			get;
			set;
		}

		public string? ApproveFKRBResult
		{
			get;
			set;
		}

		public string? ApproveFKRBMemo
		{
			get;
			set;
		}

		public int? ApproveZJLUserID
		{
			get;
			set;
		}

		public DateTime? ApproveZJLActionTime
		{
			get;
			set;
		}

		public string? ApproveZJLResult
		{
			get;
			set;
		}

		public string? ApproveZJLMemo
		{
			get;
			set;
		}

		public int? ApproveXSZLUserID
		{
			get;
			set;
		}

		public DateTime? ApproveXSZLActionTime
		{
			get;
			set;
		}

		public string? ApproveXSZLResult
		{
			get;
			set;
		}

		public string? ApproveXSZLMemo
		{
			get;
			set;
		}

		public bool? ApproveXSZLIsCrossCity
		{
			get;
			set;
		}

		public int? ApproveXSZLCrossCityID
		{
			get;
			set;
		}

		public int? ApproveXSZLCrossCityUserID
		{
			get;
			set;
		}

		public int? ApproveXSZLContractFileID
		{
			get;
			set;
		}

		public string? CurrentNode
		{
			get;
			set;
		}

		public string? CurrentStatus
		{
			get;
			set;
		}
		#endregion
        
        #region Navigation List
        public List<ApproveRecordGroupBy> ApproveRecordGroupByList
        {
            get;
            set;
        }
        public List<GroupByItem> GroupByItemList
        {
            get;
            set;
        }
        public List<GroupBySales> GroupBySalesList
        {
            get;
            set;
        }
        public List<GroupDRDWuLiu> GroupDRDWuLiuList
        {
            get;
            set;
        }
        public List<GroupGeneral> GroupGeneralList
        {
            get;
            set;
        }
        public List<GroupLvYou> GroupLvYouList
        {
            get;
            set;
        }
        public List<GroupSheYing> GroupSheYingList
        {
            get;
            set;
        }
        #endregion

}
#endregion
}

