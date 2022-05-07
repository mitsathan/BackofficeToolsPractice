using Api.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		// GET: api/<ValuesController>
		[HttpGet]
		public IEnumerable<string> GetAll()
		{
			return new[] { "value1", "value2" };
		}

		// GET api/<ValuesController>/5
		[HttpGet]
		[Route("{id}")]
		public string GetById(int id)
		{
			return "value";
		}

		// POST api/<ValuesController>
		[HttpPost]
		[Route("create")]
		public void Create([FromBody] Account account)
		{
			//todo: persist account
			throw new NotImplementedException();
		}

		// POST api/<ValuesController>
		[HttpPost]
		[Route("create-random")]
		public void CreateRandom()
		{
			//todo: use https://randomuser.me/api to create new account
			throw new NotImplementedException();
		}

		// PUT api/<ValuesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
			throw new NotImplementedException();
		}

		// DELETE api/<ValuesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
