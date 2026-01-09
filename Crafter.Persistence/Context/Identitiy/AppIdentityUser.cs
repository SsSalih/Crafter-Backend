using System;
using Microsoft.AspNetCore.Identity;

namespace CrafterApi.Crafter.Persistance.Context.Identitiy
{
	public class AppIdentityUser : IdentityUser
	{
		public string Name { get; set; }
		public string Surname { get; set; }

	}
}
