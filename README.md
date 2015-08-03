# LayerDemo
一个设计好的系统框架
Template文件夹下是模板文件，用于CodeSmith生成文件
主要是生成实体文件，与数据库的对应字段都标记上了，例如：
 
    [Serializable]
    [Table("F_Employee","EmpID")]  //表名，主键名
	  public class FEmployee
	  {
		
		public FEmployee()
		{
		}
        
        #region Public Properties
        
        [Column("EmpID")]
		public string EmpID
		{
			get;
			set;
		}

        [Column("Password")]
		public string Password
		{
			get;
			set;
		}

        [Column("EmpNo")]
		public string EmpNo
		{
			get;
			set;
		}
		}
数据访问层的可以不生成每张表的对应的数据访问类，有点累赘，业务层也是类似，不用生成与表对应的业务层。
数据访问层可以这样访问：BaseDataAccess<Employee> empBDA=new BaseDataAccess<Employee>();
这样就可以访问到所有的实体类对应的数据访问的增删改查。
这些增删改查的SQL是通过反射实体类对应的列来实现的。必须保证每张表都有主键，否则会出错
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
使用事务时，请用：SqlHelper.ExecTran(new string[] sqlArr); 
先组织SQLArr出来，然后一并执行，一般使用事务的都是修改的动作
如果只是单一的保存，不牵涉多个保存，可以这样：
        
        BaseDataAccess<FEmployee> employeeDA = new BaseDataAccess<FEmployee>();
        FEmployee employee = new FEmployee();
        employee.EmpID = empID;
        employee.EmpName = "王小小";
        employee.EmpNo = empNo;
         ........
        employeeDA.SaveEntity(employee);
   
   
   业务层可以这样用BaseMgr<FEmployee> employeeMgr=new BaseMgr<FEmployee>();
