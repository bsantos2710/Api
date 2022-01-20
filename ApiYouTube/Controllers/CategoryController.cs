using ApiYouTube.Models;
using ApiYouTube.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiYouTube.Controllers
{
    [ApiController]
    [Route("v1/categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context)
        {
            var categories = await context.Categorys.ToListAsync();
            return categories;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Category>> Post(
            [FromServices] DataContext context,
            [FromBody] Category model)
        {
            if (ModelState.IsValid)
            {
                context.Categorys.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
