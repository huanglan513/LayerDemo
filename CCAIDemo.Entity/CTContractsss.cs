using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CCAIDemo.Entity
{
    #region CT_Contract
    /// <summary>
    /// This object represents the properties and methods of a CT_Contract.
    /// </summary>
    public class CTContract
    {
        private string _id;
        private short _reportType;
        private string _payWay = String.Empty;
        private string _trade = String.Empty;
        private string _propertyID = String.Empty;
        private string _contractNo = String.Empty;
        private DateTime _contractDate;
        private string _empID = String.Empty;
        private string _deptID = String.Empty;
        private decimal _price;
        private string _priceUnitName = String.Empty;
        private decimal _unitPrice;
        private decimal _ownerTradeFee;
        private decimal _feeOwnerDiscount;
        private decimal _feeOwner;
        private decimal _customerTradeFee;
        private decimal _feeCustomerDiscount;
        private decimal _feeCustomer;
        private short _auditFlag;
        private string _propertyPayWay = String.Empty;
        private int _propertyLoanYear;
        private decimal _propertyLoanMoney;
        private decimal _propertySurplusYear;
        private decimal _propertyPayMoney;
        private string _reportNo = String.Empty;
        private short _reportFlag;
        private string _contractNumber = String.Empty;
        private DateTime _ownerSignDate;
        private DateTime _customerSignDate;
        private DateTime _rentStartDate;
        private DateTime _rentEndDate;
        private string _rentTerm = String.Empty;
        private string _orderNo = String.Empty;
        private DateTime _ownerFeePromiseDate;
        private DateTime _customerFeePromiseDate;
        private DateTime _estimatePaymentDate;
        private decimal _estimatePaymentMoney;
        private string _remark = String.Empty;
        private decimal _feePropertyPercent;
        private decimal _feeCustomerPercent;
        private DateTime _modDate;
        private string _creator = String.Empty;
        private short _isMoneyCustody;
        private short _isAudit;
        private short _isAchievementReport;
        private short _isNeedMortageFollow;
        private short _canReport;
        private short _canAllocate;
        private DateTime _contractSignDate;
        private DateTime _intentSignDate;
        private string _propertyAddress = String.Empty;
        private short _subTrade;
        private decimal _feePercent;
        private short _contractKind;
        private DateTime _reportDate;
        private string _contractType = String.Empty;
        private string _secondhandContractNo = String.Empty;
        private string _fundsSuperviseNo = String.Empty;
        private short _checkCommisionState;
        private string _transferState = String.Empty;
        private decimal _receivedOwner;
        private DateTime _receivedOwnerDate;
        private string _receivedOwnerPayType = String.Empty;
        private decimal _receivedCustomer;
        private DateTime _receivedCustomerDate;
        private string _receivedCustomerPayType = String.Empty;
        private decimal _ownerRemain;
        private DateTime _ownerRemainPayDate;
        private string _ownerRemainPayType = String.Empty;
        private decimal _customerRemain;
        private DateTime _customerRemainPayDate;
        private string _customerRemainPayType = String.Empty;
        private short _canReleaseApplyFlag;
        private short _checkCommState;
        private DateTime _customerVisitDate;
        private string _oldContractID = String.Empty;
        private string _discountReason = String.Empty;
        private short _isChangeOwner;
        private short _certFeeType;
        private decimal _certFee;
        private short _isAgent;
        private string _additionalRemark = String.Empty;
        private decimal _certFeeSelf;
        private decimal _certFeeDecrease;
        private short _propertyType;

        public CTContract()
        {
        }

        public CTContract(string id)
        {
            // NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
            SqlService sql = new SqlService();
            sql.AddParameter("@ContractID", SqlDbType.NVarChar, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM CT_Contract WHERE ContractID = @ContractID");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("CT_Contract does not exist.");
            }
        }

        public CTContract(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetString(0);
                if (!reader.IsDBNull(1)) _reportType = reader.GetInt16(1);
                if (!reader.IsDBNull(2)) _payWay = reader.GetString(2);
                if (!reader.IsDBNull(3)) _trade = reader.GetString(3);
                if (!reader.IsDBNull(4)) _propertyID = reader.GetString(4);
                if (!reader.IsDBNull(5)) _contractNo = reader.GetString(5);
                if (!reader.IsDBNull(6)) _contractDate = reader.GetDateTime(6);
                if (!reader.IsDBNull(7)) _empID = reader.GetString(7);
                if (!reader.IsDBNull(8)) _deptID = reader.GetString(8);
                if (!reader.IsDBNull(9)) _price = reader.GetDecimal(9);
                if (!reader.IsDBNull(10)) _priceUnitName = reader.GetString(10);
                if (!reader.IsDBNull(11)) _unitPrice = reader.GetDecimal(11);
                if (!reader.IsDBNull(12)) _ownerTradeFee = reader.GetDecimal(12);
                if (!reader.IsDBNull(13)) _feeOwnerDiscount = reader.GetDecimal(13);
                if (!reader.IsDBNull(14)) _feeOwner = reader.GetDecimal(14);
                if (!reader.IsDBNull(15)) _customerTradeFee = reader.GetDecimal(15);
                if (!reader.IsDBNull(16)) _feeCustomerDiscount = reader.GetDecimal(16);
                if (!reader.IsDBNull(17)) _feeCustomer = reader.GetDecimal(17);
                if (!reader.IsDBNull(18)) _auditFlag = reader.GetInt16(18);
                if (!reader.IsDBNull(19)) _propertyPayWay = reader.GetString(19);
                if (!reader.IsDBNull(20)) _propertyLoanYear = reader.GetInt32(20);
                if (!reader.IsDBNull(21)) _propertyLoanMoney = reader.GetDecimal(21);
                if (!reader.IsDBNull(22)) _propertySurplusYear = reader.GetDecimal(22);
                if (!reader.IsDBNull(23)) _propertyPayMoney = reader.GetDecimal(23);
                if (!reader.IsDBNull(24)) _reportNo = reader.GetString(24);
                if (!reader.IsDBNull(25)) _reportFlag = reader.GetInt16(25);
                if (!reader.IsDBNull(26)) _contractNumber = reader.GetString(26);
                if (!reader.IsDBNull(27)) _ownerSignDate = reader.GetDateTime(27);
                if (!reader.IsDBNull(28)) _customerSignDate = reader.GetDateTime(28);
                if (!reader.IsDBNull(29)) _rentStartDate = reader.GetDateTime(29);
                if (!reader.IsDBNull(30)) _rentEndDate = reader.GetDateTime(30);
                if (!reader.IsDBNull(31)) _rentTerm = reader.GetString(31);
                if (!reader.IsDBNull(32)) _orderNo = reader.GetString(32);
                if (!reader.IsDBNull(33)) _ownerFeePromiseDate = reader.GetDateTime(33);
                if (!reader.IsDBNull(34)) _customerFeePromiseDate = reader.GetDateTime(34);
                if (!reader.IsDBNull(35)) _estimatePaymentDate = reader.GetDateTime(35);
                if (!reader.IsDBNull(36)) _estimatePaymentMoney = reader.GetDecimal(36);
                if (!reader.IsDBNull(37)) _remark = reader.GetString(37);
                if (!reader.IsDBNull(38)) _feePropertyPercent = reader.GetDecimal(38);
                if (!reader.IsDBNull(39)) _feeCustomerPercent = reader.GetDecimal(39);
                if (!reader.IsDBNull(40)) _modDate = reader.GetDateTime(40);
                if (!reader.IsDBNull(41)) _creator = reader.GetString(41);
                if (!reader.IsDBNull(42)) _isMoneyCustody = reader.GetInt16(42);
                if (!reader.IsDBNull(43)) _isAudit = reader.GetInt16(43);
                if (!reader.IsDBNull(44)) _isAchievementReport = reader.GetInt16(44);
                if (!reader.IsDBNull(45)) _isNeedMortageFollow = reader.GetInt16(45);
                if (!reader.IsDBNull(46)) _canReport = reader.GetInt16(46);
                if (!reader.IsDBNull(47)) _canAllocate = reader.GetInt16(47);
                if (!reader.IsDBNull(48)) _contractSignDate = reader.GetDateTime(48);
                if (!reader.IsDBNull(49)) _intentSignDate = reader.GetDateTime(49);
                if (!reader.IsDBNull(50)) _propertyAddress = reader.GetString(50);
                if (!reader.IsDBNull(51)) _subTrade = reader.GetInt16(51);
                if (!reader.IsDBNull(52)) _feePercent = reader.GetDecimal(52);
                if (!reader.IsDBNull(53)) _contractKind = reader.GetInt16(53);
                if (!reader.IsDBNull(54)) _reportDate = reader.GetDateTime(54);
                if (!reader.IsDBNull(55)) _contractType = reader.GetString(55);
                if (!reader.IsDBNull(56)) _secondhandContractNo = reader.GetString(56);
                if (!reader.IsDBNull(57)) _fundsSuperviseNo = reader.GetString(57);
                if (!reader.IsDBNull(58)) _checkCommisionState = reader.GetInt16(58);
                if (!reader.IsDBNull(59)) _transferState = reader.GetString(59);
                if (!reader.IsDBNull(60)) _receivedOwner = reader.GetDecimal(60);
                if (!reader.IsDBNull(61)) _receivedOwnerDate = reader.GetDateTime(61);
                if (!reader.IsDBNull(62)) _receivedOwnerPayType = reader.GetString(62);
                if (!reader.IsDBNull(63)) _receivedCustomer = reader.GetDecimal(63);
                if (!reader.IsDBNull(64)) _receivedCustomerDate = reader.GetDateTime(64);
                if (!reader.IsDBNull(65)) _receivedCustomerPayType = reader.GetString(65);
                if (!reader.IsDBNull(66)) _ownerRemain = reader.GetDecimal(66);
                if (!reader.IsDBNull(67)) _ownerRemainPayDate = reader.GetDateTime(67);
                if (!reader.IsDBNull(68)) _ownerRemainPayType = reader.GetString(68);
                if (!reader.IsDBNull(69)) _customerRemain = reader.GetDecimal(69);
                if (!reader.IsDBNull(70)) _customerRemainPayDate = reader.GetDateTime(70);
                if (!reader.IsDBNull(71)) _customerRemainPayType = reader.GetString(71);
                if (!reader.IsDBNull(72)) _canReleaseApplyFlag = reader.GetInt16(72);
                if (!reader.IsDBNull(73)) _checkCommState = reader.GetInt16(73);
                if (!reader.IsDBNull(74)) _customerVisitDate = reader.GetDateTime(74);
                if (!reader.IsDBNull(75)) _oldContractID = reader.GetString(75);
                if (!reader.IsDBNull(76)) _discountReason = reader.GetString(76);
                if (!reader.IsDBNull(77)) _isChangeOwner = reader.GetInt16(77);
                if (!reader.IsDBNull(78)) _certFeeType = reader.GetInt16(78);
                if (!reader.IsDBNull(79)) _certFee = reader.GetDecimal(79);
                if (!reader.IsDBNull(80)) _isAgent = reader.GetInt16(80);
                if (!reader.IsDBNull(81)) _additionalRemark = reader.GetString(81);
                if (!reader.IsDBNull(82)) _certFeeSelf = reader.GetDecimal(82);
                if (!reader.IsDBNull(83)) _certFeeDecrease = reader.GetDecimal(83);
                if (!reader.IsDBNull(84)) _propertyType = reader.GetInt16(84);
            }
        }

        public void Delete()
        {
            CTContract.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@ContractID", SqlDbType.NVarChar, Id);
            queryParameters.Append("ContractID = @ContractID");

            sql.AddParameter("@ReportType", SqlDbType.SmallInt, ReportType);
            queryParameters.Append(", ReportType = @ReportType");
            sql.AddParameter("@PayWay", SqlDbType.NVarChar, PayWay);
            queryParameters.Append(", PayWay = @PayWay");
            sql.AddParameter("@Trade", SqlDbType.NVarChar, Trade);
            queryParameters.Append(", Trade = @Trade");
            sql.AddParameter("@PropertyID", SqlDbType.NVarChar, PropertyID);
            queryParameters.Append(", PropertyID = @PropertyID");
            sql.AddParameter("@ContractNo", SqlDbType.NVarChar, ContractNo);
            queryParameters.Append(", ContractNo = @ContractNo");
            sql.AddParameter("@ContractDate", SqlDbType.Date, ContractDate);
            queryParameters.Append(", ContractDate = @ContractDate");
            sql.AddParameter("@EmpID", SqlDbType.NVarChar, EmpID);
            queryParameters.Append(", EmpID = @EmpID");
            sql.AddParameter("@DeptID", SqlDbType.NVarChar, DeptID);
            queryParameters.Append(", DeptID = @DeptID");
            sql.AddParameter("@Price", SqlDbType.Decimal, Price);
            queryParameters.Append(", Price = @Price");
            sql.AddParameter("@PriceUnitName", SqlDbType.NVarChar, PriceUnitName);
            queryParameters.Append(", PriceUnitName = @PriceUnitName");
            sql.AddParameter("@UnitPrice", SqlDbType.Decimal, UnitPrice);
            queryParameters.Append(", UnitPrice = @UnitPrice");
            sql.AddParameter("@OwnerTradeFee", SqlDbType.Decimal, OwnerTradeFee);
            queryParameters.Append(", OwnerTradeFee = @OwnerTradeFee");
            sql.AddParameter("@FeeOwnerDiscount", SqlDbType.Decimal, FeeOwnerDiscount);
            queryParameters.Append(", FeeOwnerDiscount = @FeeOwnerDiscount");
            sql.AddParameter("@FeeOwner", SqlDbType.Decimal, FeeOwner);
            queryParameters.Append(", FeeOwner = @FeeOwner");
            sql.AddParameter("@CustomerTradeFee", SqlDbType.Decimal, CustomerTradeFee);
            queryParameters.Append(", CustomerTradeFee = @CustomerTradeFee");
            sql.AddParameter("@FeeCustomerDiscount", SqlDbType.Decimal, FeeCustomerDiscount);
            queryParameters.Append(", FeeCustomerDiscount = @FeeCustomerDiscount");
            sql.AddParameter("@FeeCustomer", SqlDbType.Decimal, FeeCustomer);
            queryParameters.Append(", FeeCustomer = @FeeCustomer");
            sql.AddParameter("@AuditFlag", SqlDbType.SmallInt, AuditFlag);
            queryParameters.Append(", AuditFlag = @AuditFlag");
            sql.AddParameter("@PropertyPayWay", SqlDbType.NVarChar, PropertyPayWay);
            queryParameters.Append(", PropertyPayWay = @PropertyPayWay");
            sql.AddParameter("@PropertyLoanYear", SqlDbType.Int, PropertyLoanYear);
            queryParameters.Append(", PropertyLoanYear = @PropertyLoanYear");
            sql.AddParameter("@PropertyLoanMoney", SqlDbType.Decimal, PropertyLoanMoney);
            queryParameters.Append(", PropertyLoanMoney = @PropertyLoanMoney");
            sql.AddParameter("@PropertySurplusYear", SqlDbType.Decimal, PropertySurplusYear);
            queryParameters.Append(", PropertySurplusYear = @PropertySurplusYear");
            sql.AddParameter("@PropertyPayMoney", SqlDbType.Decimal, PropertyPayMoney);
            queryParameters.Append(", PropertyPayMoney = @PropertyPayMoney");
            sql.AddParameter("@ReportNo", SqlDbType.NVarChar, ReportNo);
            queryParameters.Append(", ReportNo = @ReportNo");
            sql.AddParameter("@ReportFlag", SqlDbType.SmallInt, ReportFlag);
            queryParameters.Append(", ReportFlag = @ReportFlag");
            sql.AddParameter("@ContractNumber", SqlDbType.NVarChar, ContractNumber);
            queryParameters.Append(", ContractNumber = @ContractNumber");
            sql.AddParameter("@OwnerSignDate", SqlDbType.Date, OwnerSignDate);
            queryParameters.Append(", OwnerSignDate = @OwnerSignDate");
            sql.AddParameter("@CustomerSignDate", SqlDbType.Date, CustomerSignDate);
            queryParameters.Append(", CustomerSignDate = @CustomerSignDate");
            sql.AddParameter("@RentStartDate", SqlDbType.Date, RentStartDate);
            queryParameters.Append(", RentStartDate = @RentStartDate");
            sql.AddParameter("@RentEndDate", SqlDbType.Date, RentEndDate);
            queryParameters.Append(", RentEndDate = @RentEndDate");
            sql.AddParameter("@RentTerm", SqlDbType.NVarChar, RentTerm);
            queryParameters.Append(", RentTerm = @RentTerm");
            sql.AddParameter("@OrderNo", SqlDbType.NVarChar, OrderNo);
            queryParameters.Append(", OrderNo = @OrderNo");
            sql.AddParameter("@OwnerFeePromiseDate", SqlDbType.Date, OwnerFeePromiseDate);
            queryParameters.Append(", OwnerFeePromiseDate = @OwnerFeePromiseDate");
            sql.AddParameter("@CustomerFeePromiseDate", SqlDbType.Date, CustomerFeePromiseDate);
            queryParameters.Append(", CustomerFeePromiseDate = @CustomerFeePromiseDate");
            sql.AddParameter("@EstimatePaymentDate", SqlDbType.Date, EstimatePaymentDate);
            queryParameters.Append(", EstimatePaymentDate = @EstimatePaymentDate");
            sql.AddParameter("@EstimatePaymentMoney", SqlDbType.Decimal, EstimatePaymentMoney);
            queryParameters.Append(", EstimatePaymentMoney = @EstimatePaymentMoney");
            sql.AddParameter("@Remark", SqlDbType.NVarChar, Remark);
            queryParameters.Append(", Remark = @Remark");
            sql.AddParameter("@FeePropertyPercent", SqlDbType.Decimal, FeePropertyPercent);
            queryParameters.Append(", FeePropertyPercent = @FeePropertyPercent");
            sql.AddParameter("@FeeCustomerPercent", SqlDbType.Decimal, FeeCustomerPercent);
            queryParameters.Append(", FeeCustomerPercent = @FeeCustomerPercent");
            sql.AddParameter("@ModDate", SqlDbType.DateTime, ModDate);
            queryParameters.Append(", ModDate = @ModDate");
            sql.AddParameter("@Creator", SqlDbType.NVarChar, Creator);
            queryParameters.Append(", Creator = @Creator");
            sql.AddParameter("@IsMoneyCustody", SqlDbType.SmallInt, IsMoneyCustody);
            queryParameters.Append(", IsMoneyCustody = @IsMoneyCustody");
            sql.AddParameter("@IsAudit", SqlDbType.SmallInt, IsAudit);
            queryParameters.Append(", IsAudit = @IsAudit");
            sql.AddParameter("@IsAchievementReport", SqlDbType.SmallInt, IsAchievementReport);
            queryParameters.Append(", IsAchievementReport = @IsAchievementReport");
            sql.AddParameter("@IsNeedMortageFollow", SqlDbType.SmallInt, IsNeedMortageFollow);
            queryParameters.Append(", IsNeedMortageFollow = @IsNeedMortageFollow");
            sql.AddParameter("@CanReport", SqlDbType.SmallInt, CanReport);
            queryParameters.Append(", CanReport = @CanReport");
            sql.AddParameter("@CanAllocate", SqlDbType.SmallInt, CanAllocate);
            queryParameters.Append(", CanAllocate = @CanAllocate");
            sql.AddParameter("@ContractSignDate", SqlDbType.DateTime, ContractSignDate);
            queryParameters.Append(", ContractSignDate = @ContractSignDate");
            sql.AddParameter("@IntentSignDate", SqlDbType.DateTime, IntentSignDate);
            queryParameters.Append(", IntentSignDate = @IntentSignDate");
            sql.AddParameter("@PropertyAddress", SqlDbType.NVarChar, PropertyAddress);
            queryParameters.Append(", PropertyAddress = @PropertyAddress");
            sql.AddParameter("@SubTrade", SqlDbType.SmallInt, SubTrade);
            queryParameters.Append(", SubTrade = @SubTrade");
            sql.AddParameter("@FeePercent", SqlDbType.Decimal, FeePercent);
            queryParameters.Append(", FeePercent = @FeePercent");
            sql.AddParameter("@ContractKind", SqlDbType.SmallInt, ContractKind);
            queryParameters.Append(", ContractKind = @ContractKind");
            sql.AddParameter("@ReportDate", SqlDbType.Date, ReportDate);
            queryParameters.Append(", ReportDate = @ReportDate");
            sql.AddParameter("@ContractType", SqlDbType.NVarChar, ContractType);
            queryParameters.Append(", ContractType = @ContractType");
            sql.AddParameter("@SecondhandContractNo", SqlDbType.VarChar, SecondhandContractNo);
            queryParameters.Append(", SecondhandContractNo = @SecondhandContractNo");
            sql.AddParameter("@FundsSuperviseNo", SqlDbType.VarChar, FundsSuperviseNo);
            queryParameters.Append(", FundsSuperviseNo = @FundsSuperviseNo");
            sql.AddParameter("@CheckCommisionState", SqlDbType.SmallInt, CheckCommisionState);
            queryParameters.Append(", CheckCommisionState = @CheckCommisionState");
            sql.AddParameter("@TransferState", SqlDbType.NVarChar, TransferState);
            queryParameters.Append(", TransferState = @TransferState");
            sql.AddParameter("@ReceivedOwner", SqlDbType.Decimal, ReceivedOwner);
            queryParameters.Append(", ReceivedOwner = @ReceivedOwner");
            sql.AddParameter("@ReceivedOwnerDate", SqlDbType.Date, ReceivedOwnerDate);
            queryParameters.Append(", ReceivedOwnerDate = @ReceivedOwnerDate");
            sql.AddParameter("@ReceivedOwnerPayType", SqlDbType.NVarChar, ReceivedOwnerPayType);
            queryParameters.Append(", ReceivedOwnerPayType = @ReceivedOwnerPayType");
            sql.AddParameter("@ReceivedCustomer", SqlDbType.Decimal, ReceivedCustomer);
            queryParameters.Append(", ReceivedCustomer = @ReceivedCustomer");
            sql.AddParameter("@ReceivedCustomerDate", SqlDbType.Date, ReceivedCustomerDate);
            queryParameters.Append(", ReceivedCustomerDate = @ReceivedCustomerDate");
            sql.AddParameter("@ReceivedCustomerPayType", SqlDbType.NVarChar, ReceivedCustomerPayType);
            queryParameters.Append(", ReceivedCustomerPayType = @ReceivedCustomerPayType");
            sql.AddParameter("@OwnerRemain", SqlDbType.Decimal, OwnerRemain);
            queryParameters.Append(", OwnerRemain = @OwnerRemain");
            sql.AddParameter("@OwnerRemainPayDate", SqlDbType.Date, OwnerRemainPayDate);
            queryParameters.Append(", OwnerRemainPayDate = @OwnerRemainPayDate");
            sql.AddParameter("@OwnerRemainPayType", SqlDbType.NVarChar, OwnerRemainPayType);
            queryParameters.Append(", OwnerRemainPayType = @OwnerRemainPayType");
            sql.AddParameter("@CustomerRemain", SqlDbType.Decimal, CustomerRemain);
            queryParameters.Append(", CustomerRemain = @CustomerRemain");
            sql.AddParameter("@CustomerRemainPayDate", SqlDbType.Date, CustomerRemainPayDate);
            queryParameters.Append(", CustomerRemainPayDate = @CustomerRemainPayDate");
            sql.AddParameter("@CustomerRemainPayType", SqlDbType.NVarChar, CustomerRemainPayType);
            queryParameters.Append(", CustomerRemainPayType = @CustomerRemainPayType");
            sql.AddParameter("@CanReleaseApplyFlag", SqlDbType.SmallInt, CanReleaseApplyFlag);
            queryParameters.Append(", CanReleaseApplyFlag = @CanReleaseApplyFlag");
            sql.AddParameter("@CheckCommState", SqlDbType.SmallInt, CheckCommState);
            queryParameters.Append(", CheckCommState = @CheckCommState");
            sql.AddParameter("@CustomerVisitDate", SqlDbType.Date, CustomerVisitDate);
            queryParameters.Append(", CustomerVisitDate = @CustomerVisitDate");
            sql.AddParameter("@OldContractID", SqlDbType.NVarChar, OldContractID);
            queryParameters.Append(", OldContractID = @OldContractID");
            sql.AddParameter("@DiscountReason", SqlDbType.NVarChar, DiscountReason);
            queryParameters.Append(", DiscountReason = @DiscountReason");
            sql.AddParameter("@IsChangeOwner", SqlDbType.SmallInt, IsChangeOwner);
            queryParameters.Append(", IsChangeOwner = @IsChangeOwner");
            sql.AddParameter("@CertFeeType", SqlDbType.SmallInt, CertFeeType);
            queryParameters.Append(", CertFeeType = @CertFeeType");
            sql.AddParameter("@CertFee", SqlDbType.Decimal, CertFee);
            queryParameters.Append(", CertFee = @CertFee");
            sql.AddParameter("@IsAgent", SqlDbType.SmallInt, IsAgent);
            queryParameters.Append(", IsAgent = @IsAgent");
            sql.AddParameter("@AdditionalRemark", SqlDbType.NVarChar, AdditionalRemark);
            queryParameters.Append(", AdditionalRemark = @AdditionalRemark");
            sql.AddParameter("@CertFeeSelf", SqlDbType.Decimal, CertFeeSelf);
            queryParameters.Append(", CertFeeSelf = @CertFeeSelf");
            sql.AddParameter("@CertFeeDecrease", SqlDbType.Decimal, CertFeeDecrease);
            queryParameters.Append(", CertFeeDecrease = @CertFeeDecrease");
            sql.AddParameter("@PropertyType", SqlDbType.SmallInt, PropertyType);
            queryParameters.Append(", PropertyType = @PropertyType");

            string query = String.Format("Update CT_Contract Set {0} Where ContractID = @ContractID", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@ContractID", SqlDbType.NVarChar, Id);
            queryParameters.Append("@ContractID");

            sql.AddParameter("@ReportType", SqlDbType.SmallInt, ReportType);
            queryParameters.Append(", @ReportType");
            sql.AddParameter("@PayWay", SqlDbType.NVarChar, PayWay);
            queryParameters.Append(", @PayWay");
            sql.AddParameter("@Trade", SqlDbType.NVarChar, Trade);
            queryParameters.Append(", @Trade");
            sql.AddParameter("@PropertyID", SqlDbType.NVarChar, PropertyID);
            queryParameters.Append(", @PropertyID");
            sql.AddParameter("@ContractNo", SqlDbType.NVarChar, ContractNo);
            queryParameters.Append(", @ContractNo");
            sql.AddParameter("@ContractDate", SqlDbType.Date, ContractDate);
            queryParameters.Append(", @ContractDate");
            sql.AddParameter("@EmpID", SqlDbType.NVarChar, EmpID);
            queryParameters.Append(", @EmpID");
            sql.AddParameter("@DeptID", SqlDbType.NVarChar, DeptID);
            queryParameters.Append(", @DeptID");
            sql.AddParameter("@Price", SqlDbType.Decimal, Price);
            queryParameters.Append(", @Price");
            sql.AddParameter("@PriceUnitName", SqlDbType.NVarChar, PriceUnitName);
            queryParameters.Append(", @PriceUnitName");
            sql.AddParameter("@UnitPrice", SqlDbType.Decimal, UnitPrice);
            queryParameters.Append(", @UnitPrice");
            sql.AddParameter("@OwnerTradeFee", SqlDbType.Decimal, OwnerTradeFee);
            queryParameters.Append(", @OwnerTradeFee");
            sql.AddParameter("@FeeOwnerDiscount", SqlDbType.Decimal, FeeOwnerDiscount);
            queryParameters.Append(", @FeeOwnerDiscount");
            sql.AddParameter("@FeeOwner", SqlDbType.Decimal, FeeOwner);
            queryParameters.Append(", @FeeOwner");
            sql.AddParameter("@CustomerTradeFee", SqlDbType.Decimal, CustomerTradeFee);
            queryParameters.Append(", @CustomerTradeFee");
            sql.AddParameter("@FeeCustomerDiscount", SqlDbType.Decimal, FeeCustomerDiscount);
            queryParameters.Append(", @FeeCustomerDiscount");
            sql.AddParameter("@FeeCustomer", SqlDbType.Decimal, FeeCustomer);
            queryParameters.Append(", @FeeCustomer");
            sql.AddParameter("@AuditFlag", SqlDbType.SmallInt, AuditFlag);
            queryParameters.Append(", @AuditFlag");
            sql.AddParameter("@PropertyPayWay", SqlDbType.NVarChar, PropertyPayWay);
            queryParameters.Append(", @PropertyPayWay");
            sql.AddParameter("@PropertyLoanYear", SqlDbType.Int, PropertyLoanYear);
            queryParameters.Append(", @PropertyLoanYear");
            sql.AddParameter("@PropertyLoanMoney", SqlDbType.Decimal, PropertyLoanMoney);
            queryParameters.Append(", @PropertyLoanMoney");
            sql.AddParameter("@PropertySurplusYear", SqlDbType.Decimal, PropertySurplusYear);
            queryParameters.Append(", @PropertySurplusYear");
            sql.AddParameter("@PropertyPayMoney", SqlDbType.Decimal, PropertyPayMoney);
            queryParameters.Append(", @PropertyPayMoney");
            sql.AddParameter("@ReportNo", SqlDbType.NVarChar, ReportNo);
            queryParameters.Append(", @ReportNo");
            sql.AddParameter("@ReportFlag", SqlDbType.SmallInt, ReportFlag);
            queryParameters.Append(", @ReportFlag");
            sql.AddParameter("@ContractNumber", SqlDbType.NVarChar, ContractNumber);
            queryParameters.Append(", @ContractNumber");
            sql.AddParameter("@OwnerSignDate", SqlDbType.Date, OwnerSignDate);
            queryParameters.Append(", @OwnerSignDate");
            sql.AddParameter("@CustomerSignDate", SqlDbType.Date, CustomerSignDate);
            queryParameters.Append(", @CustomerSignDate");
            sql.AddParameter("@RentStartDate", SqlDbType.Date, RentStartDate);
            queryParameters.Append(", @RentStartDate");
            sql.AddParameter("@RentEndDate", SqlDbType.Date, RentEndDate);
            queryParameters.Append(", @RentEndDate");
            sql.AddParameter("@RentTerm", SqlDbType.NVarChar, RentTerm);
            queryParameters.Append(", @RentTerm");
            sql.AddParameter("@OrderNo", SqlDbType.NVarChar, OrderNo);
            queryParameters.Append(", @OrderNo");
            sql.AddParameter("@OwnerFeePromiseDate", SqlDbType.Date, OwnerFeePromiseDate);
            queryParameters.Append(", @OwnerFeePromiseDate");
            sql.AddParameter("@CustomerFeePromiseDate", SqlDbType.Date, CustomerFeePromiseDate);
            queryParameters.Append(", @CustomerFeePromiseDate");
            sql.AddParameter("@EstimatePaymentDate", SqlDbType.Date, EstimatePaymentDate);
            queryParameters.Append(", @EstimatePaymentDate");
            sql.AddParameter("@EstimatePaymentMoney", SqlDbType.Decimal, EstimatePaymentMoney);
            queryParameters.Append(", @EstimatePaymentMoney");
            sql.AddParameter("@Remark", SqlDbType.NVarChar, Remark);
            queryParameters.Append(", @Remark");
            sql.AddParameter("@FeePropertyPercent", SqlDbType.Decimal, FeePropertyPercent);
            queryParameters.Append(", @FeePropertyPercent");
            sql.AddParameter("@FeeCustomerPercent", SqlDbType.Decimal, FeeCustomerPercent);
            queryParameters.Append(", @FeeCustomerPercent");
            sql.AddParameter("@ModDate", SqlDbType.DateTime, ModDate);
            queryParameters.Append(", @ModDate");
            sql.AddParameter("@Creator", SqlDbType.NVarChar, Creator);
            queryParameters.Append(", @Creator");
            sql.AddParameter("@IsMoneyCustody", SqlDbType.SmallInt, IsMoneyCustody);
            queryParameters.Append(", @IsMoneyCustody");
            sql.AddParameter("@IsAudit", SqlDbType.SmallInt, IsAudit);
            queryParameters.Append(", @IsAudit");
            sql.AddParameter("@IsAchievementReport", SqlDbType.SmallInt, IsAchievementReport);
            queryParameters.Append(", @IsAchievementReport");
            sql.AddParameter("@IsNeedMortageFollow", SqlDbType.SmallInt, IsNeedMortageFollow);
            queryParameters.Append(", @IsNeedMortageFollow");
            sql.AddParameter("@CanReport", SqlDbType.SmallInt, CanReport);
            queryParameters.Append(", @CanReport");
            sql.AddParameter("@CanAllocate", SqlDbType.SmallInt, CanAllocate);
            queryParameters.Append(", @CanAllocate");
            sql.AddParameter("@ContractSignDate", SqlDbType.DateTime, ContractSignDate);
            queryParameters.Append(", @ContractSignDate");
            sql.AddParameter("@IntentSignDate", SqlDbType.DateTime, IntentSignDate);
            queryParameters.Append(", @IntentSignDate");
            sql.AddParameter("@PropertyAddress", SqlDbType.NVarChar, PropertyAddress);
            queryParameters.Append(", @PropertyAddress");
            sql.AddParameter("@SubTrade", SqlDbType.SmallInt, SubTrade);
            queryParameters.Append(", @SubTrade");
            sql.AddParameter("@FeePercent", SqlDbType.Decimal, FeePercent);
            queryParameters.Append(", @FeePercent");
            sql.AddParameter("@ContractKind", SqlDbType.SmallInt, ContractKind);
            queryParameters.Append(", @ContractKind");
            sql.AddParameter("@ReportDate", SqlDbType.Date, ReportDate);
            queryParameters.Append(", @ReportDate");
            sql.AddParameter("@ContractType", SqlDbType.NVarChar, ContractType);
            queryParameters.Append(", @ContractType");
            sql.AddParameter("@SecondhandContractNo", SqlDbType.VarChar, SecondhandContractNo);
            queryParameters.Append(", @SecondhandContractNo");
            sql.AddParameter("@FundsSuperviseNo", SqlDbType.VarChar, FundsSuperviseNo);
            queryParameters.Append(", @FundsSuperviseNo");
            sql.AddParameter("@CheckCommisionState", SqlDbType.SmallInt, CheckCommisionState);
            queryParameters.Append(", @CheckCommisionState");
            sql.AddParameter("@TransferState", SqlDbType.NVarChar, TransferState);
            queryParameters.Append(", @TransferState");
            sql.AddParameter("@ReceivedOwner", SqlDbType.Decimal, ReceivedOwner);
            queryParameters.Append(", @ReceivedOwner");
            sql.AddParameter("@ReceivedOwnerDate", SqlDbType.Date, ReceivedOwnerDate);
            queryParameters.Append(", @ReceivedOwnerDate");
            sql.AddParameter("@ReceivedOwnerPayType", SqlDbType.NVarChar, ReceivedOwnerPayType);
            queryParameters.Append(", @ReceivedOwnerPayType");
            sql.AddParameter("@ReceivedCustomer", SqlDbType.Decimal, ReceivedCustomer);
            queryParameters.Append(", @ReceivedCustomer");
            sql.AddParameter("@ReceivedCustomerDate", SqlDbType.Date, ReceivedCustomerDate);
            queryParameters.Append(", @ReceivedCustomerDate");
            sql.AddParameter("@ReceivedCustomerPayType", SqlDbType.NVarChar, ReceivedCustomerPayType);
            queryParameters.Append(", @ReceivedCustomerPayType");
            sql.AddParameter("@OwnerRemain", SqlDbType.Decimal, OwnerRemain);
            queryParameters.Append(", @OwnerRemain");
            sql.AddParameter("@OwnerRemainPayDate", SqlDbType.Date, OwnerRemainPayDate);
            queryParameters.Append(", @OwnerRemainPayDate");
            sql.AddParameter("@OwnerRemainPayType", SqlDbType.NVarChar, OwnerRemainPayType);
            queryParameters.Append(", @OwnerRemainPayType");
            sql.AddParameter("@CustomerRemain", SqlDbType.Decimal, CustomerRemain);
            queryParameters.Append(", @CustomerRemain");
            sql.AddParameter("@CustomerRemainPayDate", SqlDbType.Date, CustomerRemainPayDate);
            queryParameters.Append(", @CustomerRemainPayDate");
            sql.AddParameter("@CustomerRemainPayType", SqlDbType.NVarChar, CustomerRemainPayType);
            queryParameters.Append(", @CustomerRemainPayType");
            sql.AddParameter("@CanReleaseApplyFlag", SqlDbType.SmallInt, CanReleaseApplyFlag);
            queryParameters.Append(", @CanReleaseApplyFlag");
            sql.AddParameter("@CheckCommState", SqlDbType.SmallInt, CheckCommState);
            queryParameters.Append(", @CheckCommState");
            sql.AddParameter("@CustomerVisitDate", SqlDbType.Date, CustomerVisitDate);
            queryParameters.Append(", @CustomerVisitDate");
            sql.AddParameter("@OldContractID", SqlDbType.NVarChar, OldContractID);
            queryParameters.Append(", @OldContractID");
            sql.AddParameter("@DiscountReason", SqlDbType.NVarChar, DiscountReason);
            queryParameters.Append(", @DiscountReason");
            sql.AddParameter("@IsChangeOwner", SqlDbType.SmallInt, IsChangeOwner);
            queryParameters.Append(", @IsChangeOwner");
            sql.AddParameter("@CertFeeType", SqlDbType.SmallInt, CertFeeType);
            queryParameters.Append(", @CertFeeType");
            sql.AddParameter("@CertFee", SqlDbType.Decimal, CertFee);
            queryParameters.Append(", @CertFee");
            sql.AddParameter("@IsAgent", SqlDbType.SmallInt, IsAgent);
            queryParameters.Append(", @IsAgent");
            sql.AddParameter("@AdditionalRemark", SqlDbType.NVarChar, AdditionalRemark);
            queryParameters.Append(", @AdditionalRemark");
            sql.AddParameter("@CertFeeSelf", SqlDbType.Decimal, CertFeeSelf);
            queryParameters.Append(", @CertFeeSelf");
            sql.AddParameter("@CertFeeDecrease", SqlDbType.Decimal, CertFeeDecrease);
            queryParameters.Append(", @CertFeeDecrease");
            sql.AddParameter("@PropertyType", SqlDbType.SmallInt, PropertyType);
            queryParameters.Append(", @PropertyType");

            string query = String.Format("Insert Into CT_Contract ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static CTContract NewCT_Contract(string id)
        {
            CTContract newEntity = new CTContract();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public short ReportType
        {
            get { return _reportType; }
            set { _reportType = value; }
        }

        public string PayWay
        {
            get { return _payWay; }
            set { _payWay = value; }
        }

        public string Trade
        {
            get { return _trade; }
            set { _trade = value; }
        }

        public string PropertyID
        {
            get { return _propertyID; }
            set { _propertyID = value; }
        }

        public string ContractNo
        {
            get { return _contractNo; }
            set { _contractNo = value; }
        }

        public DateTime ContractDate
        {
            get { return _contractDate; }
            set { _contractDate = value; }
        }

        public string EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        public string DeptID
        {
            get { return _deptID; }
            set { _deptID = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string PriceUnitName
        {
            get { return _priceUnitName; }
            set { _priceUnitName = value; }
        }

        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public decimal OwnerTradeFee
        {
            get { return _ownerTradeFee; }
            set { _ownerTradeFee = value; }
        }

        public decimal FeeOwnerDiscount
        {
            get { return _feeOwnerDiscount; }
            set { _feeOwnerDiscount = value; }
        }

        public decimal FeeOwner
        {
            get { return _feeOwner; }
            set { _feeOwner = value; }
        }

        public decimal CustomerTradeFee
        {
            get { return _customerTradeFee; }
            set { _customerTradeFee = value; }
        }

        public decimal FeeCustomerDiscount
        {
            get { return _feeCustomerDiscount; }
            set { _feeCustomerDiscount = value; }
        }

        public decimal FeeCustomer
        {
            get { return _feeCustomer; }
            set { _feeCustomer = value; }
        }

        public short AuditFlag
        {
            get { return _auditFlag; }
            set { _auditFlag = value; }
        }

        public string PropertyPayWay
        {
            get { return _propertyPayWay; }
            set { _propertyPayWay = value; }
        }

        public int PropertyLoanYear
        {
            get { return _propertyLoanYear; }
            set { _propertyLoanYear = value; }
        }

        public decimal PropertyLoanMoney
        {
            get { return _propertyLoanMoney; }
            set { _propertyLoanMoney = value; }
        }

        public decimal PropertySurplusYear
        {
            get { return _propertySurplusYear; }
            set { _propertySurplusYear = value; }
        }

        public decimal PropertyPayMoney
        {
            get { return _propertyPayMoney; }
            set { _propertyPayMoney = value; }
        }

        public string ReportNo
        {
            get { return _reportNo; }
            set { _reportNo = value; }
        }

        public short ReportFlag
        {
            get { return _reportFlag; }
            set { _reportFlag = value; }
        }

        public string ContractNumber
        {
            get { return _contractNumber; }
            set { _contractNumber = value; }
        }

        public DateTime OwnerSignDate
        {
            get { return _ownerSignDate; }
            set { _ownerSignDate = value; }
        }

        public DateTime CustomerSignDate
        {
            get { return _customerSignDate; }
            set { _customerSignDate = value; }
        }

        public DateTime RentStartDate
        {
            get { return _rentStartDate; }
            set { _rentStartDate = value; }
        }

        public DateTime RentEndDate
        {
            get { return _rentEndDate; }
            set { _rentEndDate = value; }
        }

        public string RentTerm
        {
            get { return _rentTerm; }
            set { _rentTerm = value; }
        }

        public string OrderNo
        {
            get { return _orderNo; }
            set { _orderNo = value; }
        }

        public DateTime OwnerFeePromiseDate
        {
            get { return _ownerFeePromiseDate; }
            set { _ownerFeePromiseDate = value; }
        }

        public DateTime CustomerFeePromiseDate
        {
            get { return _customerFeePromiseDate; }
            set { _customerFeePromiseDate = value; }
        }

        public DateTime EstimatePaymentDate
        {
            get { return _estimatePaymentDate; }
            set { _estimatePaymentDate = value; }
        }

        public decimal EstimatePaymentMoney
        {
            get { return _estimatePaymentMoney; }
            set { _estimatePaymentMoney = value; }
        }

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        public decimal FeePropertyPercent
        {
            get { return _feePropertyPercent; }
            set { _feePropertyPercent = value; }
        }

        public decimal FeeCustomerPercent
        {
            get { return _feeCustomerPercent; }
            set { _feeCustomerPercent = value; }
        }

        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        public string Creator
        {
            get { return _creator; }
            set { _creator = value; }
        }

        public short IsMoneyCustody
        {
            get { return _isMoneyCustody; }
            set { _isMoneyCustody = value; }
        }

        public short IsAudit
        {
            get { return _isAudit; }
            set { _isAudit = value; }
        }

        public short IsAchievementReport
        {
            get { return _isAchievementReport; }
            set { _isAchievementReport = value; }
        }

        public short IsNeedMortageFollow
        {
            get { return _isNeedMortageFollow; }
            set { _isNeedMortageFollow = value; }
        }

        public short CanReport
        {
            get { return _canReport; }
            set { _canReport = value; }
        }

        public short CanAllocate
        {
            get { return _canAllocate; }
            set { _canAllocate = value; }
        }

        public DateTime ContractSignDate
        {
            get { return _contractSignDate; }
            set { _contractSignDate = value; }
        }

        public DateTime IntentSignDate
        {
            get { return _intentSignDate; }
            set { _intentSignDate = value; }
        }

        public string PropertyAddress
        {
            get { return _propertyAddress; }
            set { _propertyAddress = value; }
        }

        public short SubTrade
        {
            get { return _subTrade; }
            set { _subTrade = value; }
        }

        public decimal FeePercent
        {
            get { return _feePercent; }
            set { _feePercent = value; }
        }

        public short ContractKind
        {
            get { return _contractKind; }
            set { _contractKind = value; }
        }

        public DateTime ReportDate
        {
            get { return _reportDate; }
            set { _reportDate = value; }
        }

        public string ContractType
        {
            get { return _contractType; }
            set { _contractType = value; }
        }

        public string SecondhandContractNo
        {
            get { return _secondhandContractNo; }
            set { _secondhandContractNo = value; }
        }

        public string FundsSuperviseNo
        {
            get { return _fundsSuperviseNo; }
            set { _fundsSuperviseNo = value; }
        }

        public short CheckCommisionState
        {
            get { return _checkCommisionState; }
            set { _checkCommisionState = value; }
        }

        public string TransferState
        {
            get { return _transferState; }
            set { _transferState = value; }
        }

        public decimal ReceivedOwner
        {
            get { return _receivedOwner; }
            set { _receivedOwner = value; }
        }

        public DateTime ReceivedOwnerDate
        {
            get { return _receivedOwnerDate; }
            set { _receivedOwnerDate = value; }
        }

        public string ReceivedOwnerPayType
        {
            get { return _receivedOwnerPayType; }
            set { _receivedOwnerPayType = value; }
        }

        public decimal ReceivedCustomer
        {
            get { return _receivedCustomer; }
            set { _receivedCustomer = value; }
        }

        public DateTime ReceivedCustomerDate
        {
            get { return _receivedCustomerDate; }
            set { _receivedCustomerDate = value; }
        }

        public string ReceivedCustomerPayType
        {
            get { return _receivedCustomerPayType; }
            set { _receivedCustomerPayType = value; }
        }

        public decimal OwnerRemain
        {
            get { return _ownerRemain; }
            set { _ownerRemain = value; }
        }

        public DateTime OwnerRemainPayDate
        {
            get { return _ownerRemainPayDate; }
            set { _ownerRemainPayDate = value; }
        }

        public string OwnerRemainPayType
        {
            get { return _ownerRemainPayType; }
            set { _ownerRemainPayType = value; }
        }

        public decimal CustomerRemain
        {
            get { return _customerRemain; }
            set { _customerRemain = value; }
        }

        public DateTime CustomerRemainPayDate
        {
            get { return _customerRemainPayDate; }
            set { _customerRemainPayDate = value; }
        }

        public string CustomerRemainPayType
        {
            get { return _customerRemainPayType; }
            set { _customerRemainPayType = value; }
        }

        public short CanReleaseApplyFlag
        {
            get { return _canReleaseApplyFlag; }
            set { _canReleaseApplyFlag = value; }
        }

        public short CheckCommState
        {
            get { return _checkCommState; }
            set { _checkCommState = value; }
        }

        public DateTime CustomerVisitDate
        {
            get { return _customerVisitDate; }
            set { _customerVisitDate = value; }
        }

        public string OldContractID
        {
            get { return _oldContractID; }
            set { _oldContractID = value; }
        }

        public string DiscountReason
        {
            get { return _discountReason; }
            set { _discountReason = value; }
        }

        public short IsChangeOwner
        {
            get { return _isChangeOwner; }
            set { _isChangeOwner = value; }
        }

        public short CertFeeType
        {
            get { return _certFeeType; }
            set { _certFeeType = value; }
        }

        public decimal CertFee
        {
            get { return _certFee; }
            set { _certFee = value; }
        }

        public short IsAgent
        {
            get { return _isAgent; }
            set { _isAgent = value; }
        }

        public string AdditionalRemark
        {
            get { return _additionalRemark; }
            set { _additionalRemark = value; }
        }

        public decimal CertFeeSelf
        {
            get { return _certFeeSelf; }
            set { _certFeeSelf = value; }
        }

        public decimal CertFeeDecrease
        {
            get { return _certFeeDecrease; }
            set { _certFeeDecrease = value; }
        }

        public short PropertyType
        {
            get { return _propertyType; }
            set { _propertyType = value; }
        }
        #endregion

        public static CTContract GetCT_Contract(string id)
        {
            return new CTContract(id);
        }

        public static void Delete(string id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@ContractID", SqlDbType.NVarChar, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete CT_Contract Where ContractID = @ContractID");
        }
    }
    #endregion
}
