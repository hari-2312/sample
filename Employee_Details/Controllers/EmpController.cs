using Employee_Details.Data;
using Employee_Details.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Details.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {

        protected readonly AppDbcontext _appDbcontext;

        public EmpController([FromBody]AppDbcontext appDbcontext)
        {
            _appDbcontext = appDbcontext;
        }

        
        [HttpPost]
        public ActionResult create([FromBody]Emp_master emp)
        {
            _appDbcontext.Employee_Register.Add(emp);
            _appDbcontext.SaveChanges();
            return Ok();
        }


        [HttpGet]
        public ActionResult Get()
        {
         var a=_appDbcontext.Employee_Register.ToList();
            return Ok(a);
        }


        [HttpPatch]
        public ActionResult update([FromBody] Emp_master emp)
        {
           var a1= _appDbcontext.Employee_Register.Update(emp); 
            _appDbcontext.SaveChanges();
            return Ok(a1);


        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var a2 = _appDbcontext.Employee_Register.FirstOrDefault(x=>x.Emp_no == id);
            _appDbcontext.Employee_Register.Remove(a2);
            _appDbcontext.SaveChanges();
            return Ok();
        }
    }
}
