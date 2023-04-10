using Microsoft.AspNetCore.Mvc;
using WebApiOne.Data;

namespace WebApiOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaDBController:ControllerBase
    {
        private PruebaDBContext _dbcontext;

        public PruebaDBController(PruebaDBContext dBContext) {
            _dbcontext = dBContext;
        }

        [HttpGet("rutaget")] //rutaget
        public ActionResult GetUsers(){
            try {
                var listusers = _dbcontext.Usuarios.ToList();


                return listusers.Count == 0 ? StatusCode(404,"No se encontraron usuarios"):Ok(listusers);
            }
            catch(Exception e){
                //return StatusCode(500,"Ocurrió un error");
                return BadRequest(e.Message);
            }
        }
    }
}
