using Microsoft.AspNetCore.Mvc;
using SwaggerUIBug.Enums;

namespace SwaggerUIBug.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase {
        [HttpGet]
        public EnumTest Get() {
            return EnumTest.EnumValue;
        }
    }
}