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
	#region FEstate
	/// <summary>
	/// This object represents the properties and navigation list of a FEstate.
	/// </summary>
    [Serializable]
    [Table("F_Estate")]
	public class FEstate
	{
		
		public FEstate()
		{
		}
        
        #region Public Properties
        
        [Column("EstateID")]
		public string EstateID
		{
			get;
			set;
		}

        [Column("EstateName")]
		public string EstateName
		{
			get;
			set;
		}

        [Column("EstateSpell")]
		public string EstateSpell
		{
			get;
			set;
		}

        [Column("Address2")]
		public string Address2
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





