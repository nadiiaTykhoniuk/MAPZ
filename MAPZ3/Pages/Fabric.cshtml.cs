using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAPZ3.Pages
{
    abstract class AbstractFabricModel
    {
        public abstract WorkerUser MakeWorker();

        public abstract AdminUser MakeAdmin();

        public abstract ProjectManagerUser MakePM();
    }
    public class WorkerUser
    {
        public string Name()
        {
            return "I am worker";
        }
    }
    public class AdminUser
    {
        public string Name()
        {
            return "I am admin";
        }
    }
    public class ProjectManagerUser
    {
        public string Name()
        {
            return "I am PM";
        }
    }

    class
        MyOwnJira : AbstractFabricModel
    {
        public override WorkerUser MakeWorker()
        {
            return new WorkerUser();
        }
        public override AdminUser MakeAdmin()
        {
            return new AdminUser();
        }

        public override ProjectManagerUser MakePM()
        {
            return new ProjectManagerUser();
        }
    }

}
