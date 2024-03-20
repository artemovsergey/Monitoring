using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monitoring.API.Models;
using System;

namespace Monitoring.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
	private readonly UserContext _db;
	public UsersController(UserContext db)
    {
		_db = db;
	}

    [HttpGet]
	public async Task<ActionResult<IEnumerable<User>>> GetUsers()
	{


		var randomUsers = new List<User>()
		{
			new User(){ Id = 1,
						LastSecurityPointDirection = "in",
						PersonRole = "user",
						LastSecurityPointNumber = new Random().Next(1, 4),
                        LastSecurityPointTime = DateTime.Now,
						PersonCode = "1"
			},

            new User(){ Id = 2,
						LastSecurityPointDirection = "in",
                        PersonRole = "employee",
                        LastSecurityPointNumber = new Random().Next(1, 4),
						LastSecurityPointTime = DateTime.Now,
						PersonCode = "1"
            },

            new User(){ Id = 3,
                        LastSecurityPointDirection = "in",
                        PersonRole = "employee",
                        LastSecurityPointNumber = new Random().Next(1, 4),
                        LastSecurityPointTime = DateTime.Now,
                        PersonCode = "1"
            }


        };


		return randomUsers;

		//return await _db.Users.ToListAsync();
	}

}
