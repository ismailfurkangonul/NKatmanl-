using BLL;
using Microsoft.AspNetCore.Mvc;
using MODEL;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public void Add(User user)
        {
            UserOp userOp =new UserOp();
            userOp.UserAdd(user);



        }
        [HttpPost]
        public void Update(User user)
        {
            UserOp userOp = new UserOp();
            userOp.UserAdd(user);



        }

    };
 }
