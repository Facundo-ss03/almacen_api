using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using almacen_api.Models;

namespace almacen_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        [Route("GetClient")]
        public Client GetClient()
        {

            Client client = new Client
            {
                Id = 1,
                Name = "Lionel",
                LastName = "Messi"

            };

            return client;
        }
    }
}
