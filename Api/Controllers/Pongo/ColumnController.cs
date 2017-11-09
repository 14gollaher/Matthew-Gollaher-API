using Microsoft.AspNetCore.Mvc;
using Pongo.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace Pongo
{
    [Route("Pongo")]
    public class ColumnController : Controller
    {
        private IColumnRepository _columnRepository;

        public ColumnController(IColumnRepository columnRepository)
        {
            _columnRepository = columnRepository;
        }

        [HttpGet("Column")]
        public IActionResult GetColumns()
        {
            List<Column> columns;
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                columns = _columnRepository.GetColumns();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(columns);
        }

        [HttpGet("Column/{columnId}")]
        public IActionResult GetColumn(int columnId)
        {
            Column column = new Column();
            try
            {
                column = _columnRepository.GetColumn(columnId);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(column);
        }

        [HttpGet("Table/{tableId}/Column")]
        public IActionResult GetColumnsByTable(int tableId)
        {
            List<Column> columns;
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                columns = _columnRepository.GetColumnsByTable(tableId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(columns);
        }

        [HttpPost("Column")]
        public IActionResult InsertColumn([FromBody] Column column)
        {
            try
            {
                _columnRepository.InsertColumn(column);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(column);
        }
    }
}
