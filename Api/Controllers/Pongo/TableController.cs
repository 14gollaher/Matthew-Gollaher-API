using Microsoft.AspNetCore.Mvc;
using Pongo.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            IEnumerable<Table> tables;
            try
            {
                tables = _tableRepository.GetTables();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
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
