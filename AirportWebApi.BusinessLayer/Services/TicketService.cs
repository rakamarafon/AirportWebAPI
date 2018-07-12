using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportWebAPI.BusinessLayer.Services
{
    public class TicketService : IService<Ticket>
    {
        private readonly IRepository<TicketModel> repository;
        private readonly IMapper mapper;

        public TicketService(IRepository<TicketModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Ticket AddEntry(Ticket entity)
        {
            var temp = repository.AddEntry(mapper.Map<Ticket, TicketModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<TicketModel, Ticket>(temp);
            }
        }

        public List<Ticket> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<TicketModel, Ticket>).ToList();
        }

        public Ticket GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<TicketModel, Ticket>(temp);
        }

        public Ticket RemoveEntry(int id)
        {
            return mapper.Map<TicketModel, Ticket>(repository.RemoveEntity(id));
        }

        public Ticket UpdateEntry(Ticket entity)
        {
            var temp = repository.UpdateEntity(mapper.Map<Ticket, TicketModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<TicketModel, Ticket>(temp);
            }
        }
    }
}
