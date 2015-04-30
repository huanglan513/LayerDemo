/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:46
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGPropertyType
	/// <summary>
	/// This object represents the properties and navigation list of a CFGPropertyType.
	/// </summary>
    [Serializable]
    [Table("CFG_PropertyType",PrimaryKeyColumn="ItemID")]
	public class CFGPropertyType
	{
		
		public CFGPropertyType()
		{
		}
        
        #region Public Properties
         
        [Column("ItemID")]
		public string ItemID
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

        [Column("PropertyValue")]
		public short PropertyValue
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





