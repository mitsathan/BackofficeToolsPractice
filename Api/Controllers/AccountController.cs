using Api.DB;
using Api.Dto;
using Api.Practices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private BOContext _boContext;

		// GET: api/<ValuesController>
		public AccountController()
		{
			_boContext = new BOContext();
		}

		[HttpGet]
		public IEnumerable<string> GetAll()
		{
			return new[] { "value1", "value2" };
		}

		// GET api/<ValuesController>/5
		[HttpGet]
		[Route("{id}")]
		public Account GetById(int id)
		{
			try
			{
				return _boContext.Accounts
					.Include(x=>x.Pet)
					.First(x => x.Id == id);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return new Account();
			}
		}

		// POST api/<ValuesController>
		[HttpPost]
		[Route("create")]
		public void Create([FromBody] Account account)
		{
			//todo: hide Ids from request
			try
			{
				_boContext.Add(account);
				_boContext.SaveChanges();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
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
