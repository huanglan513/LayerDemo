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
	#region FArea
	/// <summary>
	/// This object represents the properties and navigation list of a FArea.
	/// </summary>
    [Serializable]
    [Table("F_Area")]
	public class FArea
	{
		
		public FArea()
		{
		}
        
        #region Public Properties
        
        [Column("AreaID")]
		public string AreaID
		{
			get;
			set;
		}

        [Column("AreaNo")]
		public string AreaNo
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

        [Column("DistrictName")]
		public string DistrictName
		{
			get;
			set;
		}

        [Column("CityName")]
		public string CityName
		{
			get;
			set;
		}

        [Column("DelFlag")]
		public short DelFlag
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





