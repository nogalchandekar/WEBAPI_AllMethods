using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WEB_API3.Models;

namespace WEB_API3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly NogalContext context;
        private string Gender;

        public PeopleController(NogalContext context)
        {
            this.context = context;
        }

        [Route("GetAllData")]
        [HttpGet]
        public ActionResult<IEnumerable<TblPerson>> GetAllData()
        {
            var res = (from s in context.TblPeople select s).ToList();
            return res;
        }


        [Route("Getdatabyroll_no")]
        [HttpGet]
         public IEnumerable<TblPerson> Getdatabyroll_no(int roll_no)
        {
            var result=from s in context.TblPeople where s.RollNo == roll_no select s;
            return result;
        }

        [Route("Getdatabygender")]
        [HttpGet]
        public IEnumerable<TblPerson> Getdatabygender(string gender)
        {
            var result = from s in context.TblPeople where s.Gender == gender select s;
            return result;
        }

        [Route("getLogin")]
        [HttpGet]
         public IEnumerable<TblPerson>getLogin(int roll_no,string gender)
        {
           var result=from s in context.TblPeople where s.RollNo==roll_no  && s.gender==gender select s;
            return result;
        }

        [Route("Insertdata")]
        [HttpPost]
        public ActionResult<TblPerson>Insertdata(TblPerson obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            else
            {
                context.Add(obj);
                context.SaveChanges();
                return CreatedAtAction("GetAllData", new { roll_no = obj.RollNo });
                
            }
        }

        [HttpGet]
        public TblPerson details(int roll_no)
        {
            TblPerson obj = new TblPerson();
            obj = context.TblPeople.Find(roll_no);
            return obj;
        }

        [HttpPost]
        public bool insertdata(TblPerson obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                context.Add(obj);
                context.SaveChanges();
                return true;
            }
        }


        [HttpPut]
        public bool update(TblPerson obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                context.Entry(obj).State = EntityState.Modified;
                context.SaveChanges();
                return true;

            }
        }

        [HttpDelete]
        public int delete(int roll_no)
        {
            if (roll_no == null)
            {
                return 0;
            }
            else
            {
                var result = context.TblPeople.Find(roll_no);
                context.Remove(result);
                context.SaveChanges();
                return 1;
            }
        }

    }
}
