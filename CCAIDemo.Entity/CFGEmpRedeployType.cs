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
	#region CFGEmpRedeployType
	/// <summary>
	/// This object represents the properties and navigation list of a CFGEmpRedeployType.
	/// </summary>
    [Serializable]
    [Table("CFG_Emp_RedeployType")]
	public class CFGEmpRedeployType
	{
		
		public CFGEmpRedeployType()
		{
		}
        
        #region Public Properties
        
        [Column("ItemID")]
		public string ItemID
		{
			get;
			set;
		}

        [Column("RedeployTypeID")]
		public int RedeployTypeID
		{
			get;
			set;
		}

        [Column("RedeployTypeName")]
		public string RedeployTypeName
		{
			get;
			set;
		}

        [Column("TypeLevel")]
		public short? TypeLevel
		{
			get;
			set;
		}

        [Column("ParentID")]
		public int? ParentID
		{
			get;
			set;
		}

        [Column("K3RedeployTypeName")]
		public string K3RedeployTypeName
		{
			get;
			set;
		}

        [Column("WFType")]
		public int? WFType
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





