using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCAIDemo.Entity
{
    #region Function
    /// <summary>
    /// This object represents the properties and navigation list of a Function.
    /// </summary>
    [Table("Function",PrimaryKeyColumn="FunctionID")]
    public class Function
    {

        public Function()
        {
        }

        #region Public Properties
        [Column("FunctionID",IsIndentity=true)]
        public int FunctionID
        {
            get;
            set;
        }
        [Column("FunctionName")]
        public string FunctionName
        {
            get;
            set;
        }

        [Column("ParentID")]
        public int ParentID
        {
            get;
            set;
        }
         [Column("Url")]
        public string Url
        {
            get;
            set;
        }
        #endregion


    }
    #endregion
}

