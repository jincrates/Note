using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Note.BLL;
using Note.MVC6.Models;
using System.Diagnostics;

namespace Note.MVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserBll _userBll;  // 전역 변수에는 '_' 붙임

        /*
        의존성 주입(Dependency Injection)
        - 프로그래밍에서 구성요소 간의 의존 관계가 소스코드 내부가 아닌 외부의 설정파일 등을
        통해 정의되게 하는 디자인 패턴

        IoC(Inversion Of Control, 제어의 역행)
        - 프로그래머가 작성한 프로그램이 재사용 라이브러리의 흐름 제어를 받게 되는 소프트웨어 디자인 패턴

        IoC Container
        - 객체를 프레임워크에서 간접적으로 생성, 소멸시켜주는 컨테이너
         */

        public HomeController(UserBll userBll)
        {
            _userBll = userBll;
        }
      
        public IActionResult Index()
        {
            var user = _userBll.GetUser(1);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
