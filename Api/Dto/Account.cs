using Api.Dto;
using Api.Practices;

namespace Api.Dto
{
    public class Account : IAccount
    {
        public long Id { get; set; }
        public string Firstname { get; set; } = default!;
        public string Lastname { get; set; } = default!;
		public string Email { get; set; } = default!;

		public string GetAccount()
		{
			return Firstname;
		}
	}
}
