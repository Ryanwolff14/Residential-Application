
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Residential_capstone_project
{
    public class TableController : ApiController
    {
        private Residential_capstone_project.MapModel db = new Residential_capstone_project.MapModel();

        public IQueryable<TableDTO> GetTables(int pageSize = 10
                )
        {
            var model = db.Tables.AsQueryable();
                        
            return model.Select(TableDTO.SELECT).Take(pageSize);
        }

        [ResponseType(typeof(TableDTO))]
        public async Task<IHttpActionResult> GetTable(int id)
        {
            var model = await db.Tables.Select(TableDTO.SELECT).FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        public async Task<IHttpActionResult> PutTable(int id, Table model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != model.Id)
            {
                return BadRequest();
            }

            db.Entry(model).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        [ResponseType(typeof(TableDTO))]
        public async Task<IHttpActionResult> PostTable(Table model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tables.Add(model);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TableExists(model.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            var ret = await db.Tables.Select(TableDTO.SELECT).FirstOrDefaultAsync(x => x.Id == model.Id);
            return CreatedAtRoute("DefaultApi", new { id = model.Id }, model);
        }

        [ResponseType(typeof(TableDTO))]
        public async Task<IHttpActionResult> DeleteTable(int id)
        {
            Table model = await db.Tables.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            db.Tables.Remove(model);
            await db.SaveChangesAsync();
            var ret = await db.Tables.Select(TableDTO.SELECT).FirstOrDefaultAsync(x => x.Id == model.Id);
            return Ok(ret);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TableExists(int id)
        {
            return db.Tables.Count(e => e.Id == id) > 0;
        }
    }
}