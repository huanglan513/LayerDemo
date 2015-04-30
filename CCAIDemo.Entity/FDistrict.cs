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
	#region FDistrict
	/// <summary>
	/// This object represents the properties and navigation list of a FDistrict.
	/// </summary>
    [Serializable]
    [Table("F_District")]
	public class FDistrict
	{
		
		public FDistrict()
		{
		}
        
        #region Public Properties
        
        [Column("CityName")]
		public string CityName
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





