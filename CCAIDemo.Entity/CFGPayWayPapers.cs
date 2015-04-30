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
	#region CFGPayWayPapers
	/// <summary>
	/// This object represents the properties and navigation list of a CFGPayWayPapers.
	/// </summary>
    [Serializable]
    [Table("CFG_PayWayPapers")]
	public class CFGPayWayPapers
	{
		
		public CFGPayWayPapers()
		{
		}
        
        #region Public Properties
        
        [Column("CFGID")]
		public Guid CFGID
		{
			get;
			set;
		}

        [Column("PayWay")]
		public string PayWay
		{
			get;
			set;
		}

        [Column("CustomerType")]
		public short CustomerType
		{
			get;
			set;
		}

        [Column("PropertyPaper")]
		public string PropertyPaper
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





