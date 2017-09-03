using MTVideos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MTVideos.Controllers.Api
{
    public class RentalController : ApiController
    {

        [HttpPost]
        public IHttpActionResult CreateNewRentals (NewRentalDto newRental)
        {
            throw new NotImplementedException();
        }

    }
}
