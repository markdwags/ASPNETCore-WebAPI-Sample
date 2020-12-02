using System;
using System.Linq;
using AutoMapper;
using SampleWebApiAspNetCore.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SampleWebApiAspNetCore.Repositories;
using System.Collections.Generic;
using System.Net.Http;
using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Models;
using SampleWebApiAspNetCore.Helpers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SampleWebApiAspNetCore.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Route("api/[controller]")]
    public class DadJokeController : ControllerBase
    {
        private IHttpClientFactory _httpClientFactory;

        public DadJokeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public class Joke
        {
            public string id { get; set; }
            public string joke { get; set; }
            public int status { get; set; }
        }

        [HttpGet(Name = nameof(GetJoke))]
        public ActionResult GetJoke()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://icanhazdadjoke.com");
            request.Headers.Add("Accept", "application/json");

            Joke joke = new Joke();

            using (var response = httpClient.SendAsync(request))
            {
                response.Result.EnsureSuccessStatusCode();

                var content = response.Result.Content.ReadAsStringAsync();

                joke = JsonConvert.DeserializeObject<Joke>(content.Result);

                

            }

            return Ok(joke.joke);
        }

       
    }
}
