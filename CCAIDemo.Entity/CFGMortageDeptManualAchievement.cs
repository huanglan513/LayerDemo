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
	#region CFGMortageDeptManualAchievement
	/// <summary>
	/// This object represents the properties and navigation list of a CFGMortageDeptManualAchievement.
	/// </summary>
    [Serializable]
    [Table("CFG_MortageDeptManualAchievement")]
	public class CFGMortageDeptManualAchievement
	{
		
		public CFGMortageDeptManualAchievement()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("ReportDate")]
		public DateTime ReportDate
		{
			get;
			set;
		}

        [Column("SalesNo")]
		public decimal SalesNo
		{
			get;
			set;
		}

        [Column("SalesAchievement")]
		public decimal SalesAchievement
		{
			get;
			set;
		}

        [Column("ModDate")]
		public DateTime? ModDate
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





