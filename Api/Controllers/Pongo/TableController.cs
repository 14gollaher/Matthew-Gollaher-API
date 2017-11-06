using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pongo.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace Pongo
{
    [Route("Pongo")]
    public class TableController : Controller
    {
        private ITableRepository _tableRepository;

        public TableController(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        [HttpGet("Table")]
        public IActionResult GetTables()
        {
            List<Table> tables;
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                tables = _tableRepository.GetTables();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(tables);
        }

        [HttpGet("Table/{tableId}")]
        public IActionResult GetTable(int tableId)
        {
            Table table = new Table();
            try
            {
                table = _tableRepository.GetTable(tableId);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(table);
        }

        [HttpGet("Table/User/{userId}")]
        public IActionResult GetTablesByUser(int userId)
        {
            List<Table> tables;
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                tables = _tableRepository.GetTablesByUser(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(tables);
        }

        [HttpPost("Table")]
        public IActionResult InsertTable([FromBody] Table table)
        {
            try
            {
                _tableRepository.InsertTable(table);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(table);
        }
    }
}
