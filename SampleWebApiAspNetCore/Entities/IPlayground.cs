using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebApiAspNetCore.Models;

namespace SampleWebApiAspNetCore.Entities
{
    public interface IPlayground
    {
        List<Playground> GetPlaygroundRecords();
    }
}
