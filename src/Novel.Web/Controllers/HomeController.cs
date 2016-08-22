using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using ILogger = Microsoft.Extensions.Logging.ILogger;
using Novel.Service.IService;
using Novel.Service.Model.Parameter;
using Novel.Web.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Novel.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        private readonly INovelService _novelService;

        public HomeController(ILoggerFactory loggerFactory,
            INovelService novelService)
        {
            _logger = loggerFactory.CreateLogger("Novel.Web");
            this._novelService = novelService;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _novelService.GetNovelList(new GetNovelListParameter());
            if (!result.State)
            {
                _logger.LogError(result.Messge);
            }
            ViewBag.Novels = result.Result.Select(u=>new NovelModel {
                Id=u.Id,
                Name=u.Name
            }).ToList();
            return View();
        }
    }
}
