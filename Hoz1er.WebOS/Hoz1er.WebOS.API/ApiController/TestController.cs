using Hoz1er.WebOS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hoz1er.WebOS.API.ApiController
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private Hoz1erDBContext _dbContext;
        public TestController(Hoz1erDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("count")]
        public int Count()
        {
            var r = (from u in _dbContext.User
                     select u.ID).Count();
            return r;
        }
        [Route("startup")]
        public string Startup()
        {
            return "start success";
        }
    }
}
