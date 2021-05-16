using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAPZ3.Pages
{
    public class SingletonProgram : PageModel
    {
        private static readonly SingletonProgram instance = new SingletonProgram();
        public static string text = "Singleton Program Created";
        public string Date { get; private set; }

        private readonly ILogger<SingletonProgram> _logger;

        public SingletonProgram(ILogger<SingletonProgram> logger)
        {
            _logger = logger;
            Date = System.DateTime.Now.TimeOfDay.ToString();
        }

        private SingletonProgram()
        { 
            
        }

        public static SingletonProgram GetInstance()
        {
            return instance;
        }

        public static string getWorker()
        {
            var jira = new MyOwnJira();
            return jira.MakeWorker().Name();
        }

        public static string getAdmin()
        {
            var jira = new MyOwnJira();
            return jira.MakeAdmin().Name();
        }

        public static string getProjectManager()
        {
            var jira = new MyOwnJira();
            return jira.MakePM().Name();
        }

        public void OnGet()
        {
            ViewData["singleton"] = SingletonProgram.text;
            ViewData["timecreated"] = System.DateTime.Now.TimeOfDay.ToString();
            ViewData["workerUser"] = SingletonProgram.getWorker();
            ViewData["workerAdmin"] = SingletonProgram.getAdmin();
            ViewData["workerPM"] = SingletonProgram.getProjectManager();
        }
    }
}
