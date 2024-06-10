using EntityFramework_CodeFirstMigrations_SQLServer_CRUD.Data;
using EntityFramework_CodeFirstMigrations_SQLServer_CRUD.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_CodeFirstMigrations_SQLServer_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly DataContext _Context;

        public MyController(DataContext dataContext)
        {
            _Context = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<MyEntity>>> GetAllInfo()
        {
            var myInfo = await _Context.MyEntities.ToListAsync();
            return Ok(myInfo);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<MyEntity>>> GetById(int id)
        {
            var myInfo = await _Context.MyEntities.FindAsync(id);
            if(myInfo is null)
            {
                return NotFound("There is no row");
            }
                
            return Ok(myInfo);
        }

        [HttpPost]
        public async Task<ActionResult<List<MyEntity>>> Post([FromBody]MyEntity myEntity)
        {
            _Context.MyEntities.Add(myEntity);
            await _Context.SaveChangesAsync();
            return Ok(await _Context.MyEntities.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<MyEntity>>> Put([FromBody] MyEntity myEntity)
        {

            var myInfo = await _Context.MyEntities.FindAsync(myEntity.Id);
            if (myInfo is null)
            {
                return NotFound("There is no row");
            }
            myInfo.Name = myEntity.Name;
            myInfo.LastName = myEntity.LastName;
            myInfo.FirstName = myEntity.FirstName;
            myInfo.Place = myEntity.Place;

            await _Context.SaveChangesAsync();
            return Ok(await _Context.MyEntities.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<MyEntity>>> Delete(int id)
        {

            var myInfo = await _Context.MyEntities.FindAsync(id);
            if (myInfo is null)
            {
                return NotFound("There is no row");
            }
            _Context.MyEntities.Remove(myInfo);

            await _Context.SaveChangesAsync();
            return Ok(await _Context.MyEntities.ToListAsync());
        }
    }
}


