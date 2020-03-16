using MvcApplication5.Models;
using System.Web.Mvc;

namespace MvcApplication5.Controllers
{
    public class HomeController : Controller
    {
        // 1. 跳转到视图
        public ActionResult Index(int? id)
        {
            // 在"View"上按Ctrl+Click
            // 会跳转到Index.cshtml, 或者View方法的定义
            if (id == null)
                return View();

            // 在字符串型参数上按Ctrl+Click
            return View("Index");
        }

        // 2. 从使用中创建视图
        public ActionResult Details(int? id)
        {
            // 下面的View标记为错误, 但是代码是可以编译
            // 使用Ctrl+Click会直接跳转到View方法
            // 按Alt+Enter, 可以选择
            // "Create Razor views"来创建.cshtml文件,
            // "Create ASPX views"来创建.aspx文件,
            // "Create view 'Details' with VS"使用VS向导来创建视图
            if (id == null)
                return View();

            // 下面的View标记为错误, 但是代码是可以编译
            // 使用Ctrl+Click会直接跳转到View方法
            // 在参数上按Alt+Enter, 可以如之前一般创建视图
            return View("MoreDetails");
        }

        // 3. 视图的代码补全
        public ActionResult DoThing()
        {
            // 将光标放在下面的字符串内, 执行Code Completion
            return View("");
        }

        // 3. RedirectToAction的代码补全
        [HttpPost]
        public ActionResult Create(SampleModel model)
        {
            // a. 将光标放在actionName字符串内, 执行Code Completion
            //    会建议当前控制器的行为
            if (model == null)
            {
                // b. 对着RedirectToAction方法按Ctrl+Click
                //    会转向方法或者控制器
                return RedirectToAction(actionName: "");
            }

            // c. 将光标放在actionName字符串内, 执行Code Completion, 没有建议显示
            //    将光标放在controllerName字符串内, 执行Code Completion, 会建议控制器
            //    再次执行第一步操作, 这次会建议选择的控制器的行为
            return RedirectToAction(actionName: "", controllerName: "");

            // d. 导航至行为或者控制器
            //    在相应文本上按Ctrl+Click
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
