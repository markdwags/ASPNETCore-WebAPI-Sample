using System;
using System.Linq;
using AutoMapper;
using SampleWebApiAspNetCore.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SampleWebApiAspNetCore.Repositories;
using System.Collections.Generic;
using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Models;
using SampleWebApiAspNetCore.Helpers;
using System.Text.Json;

namespace SampleWebApiAspNetCore.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Route("api/[controller]")]
    public class PlaygroundsController : ControllerBase
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IUrlHelper _urlHelper;
        private readonly IMapper _mapper;
        private readonly IPlayground _dataAccessProvider;

        public PlaygroundsController(
            IUrlHelper urlHelper,
            IFoodRepository foodRepository,
            IMapper mapper,
            IPlayground provider)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
            _urlHelper = urlHelper;
            _dataAccessProvider = provider;
        }

        [HttpGet(Name = nameof(Get))]
        public IEnumerable<Playground> Get()
        {
            return _dataAccessProvider.GetPlaygroundRecords();
        }

       
    }
}
