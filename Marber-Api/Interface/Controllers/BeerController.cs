using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Services;

namespace Interface.Controllers
{
    [Route("marber/BeerController")]
    [EnableCors("MyCors")]
    public class BeerController : ControllerBase
    {
        private readonly BeerService _beerService = new BeerService();
 
        [HttpGet("GetBeers")]
        public ActionResult<List<Beer>> GetBeers()
        {
            var response = _beerService.GetListBeer();
            return Ok(response);
        }

        //[HttpGet("GetBeerById/{id}")]
        //public ActionResult<Beer> GetBeerById(int id)
        //{
        //    var response = _beerService.GetBeerById(id);
        //    return Ok(response);
        //}

        //[HttpPost("AddBeer")]
        //public ActionResult<Beer> AddBeer([FromBody] Beer beer) 
        //{
        //    var response = _beerService.AddBeer(beer);
        //    return Ok(response);    
        //}

        //[HttpPut("ModifyBeerById/{id}")]
        //public ActionResult<List<Beer>> ModifyBeer(int id, [FromBody] Beer beer)
        //{
        //    var response = _beerService.ModifyBeer(id, beer);
        //    return Ok(response);
        //}

        //[HttpDelete("DeleteBeerById/{id}")]
        //public ActionResult<List<Beer>> DeleteBeerById(int id)
        //{
        //    var response = _beerService.DeleteBeerById(id);
        //    return Ok(response);
        //}
    }
}
