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
    public class CellController : Controller
    {
        private ICellRepository _cellRepository;

        public CellController(ICellRepository cellRepository)
        {
            _cellRepository = cellRepository;
        }

        [HttpGet("Cell")]
        public IActionResult GetCells()
        {
            List<Cell> cells;
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                cells = _cellRepository.GetCells();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(cells);
        }

        [HttpGet("Cell/{cellId}")]
        public IActionResult GetCell(int cellId)
        {
            Cell cell = new Cell();
            try
            {
                cell = _cellRepository.GetCell(cellId);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(cell);
        }

        [HttpGet("Column/Cell/{cellId}")]
        public IActionResult GetCellsByColumn(int columnId)
        {
            List<Cell> cells;
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                cells = _cellRepository.GetCellsByColumn(columnId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(cells);
        }

        [HttpPost("Cell")]
        public IActionResult InsertCell([FromBody] Cell cell)
        {
            try
            {
                _cellRepository.InsertCell(cell);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(cell);
        }
    }
}
