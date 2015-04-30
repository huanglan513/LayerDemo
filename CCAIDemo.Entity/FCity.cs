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
	#region FCity
	/// <summary>
	/// This object represents the properties and navigation list of a FCity.
	/// </summary>
    [Serializable]
    [Table("F_City")]
	public class FCity
	{
		
		public FCity()
		{
		}
        
        #region Public Properties
        
        [Column("CityName")]
		public string CityName
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





