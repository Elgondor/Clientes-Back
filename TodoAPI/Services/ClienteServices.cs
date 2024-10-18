
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TodoAPI.AppDataContext;
using TodoAPI.Contracts;
using TodoAPI.Interface;
using TodoAPI.Models;

namespace TodoAPI.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly TodoDbContext _context;
        private readonly ILogger<ClienteServices> _logger;
        private readonly IMapper _mapper;

        public ClienteServices(TodoDbContext context, ILogger<ClienteServices> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }



        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var cliente = await _context.Clientes.ToListAsync();
            if (cliente == null)
            {
                throw new Exception(" No Todo items found");
            }
            return cliente;

        }

        // Task<IEnumerable<Cliente>> IClienteServices.GetAllAsync()
        // {
        //     throw new NotImplementedException();
        // }
    }
}