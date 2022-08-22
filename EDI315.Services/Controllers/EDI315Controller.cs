using EDI.Entities.Entities;
using EDI315.Contracts.Repository;
using EDI315.Core.V1;
using EDI315.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EDI315.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EDI315Controller : ControllerBase
    {

        private readonly EDICore _ediCore;

        public EDI315Controller(IEDI315Repository context, ILogger<EDIX12_315> logger)
        {
            _ediCore = new EDICore(context, logger);
        }

        // GET: api/<EDI315Controller>
        [HttpGet]
        [ActionName("GetAll")]
        public async Task<ActionResult<List<ItemContainer>>> Get()
        {
            var response = await _ediCore.GetAllContainers();
            return response;
        }

        // GET api/<EDI315Controller>/5
        [HttpGet("{id}")]
        [ActionName("GetContainer")]
        public async Task<ActionResult<List<ItemContainer>>> GetById(string id)
        {
            var response = await _ediCore.GetContainerById(id);
            return StatusCode((int)response.StatusHttp, response);
        }

        // POST api/<EDIController>
        [HttpPost]
        [ActionName("PostContainer")]
        public async Task<ActionResult<Tuple<List<ItemContainer>, bool>>> Post()
        {
            var response = await _ediCore.PostContainers();
            return StatusCode((int)response.StatusHttp, response);
        }

        // PUT api/<EDIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
