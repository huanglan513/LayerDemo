/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2012/6/11 17:20:47
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
	#region CFGUniversalDictionary
	/// <summary>
	/// This object represents the properties and navigation list of a CFGUniversalDictionary.
	/// </summary>
    [Serializable]
    [Table("CFG_UniversalDictionary")]
	public class CFGUniversalDictionary
	{
		
		public CFGUniversalDictionary()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("CodeType")]
		public string CodeType
		{
			get;
			set;
		}

        [Column("CodeValue")]
		public string CodeValue
		{
			get;
			set;
		}

        [Column("Sequence")]
		public int Sequence
		{
			get;
			set;
		}

        [Column("CodeScope")]
		public string CodeScope
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




