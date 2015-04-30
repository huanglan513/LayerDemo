/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:49
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region FProperty
	/// <summary>
	/// This object represents the properties and navigation list of a FProperty.
	/// </summary>
    [Serializable]
    [Table("F_Property",PrimaryKeyColumn="PropertyID")]
	public class FProperty
	{
		
		public FProperty()
		{
		}
        
        #region Public Properties
         
        [Column("PropertyID")]
		public string PropertyID
		{
			get;
            set;
		}
        
        [Column("PropertyNo")]
		public string PropertyNo
		{
			get;
			set;
		}

        [Column("DistrictName")]
		public string DistrictName
		{
			get;
			set;
		}

        [Column("AreaID")]
		public string AreaID
		{
			get;
			set;
		}

        [Column("AreaName")]
		public string AreaName
		{
			get;
			set;
		}

        [Column("EstateID")]
		public string EstateID
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

        [Column("RoomNo")]
		public string RoomNo
		{
			get;
			set;
		}

        [Column("Floor")]
		public string Floor
		{
			get;
			set;
		}

        [Column("FloorAll")]
		public int? FloorAll
		{
			get;
			set;
		}

        [Column("CountF")]
		public string CountF
		{
			get;
			set;
		}

        [Column("CountT")]
		public int? CountT
		{
			get;
			set;
		}

        [Column("CountW")]
		public int? CountW
		{
			get;
			set;
		}

        [Column("CountY")]
		public int? CountY
		{
			get;
			set;
		}

        [Column("Square")]
		public double? Square
		{
			get;
			set;
		}

        [Column("SquareUse")]
		public double? SquareUse
		{
			get;
			set;
		}

        [Column("RentPrice")]
		public decimal? RentPrice
		{
			get;
			set;
		}

        [Column("RentPriceUnit")]
		public decimal? RentPriceUnit
		{
			get;
			set;
		}

        [Column("RentUnitName")]
		public string RentUnitName
		{
			get;
			set;
		}

        [Column("RentPriceLine")]
		public decimal? RentPriceLine
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

        [Column("PriceUnit")]
		public decimal? PriceUnit
		{
			get;
			set;
		}

        [Column("UnitName")]
		public string UnitName
		{
			get;
			set;
		}

        [Column("PriceLine")]
		public decimal? PriceLine
		{
			get;
			set;
		}

        [Column("PropertyUsage")]
		public string PropertyUsage
		{
			get;
			set;
		}

        [Column("PropertyType")]
		public string PropertyType
		{
			get;
			set;
		}

        [Column("PropertyDirection")]
		public string PropertyDirection
		{
			get;
			set;
		}

        [Column("PropertyBuy")]
		public string PropertyBuy
		{
			get;
			set;
		}

        [Column("PropertyCommission")]
		public string PropertyCommission
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

        [Column("PropertyDecoration")]
		public string PropertyDecoration
		{
			get;
			set;
		}

        [Column("PropertyFloor")]
		public string PropertyFloor
		{
			get;
			set;
		}

        [Column("PropertyTrust")]
		public string PropertyTrust
		{
			get;
			set;
		}

        [Column("PropertyOccupy")]
		public string PropertyOccupy
		{
			get;
			set;
		}

        [Column("PropertyOwn")]
		public string PropertyOwn
		{
			get;
			set;
		}

        [Column("PropertyFurniture")]
		public string PropertyFurniture
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

        [Column("DeptName")]
		public string DeptName
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

        [Column("EmpNo")]
		public string EmpNo
		{
			get;
			set;
		}

        [Column("EmpName")]
		public string EmpName
		{
			get;
			set;
		}

        [Column("HaveResidual")]
		public decimal? HaveResidual
		{
			get;
			set;
		}

        [Column("CompleteYear")]
		public short? CompleteYear
		{
			get;
			set;
		}

        [Column("DecorationYear")]
		public short? DecorationYear
		{
			get;
			set;
		}

        [Column("PropertyRightNo")]
		public string PropertyRightNo
		{
			get;
			set;
		}

        [Column("PropertyRightDate")]
		public DateTime? PropertyRightDate
		{
			get;
			set;
		}

        [Column("CountJGT")]
		public short? CountJGT
		{
			get;
			set;
		}

        [Column("CountJGF")]
		public short? CountJGF
		{
			get;
			set;
		}

        [Column("RoomEquipment")]
		public string RoomEquipment
		{
			get;
			set;
		}

        [Column("IsCoLease")]
		public short? IsCoLease
		{
			get;
			set;
		}

        [Column("Elevators")]
		public short? Elevators
		{
			get;
			set;
		}

        [Column("UnitsForFloor")]
		public short? UnitsForFloor
		{
			get;
			set;
		}

        [Column("HowQuietly")]
		public string HowQuietly
		{
			get;
			set;
		}

        [Column("AgencyPropertyID")]
		public string AgencyPropertyID
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

        [Column("CertPropertyAddr")]
		public string CertPropertyAddr
		{
			get;
			set;
		}

        [Column("ProDirection")]
		public string ProDirection
		{
			get;
			set;
		}

        [Column("CityCircle")]
		public string CityCircle
		{
			get;
			set;
		}

        [Column("SpaceType")]
		public string SpaceType
		{
			get;
			set;
		}

        [Column("LandScape")]
		public string LandScape
		{
			get;
			set;
		}

        [Column("PropertyCharacter")]
		public string PropertyCharacter
		{
			get;
			set;
		}

        [Column("PropertyFee")]
		public decimal PropertyFee
		{
			get;
			set;
		}

        [Column("Street")]
		public string Street
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





