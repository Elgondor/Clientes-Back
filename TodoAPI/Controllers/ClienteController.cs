using Microsoft.AspNetCore.Mvc;
using TodoAPI.Contracts;
using TodoAPI.Interface;
using TodoAPI.Models;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServices _clienteServices;

        public ClienteController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }


        // Get all Todo Items
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var clientes = await _clienteServices.GetAllAsync();
                if (clientes == null || !clientes.Any())
                {
                    return Ok(new List<Cliente>()); // Return an empty list if no items found
                }
                return Ok(clientes); // Return the list of todos directly
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving all Todo items", error = ex.Message });
            }
        }


        // [HttpGet]
        // public async Task<IActionResult> GetAllAsync(int pageIndex = 1, int pageSize = 10)
        // {
        //     try
        //     {
        //         var clientes = await _clienteServices.GetAllAsync();
        //         if (clientes == null || !clientes.Any())
        //         {
        //             return Ok(new List<Cliente>()); // Return an empty list if no items found
        //         }
        //         return Ok(clientes); // Return the list of todos directly
        //     }
        //     catch (Exception ex)
        //     {
        //         return StatusCode(500, new { message = "An error occurred while retrieving all Todo items", error = ex.Message });
        //     }
        // }

    }
}
