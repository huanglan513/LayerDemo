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
	#region CTOwnerShipProcess
	/// <summary>
	/// This object represents the properties and navigation list of a CTOwnerShipProcess.
	/// </summary>
    [Serializable]
    [Table("CT_OwnerShipProcess")]
	public class CTOwnerShipProcess
	{
		
		public CTOwnerShipProcess()
		{
		}
        
        #region Public Properties
        
        [Column("ProcessID")]
		public string ProcessID
		{
			get;
			set;
		}

        [Column("TransferID")]
		public string TransferID
		{
			get;
			set;
		}

        [Column("State")]
		public string State
		{
			get;
			set;
		}

        [Column("Order")]
		public short Order
		{
			get;
			set;
		}

        [Column("ProcessDate")]
		public DateTime ProcessDate
		{
			get;
			set;
		}

        [Column("EmpID")]
		public string EmpID
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

        [Column("Progress")]
		public string Progress
		{
			get;
			set;
		}

        [Column("ModDate")]
		public DateTime ModDate
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





