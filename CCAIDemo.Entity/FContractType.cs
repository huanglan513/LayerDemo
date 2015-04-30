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
	#region FContractType
	/// <summary>
	/// This object represents the properties and navigation list of a FContractType.
	/// </summary>
    [Serializable]
    [Table("F_ContractType")]
	public class FContractType
	{
		
		public FContractType()
		{
		}
        
        #region Public Properties
        
        [Column("ContractTypeID")]
		public Guid ContractTypeID
		{
			get;
			set;
		}

        [Column("ContractTypeName")]
		public string ContractTypeName
		{
			get;
			set;
		}

        [Column("AccessoryType")]
		public string AccessoryType
		{
			get;
			set;
		}

        [Column("HasAccessory")]
		public short HasAccessory
		{
			get;
			set;
		}

        [Column("IsReferContract")]
		public short IsReferContract
		{
			get;
			set;
		}

        [Column("IsNeedMng")]
		public short IsNeedMng
		{
			get;
			set;
		}

        [Column("HasNo")]
		public short HasNo
		{
			get;
			set;
		}

        [Column("HasTimeLimit")]
		public short HasTimeLimit
		{
			get;
			set;
		}

        [Column("Prefix")]
		public string Prefix
		{
			get;
			set;
		}

        [Column("FlowBitNum")]
		public short? FlowBitNum
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





