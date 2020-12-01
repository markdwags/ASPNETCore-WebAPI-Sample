using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebApiAspNetCore.Models;

namespace SampleWebApiAspNetCore.Entities
{
    public class PlaygroundProvider : IPlayground
    {
        private readonly PlaygroundContext _context;

        public PlaygroundProvider(PlaygroundContext context)
        {
            _context = context;
        }

        public List<Playground> GetPlaygroundRecords()
        {
            return _context.playground.ToList();
        }
    }
}
