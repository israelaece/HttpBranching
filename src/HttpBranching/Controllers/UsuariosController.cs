using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HttpBranching.Controllers
{
    [Route("[controller]")]
    public class UsuariosController : Controller
    {
        public IEnumerable<string> Get() => new string[] { "command1", "command2" };
    }
}