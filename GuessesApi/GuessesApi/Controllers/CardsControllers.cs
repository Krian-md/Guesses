using GuessesApi.Database.Enteties;
using GuessesApi.Database.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessesApi.Controllers
{
    [ApiController]
    [Route("api/cards")]
    public class CardsControllers : ControllerBase
    {
        private readonly ILogger<CardsControllers> _logger;
        UnitOfWork uow;
        public CardsControllers(ILogger<CardsControllers> logger, UnitOfWork uow)
        {
            _logger = logger;
            this.uow = uow;
        }

        [HttpGet]
        [Route("cardsAll")]
        public IEnumerable<Card> GetAll()
        {
            return uow.CardsRepository.GetAllAsync().Result;
        }

        [HttpGet]
        [Route("card")]
        public Card Get(int id)
        {
            return uow.CardsRepository.GetAsync(id).Result;
        }
    }
}
