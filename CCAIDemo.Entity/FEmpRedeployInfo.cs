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
	#region FEmpRedeployInfo
	/// <summary>
	/// This object represents the properties and navigation list of a FEmpRedeployInfo.
	/// </summary>
    [Serializable]
    [Table("F_Emp_RedeployInfo")]
	public class FEmpRedeployInfo
	{
		
		public FEmpRedeployInfo()
		{
		}
        
        #region Public Properties
        
        [Column("RedeployInfoID")]
		public string RedeployInfoID
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

        [Column("RedeployType")]
		public string RedeployType
		{
			get;
			set;
		}

        [Column("RedeployDate")]
		public DateTime? RedeployDate
		{
			get;
			set;
		}

        [Column("ApplyDate")]
		public DateTime? ApplyDate
		{
			get;
			set;
		}

        [Column("ApplyEmpID")]
		public string ApplyEmpID
		{
			get;
			set;
		}

        [Column("ApplyDeptID")]
		public string ApplyDeptID
		{
			get;
			set;
		}

        [Column("ApplyorAdUserID")]
		public string ApplyorAdUserID
		{
			get;
			set;
		}

        [Column("Reason")]
		public string Reason
		{
			get;
			set;
		}

        [Column("PreviousWorkInfoID")]
		public Guid? PreviousWorkInfoID
		{
			get;
			set;
		}

        [Column("AfterWorkInfoID")]
		public Guid? AfterWorkInfoID
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

        [Column("SalaryOld")]
		public decimal? SalaryOld
		{
			get;
			set;
		}

        [Column("SalaryNew")]
		public decimal? SalaryNew
		{
			get;
			set;
		}

        [Column("IsSalaryAdjust")]
		public short? IsSalaryAdjust
		{
			get;
			set;
		}

        [Column("RedeployInfoFlag")]
		public short? RedeployInfoFlag
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

        [Column("EmpDeptID")]
		public string EmpDeptID
		{
			get;
			set;
		}

        [Column("RedeployTypeID")]
		public int? RedeployTypeID
		{
			get;
			set;
		}

        [Column("BizRedeployTypeID")]
		public int? BizRedeployTypeID
		{
			get;
			set;
		}

        [Column("K3EmpID")]
		public string K3EmpID
		{
			get;
			set;
		}

        [Column("K3DeptID")]
		public string K3DeptID
		{
			get;
			set;
		}

        [Column("K3DeptName")]
		public string K3DeptName
		{
			get;
			set;
		}

        [Column("K3ProjectID")]
		public Guid? K3ProjectID
		{
			get;
			set;
		}

        [Column("K3ProjectName")]
		public string K3ProjectName
		{
			get;
			set;
		}

        [Column("K3ProjectFullName")]
		public string K3ProjectFullName
		{
			get;
			set;
		}

        [Column("K3EmpTitleID")]
		public string K3EmpTitleID
		{
			get;
			set;
		}

        [Column("K3EmpTitleName")]
		public string K3EmpTitleName
		{
			get;
			set;
		}

        [Column("K3DeptIDOrder")]
		public string K3DeptIDOrder
		{
			get;
			set;
		}

        [Column("K3DeptNameOrder")]
		public string K3DeptNameOrder
		{
			get;
			set;
		}

        [Column("K3ProjectIDOrder")]
		public string K3ProjectIDOrder
		{
			get;
			set;
		}

        [Column("K3ProjectNameOrder")]
		public string K3ProjectNameOrder
		{
			get;
			set;
		}

        [Column("K3ProjectFullNameOrder")]
		public string K3ProjectFullNameOrder
		{
			get;
			set;
		}

        [Column("K3EmpTitleIDOrder")]
		public string K3EmpTitleIDOrder
		{
			get;
			set;
		}

        [Column("K3EmpTitleNameOrder")]
		public string K3EmpTitleNameOrder
		{
			get;
			set;
		}

        [Column("PositionIDOrder")]
		public string PositionIDOrder
		{
			get;
			set;
		}

        [Column("PositionNameOrder")]
		public string PositionNameOrder
		{
			get;
			set;
		}

        [Column("CCAIEmpNo")]
		public string CCAIEmpNo
		{
			get;
			set;
		}

        [Column("CCAIDeptID")]
		public string CCAIDeptID
		{
			get;
			set;
		}

        [Column("CCAIDeptName")]
		public string CCAIDeptName
		{
			get;
			set;
		}

        [Column("CCAIRoleID")]
		public string CCAIRoleID
		{
			get;
			set;
		}

        [Column("CCAIRoleName")]
		public string CCAIRoleName
		{
			get;
			set;
		}

        [Column("CCAITitleName")]
		public string CCAITitleName
		{
			get;
			set;
		}

        [Column("CCAIDeptManager")]
		public string CCAIDeptManager
		{
			get;
			set;
		}

        [Column("CCAIIsCalculateAchievement")]
		public short? CCAIIsCalculateAchievement
		{
			get;
			set;
		}

        [Column("AgencyEmpID")]
		public string AgencyEmpID
		{
			get;
			set;
		}

        [Column("AgencyDeptID")]
		public string AgencyDeptID
		{
			get;
			set;
		}

        [Column("AgencyDeptName")]
		public string AgencyDeptName
		{
			get;
			set;
		}

        [Column("AgencyRoleID")]
		public string AgencyRoleID
		{
			get;
			set;
		}

        [Column("AgencyRoleName")]
		public string AgencyRoleName
		{
			get;
			set;
		}

        [Column("AgencyIsMoveProperty")]
		public bool? AgencyIsMoveProperty
		{
			get;
			set;
		}

        [Column("AgencyPropertyToDeptID")]
		public string AgencyPropertyToDeptID
		{
			get;
			set;
		}

        [Column("AgencyPropertyToEmptID")]
		public string AgencyPropertyToEmptID
		{
			get;
			set;
		}

        [Column("AgencyIsMoveInquiry")]
		public bool? AgencyIsMoveInquiry
		{
			get;
			set;
		}

        [Column("AgencyInquiryToDeptID")]
		public string AgencyInquiryToDeptID
		{
			get;
			set;
		}

        [Column("AgencyInquiryToEmptID")]
		public string AgencyInquiryToEmptID
		{
			get;
			set;
		}

        [Column("AttDeptID")]
		public string AttDeptID
		{
			get;
			set;
		}

        [Column("AttDeptName")]
		public string AttDeptName
		{
			get;
			set;
		}

        [Column("PositionID")]
		public string PositionID
		{
			get;
			set;
		}

        [Column("PositionName")]
		public string PositionName
		{
			get;
			set;
		}

        [Column("IsSpanArea")]
		public string IsSpanArea
		{
			get;
			set;
		}

        [Column("FirstLevel")]
		public string FirstLevel
		{
			get;
			set;
		}

        [Column("IsExportExcel")]
		public bool? IsExportExcel
		{
			get;
			set;
		}

        [Column("Delflag")]
		public short Delflag
		{
			get;
			set;
		}

        [Column("RedeployState")]
		public short RedeployState
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





