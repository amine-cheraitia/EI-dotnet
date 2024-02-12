
using EI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using EI.Data;

using System.Drawing.Drawing2D;

namespace EI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
       
        string filePath = @".\Data\utilisateurs.json";
        /*
        public RegionsController(NZDbContext dbContext)
        {
            this.dbContext = dbContext;
        }*/

        [HttpGet]
        public ActionResult<IEnumerable<Utilisateur>> GetAll()
        {
            var utilisateurs =  JsonConvert.DeserializeObject<List<Utilisateur>>(System.IO.File.ReadAllText(filePath));
            return Ok(utilisateurs);

        }




    }
}


