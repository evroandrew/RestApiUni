using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;

namespace UniService.Controllers
{
    public class UniController : ApiController
    {
        [Route("api/getStudent")]
        public IEnumerable<tbStudent> Get()
        {
            using (TestDatabaseEntityEntities entities = new TestDatabaseEntityEntities())
            {
                return entities.tbStudents.ToList();
            }
        }

        [Route("api/getStudent/{id}")]
        public tbStudent Get(int id)
        {
            using (TestDatabaseEntityEntities entities = new TestDatabaseEntityEntities())
            {
                return entities.tbStudents.FirstOrDefault(e => e.Id == id);
            }
        }

        [Route("api/getSchedule/{idGropup}")]
        public IEnumerable<tbAudLect> GetS(int idGropup)
        {
            List<tbAudLect> list = new List<tbAudLect>();
            using (TestDatabaseEntityEntities entities = new TestDatabaseEntityEntities())
            {
                foreach (var temp in entities.tbAudLects)
                {
                    if (temp.GroupId == idGropup)
                        list.Add(temp);
                }
            }
            return list;
        }
    }
}
