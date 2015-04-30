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
	#region CTOwnerShipPapersReceives
	/// <summary>
	/// This object represents the properties and navigation list of a CTOwnerShipPapersReceives.
	/// </summary>
    [Serializable]
    [Table("CT_OwnerShipPapersReceives")]
	public class CTOwnerShipPapersReceives
	{
		
		public CTOwnerShipPapersReceives()
		{
		}
        
        #region Public Properties
        
        [Column("ReceiveItemID")]
		public Guid ReceiveItemID
		{
			get;
			set;
		}

        [Column("ReceiveID")]
		public Guid ReceiveID
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





