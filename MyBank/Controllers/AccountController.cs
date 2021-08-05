using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBank.DataAccess;
using MyBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountDataAccessProvider _dataAccessProvider;

        public AccountController(IAccountDataAccessProvider accessProvider)
        {
            _dataAccessProvider = accessProvider;
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _dataAccessProvider.getAllAccounts();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Account account)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.addAccount(account);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Account Details(int ID)
        {
            return _dataAccessProvider.getAccountByID(ID);
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Account account)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.updateAccount(account);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int ID)
        {
            var data = _dataAccessProvider.getAccountByID(ID);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.deleteAccount(ID);
            return Ok();
        }
    }
}

