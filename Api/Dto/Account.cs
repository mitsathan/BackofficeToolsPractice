﻿using Api.Dto;
using Api.Practices;

namespace Api.Dto
{
    public class Account : IAccount
    {
        public long Id { get; set; }
        public string Firstname { get; set; } = default!;
        public string Lastname { get; set; } = default!;
		public string Email { get; set; } = default!;
		public Pet Pet { get; set; } = default!;

		public string GetAccount()
		{
			return Firstname;
		}
	}

    public class Pet
    {
        public long Id { get; set; }
	    public string Race { get; set; } = default!;
		public string Name { get; set; } = default!;
		public string Sex { get; set; } = default!;
	}

	public static class AccountSearch
	{
	    public static Account GetById(this List<Account> customers, int id)
	    {
		    return customers.First(x => x.Id == id);
	    }

	    public static Account GetByFirstName(this List<Account> customers, string firstName)
	    {
		    return customers.First(x => x.Firstname == firstName);
	    }
	}
}
