using Api.Dto;

namespace Api.Practices
{
	public class User : IAccount
	{
		public long Id { get; set; }
		public string Firstname { get; set; } = default!;
		public string Lastname { get; set; } = default!;
		public string Email { get; set; } = default!;

		public string GetFullName()
		{
			return Firstname;
		}
	}

	public class Customer
	{
		public long Id { get; private set; }
		public string Firstname { get; private set; } = default!;
		public string Lastname { get; private set; } = default!;
		public string Email { get; private set; } = default!;

		private string Teststr { get; set; }
		
		public Customer(long id, string firstName, string lastName, string email)
		{
			Id = id;
			Firstname = firstName;
			Lastname = lastName;
			Email= email;
		}

		public string GetAccount()
		{
			return Firstname;
		}
	}

	public interface IAccount
	{
		string GetFullName();
	}

	public class Test
	{
		public Test()
		{
			var acc = new Account();
			var us = new User();
			var cu = new Customer(1, "f","l","e");

			TestAccount(acc);
			TestAccount(us);
			// TestAccount(cu);
		}
		
		public void TestAccount(IAccount account)
		{
			var s = account.GetFullName();
		}
	}
}
