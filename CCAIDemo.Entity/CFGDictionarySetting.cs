/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:45
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGDictionarySetting
	/// <summary>
	/// This object represents the properties and navigation list of a CFGDictionarySetting.
	/// </summary>
    [Serializable]
    [Table("CFG_DictionarySetting")]
	public class CFGDictionarySetting
	{
		
		public CFGDictionarySetting()
		{
		}
        
        #region Public Properties
        
        [Column("CodeType")]
		public string CodeType
		{
			get;
			set;
		}

        [Column("CodeName")]
		public string CodeName
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

        [Column("ParentCodeType")]
		public string ParentCodeType
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





