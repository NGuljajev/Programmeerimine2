﻿using System.ComponentModel;

using KooliProjekt.Data;

using KooliProjekt.Services;

using Microsoft.AspNetCore.Mvc;


namespace KooliProjekt.Controllers

{

    [Route("api/Visits")]

    [ApiController]

    public class VisitsApiController : ControllerBase

    {

        private readonly IVisitService _service;

        public VisitsApiController(IVisitService service)

        {

            _service = service;

        }

        // GET: api/<VisitsApiController>

        [HttpGet]

        public async Task<IEnumerable<Visit>> Get()

        {

            var result = await _service.List(1, 10000);

            return result.Results;

        }

        // GET api/<VisitsApiController>/5

        [HttpGet("{id}")]

        public async Task<object> Get(int id)

        {

            var list = await _service.Get(id);

            if (list == null)

            {

                return NotFound();

            }

            return list;

        }

        // POST api/<VisitsApiController>

        [HttpPost]

        public async Task<object> Post([FromBody] Visit list)

        {

            await _service.Save(list);

            return Ok(list);

        }

        // PUT api/<VisitsApiController>/5

        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, [FromBody] Visit list)

        {

            if (id != list.Id)

            {

                return BadRequest();

            }

            await _service.Save(list);

            return Ok();

        }

        // DELETE api/<VisitsApiController>/5

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)

        {

            var list = await _service.Get(id);

            if (list == null)

            {

                return NotFound();

            }

            await _service.Delete(id);

            return Ok();

        }

    }

}

