using C_Sharp_Board.Service;
using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Board.Controller
{

    [ApiController]
    [Route("api/v1/users")]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;
        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }
        /**
		  * 1.  IActionResult: 한 작업에 여가의 ActionResult반환이 가능 할 때 반환 값으로 적당하다. (HttpStatusCode와 함께 리턴이 가능하다).
		  * 2.  ActionResult<T>: IActionResult와 유사하나 명시적인 타입캐스팅 효과를 얻을 수 있다. (C#은 인터페이스에 대한 암시적 타입 캐스팅을 지원하지 않는다.)
		  * 3.  IEnumerable: Collection타입에 대한 반환을 할 때 사용하는 인터페이스이다. (List로 전달 해도 되지만 OCP의 구현 철학 때문이다.)
		  */
        [HttpPost("sign-in")]
        public IActionResult SignIn()
        {
            _logger.Log(LogLevel.Information, this.GetHashCode().ToString());
            _logger.Log(LogLevel.Information, _userService.GetHashCode().ToString());
            return Ok();
        }

        [HttpPost("sign-up")]
        public IActionResult SignUp()
        {
            var userId = 1;
            return Created(new Uri($"/users/{userId}"), null);
        }

        [HttpGet("{userId}")]
        public IActionResult GetUserInfo(int userId)
        {
            return Ok(_userService.FindUser(userId));
        }

    }
}