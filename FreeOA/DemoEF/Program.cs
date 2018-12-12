using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
    /// <summary>
    /// add by lpl
    /// 2018-12-12
    /// 框架之路
    /// EF学习Demo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            #region 增加数据

            ////1:初始化上下文
            //Free_OAEntities freeOaEntities = new Free_OAEntities();

            ////2：初始化实体
            //UserLogin userLogin = new UserLogin()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    Account = "admin2",
            //    CreateDate = DateTime.Now,
            //    CreateId = "李沛林",
            //    UpdateDate = DateTime.Now,
            //    UpdateId = "李沛林",
            //    RowStates = "1",
            //    IsLogin = "0",
            //    PassWord = "1"

            //};

            ////实体添加到上下文中，添加状态
            //freeOaEntities.UserLogin.Add(userLogin);

            ////保存实体
            //freeOaEntities.SaveChanges();

            //Console.ReadLine();

            #endregion


            #region 修改数据

            ////1:初始化上下文
            //Free_OAEntities freeOaEntities = new Free_OAEntities();

            ////2：初始化实体
            //UserLogin userLogin = new UserLogin()
            //{
            //    Id = "ddf69b2b-f691-4e34-8d6a-ba6d0b6b4997",
            //    Account = "admin",
            //    CreateDate = DateTime.Now,
            //    CreateId = "李沛林",
            //    UpdateDate = DateTime.Now,
            //    UpdateId = "李沛林",
            //    RowStates = "1",
            //    IsLogin = "0",
            //    PassWord = "1"

            //};



            ////实体添加到上下文中，更新状态,所有实体数据
            //freeOaEntities.Entry<UserLogin>(userLogin).State = EntityState.Modified;

            //////更新状态，把未更新的数据放到上下文
            ////freeOaEntities.UserLogin.Attach(userLogin);
            //////更新具体的某个数据，而不是整个实体
            ////freeOaEntities.Entry(userLogin).Property<string>(u => u.PassWord).IsModified = true;

            //////删除实体(基本不用，用假删除做)
            ////freeOaEntities.Entry(userLogin).State = EntityState.Deleted;



            ////保存实体
            //freeOaEntities.SaveChanges();

            //Console.ReadLine();

            #endregion


            #region 查询

            Free_OAEntities freeOaEntities  = new Free_OAEntities();


            //foreach (var user in freeOaEntities.UserLogin)
            //{
            //    Console.WriteLine("Account : " + user.Account + " |Pwd : " + user.PassWord);
               
            //}

            //协变，可以用Object类型，泛型把子类的值赋值给父类，类型安全
            IQueryable<UserLogin> temp = from u in freeOaEntities.UserLogin where u.Id == "dbd84b78-889f-43ad-9974-3fb1b11c3b38" select u;


            foreach (var user in temp)
            {
                Console.WriteLine("Account : " + user.Account + " |Pwd : " + user.PassWord);

            }



            Console.ReadLine();
            #endregion

        }
    }
}
