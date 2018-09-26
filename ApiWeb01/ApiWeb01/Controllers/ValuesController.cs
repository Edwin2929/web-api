using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiWeb01.Models;
using Newtonsoft.Json;

namespace ApiWeb01.Controllers
{
    public class ValuesController : ApiController
    {
        Modelo db = new Modelo();

        //LISTAR GET api/values  
        public IEnumerable<Docentes> Get()
        {
           /* var lista = db.Docentes.ToList();
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                PreserveReferencesHandling = PreserveReferencesHandling.Arrays
            };
            string jsonString = JsonConvert.SerializeObject(lista, settings);

            return Request.CreateResponse(HttpStatusCode.OK, jsonString);*/

             return db.Docentes.ToArray();
            // return Json(new {nombre="Juan", apellido="Perez", Edad=21, habilidades=new {correr="si",hablar="no"}});
        }

        //BUSQUEDA GET api/values/5
        public Docentes Get(int id)
        {
            return db.Docentes.FirstOrDefault(e=>e.iddocente==id);
        }
       

        //INSERCION POST api/values
        public HttpResponseMessage Post([FromBody]Docentes value)
        {
            try
            {
                db.Docentes.Add(value);
                db.SaveChanges();
                return Request.CreateResponse();
            }
            catch (Exception e)
            {
                return Request.CreateResponse();
            }
               

        }

        //MOFIFICAR PUT api/values/5
        public HttpResponseMessage Put(int id, [FromBody]Docentes docente)
        {

            if (ModelState.IsValid) {
                db.Entry(docente).State = EntityState.Modified;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse(HttpStatusCode.NotModified);
            

        }

        //ELIMINAR DELETE api/values/5
        public void Delete(int id)
        {
            db.Docentes.Remove(db.Docentes.FirstOrDefault(e=>e.iddocente==id));
            db.SaveChanges();
        }
    }
}
