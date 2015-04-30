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
	#region CTOwnerShipPapers
	/// <summary>
	/// This object represents the properties and navigation list of a CTOwnerShipPapers.
	/// </summary>
    [Serializable]
    [Table("CT_OwnerShipPapers")]
	public class CTOwnerShipPapers
	{
		
		public CTOwnerShipPapers()
		{
		}
        
        #region Public Properties
        
        [Column("ReceiveID")]
		public Guid ReceiveID
		{
			get;
			set;
		}

        [Column("TransferID")]
		public Guid TransferID
		{
			get;
			set;
		}

        [Column("ReceiveDate")]
		public DateTime ReceiveDate
		{
			get;
			set;
		}

        [Column("DeptID")]
		public string DeptID
		{
			get;
			set;
		}

        [Column("ReceiveEmpID")]
		public string ReceiveEmpID
		{
			get;
			set;
		}

        [Column("Progress")]
		public string Progress
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





