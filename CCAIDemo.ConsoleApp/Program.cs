using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;
using System.Data.SqlClient;
using CCAIDemo.Utility;
using CCAIDemo.BusinessLogic;
using System.Text.RegularExpressions;


namespace CCAIDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sql = "seLect id,name fRom table where id=3";
            //Regex regexFrom = new Regex("From", RegexOptions.IgnoreCase);
            //sql = regexFrom.Replace(sql, "from");
            //string sqlCount = "select count(1) " + sql.Substring(sql.IndexOf("from"));

            //Console.WriteLine(sqlCount);

            //GetEntityByPrimaryKey<Function>("1");
            //GetEntityByPrimaryKey<Function>("25");

        //    Function fun = new Function();
            //  fun.FunctionID = 46;
        //    fun.FunctionName = "abcd";
         //   fun.ParentID = 0;

            PageHelper pageHelper = new PageHelper();

       //     using (Trans tran = new Trans())
       //     {
         //       try
        //        {
                    //    SaveEntity<Function>(fun,tran);
                    //    int a = int.Parse("anc");
                    //    SaveEntity<Function>(fun,tran);

                    //BaseDataAccess<Function> da = new BaseDataAccess<Function>();
                    //IList<Function> funList=da.GetEntitiesByQueryConditionPaged(pageHelper, string.Empty,string.Empty,tran);
                    //if (pageHelper.RecordCount.HasValue)
                    //{
                    //    Console.WriteLine(pageHelper.RecordCount + "总记录");
                    //}

                    //  da.GetEntityByPrimaryKey("26",tran);
                    //  DeleteEntityByQueryCondition<Function>("FunctionID in (55,56)", tran);
         //           tran.Commit();
        //        }
        //        catch (Exception ex)
        //        {
        //            tran.RollBack();
         //           Console.WriteLine(ex.StackTrace);
          //      }
          //  }
            //   CTContractBll bll = new CTContractBll();

            //BaseDataAccess<Function> da = new BaseDataAccess<Function>();
            //IList<Function> funList = da.GetEntitiesByQueryConditionPaged( pageHelper,"FunctionID in (2,7)", "FunctionName Desc");
            //if (pageHelper.RecordCount.HasValue)
            //{
            //    Console.WriteLine(pageHelper.RecordCount + "总记录");
            //}

            //  SaveEntity<Function>(fun);
            //  DeleteEntity<Function>(fun);
            //  SaveEntity<Function>(fun);
            //    BaseDataAccess da = new BaseDataAccess();
            //da.GetEntityByPrimaryKey<Function>("26");
            //  Console.WriteLine(da.SaveEntity<Function>(fun));

            SaveData();
            Console.ReadKey();
        }

        private static void SaveData()
        {
            BaseDataAccess<FEmployee> employeeDA = new BaseDataAccess<FEmployee>();
            BaseDataAccess<FEmpWorkInfo> empWorlInfoDA = new BaseDataAccess<FEmpWorkInfo>();

            string empID="697fb4a2-b640-4b10-969d-db12eea16941";
            string empNo="p666";
            string deptID = "3AAC6598-7ECD-479D-9D12-50A8B52536E5";
            string roleID="C374D319-EA6D-411D-8546-14EE9072AA08";
            Guid workInfoID = Guid.NewGuid();
            FEmpWorkInfo empWorkInfo = new FEmpWorkInfo();
            empWorkInfo.WorkInfoID = workInfoID.ToString();
            empWorkInfo.EmpID = empID;
            empWorkInfo.EmpNo = empNo;
            empWorkInfo.RoleID=roleID;
            empWorkInfo.BeginDate = DateTime.Today;
            empWorkInfo.DeptID = deptID;
            empWorkInfo.IsOnDuty = 1;
            empWorkInfo.IsPluralist = 0;
            empWorkInfo.ModDate = DateTime.Now;

            FEmployee employee = new FEmployee();
            employee.EmpID = empID;
            employee.EmpName = "王小小";
            employee.EmpNo = empNo;
            employee.EmployeeDate = DateTime.Today;
            employee.DeptID = deptID;
            employee.RoleID = roleID;
            employee.Job = "跑盘人员";
            employee.ADUserID = empNo;
            employee.Email = empNo + "@centaline.com.cn";
            employee.DelFlag = 0;
            employee.UpdateTime = DateTime.Now;
            employee.Sex = "女";
            employee.IDCardNo = "432601198506123215";
            employee.IdentityCardNO = employee.IDCardNo;
            employee.MainWorkInfoID = workInfoID;
           

            String sql1 = employeeDA.GetSaveEntitySQL(employee);
            String sql2 = empWorlInfoDA.GetSaveEntitySQL(empWorkInfo);

            int a=SqlHelper.ExecTran(new string[] { sql1, sql2 });
            gConsole.WriteLine(a);

        }

    }
}
