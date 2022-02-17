using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudUsingReact.Models;

namespace CrudUsingReact.Controllers
{
    [RoutePrefix("Api/Student")]
    public class studentController : ApiController
    {
        CrudDemoEntities DB = new CrudDemoEntities();
        
        [Route("AddotrUpdatestudent")]
        [HttpPost]
        public object AddotrUpdatestudent(Student st)
        {
            try
            {
                if (st.Id == 0)
                {
                    studentmaster sm = new studentmaster();
                    sm.Name = st.Name;
                    sm.RollNo = st.Rollno;
                    sm.Address = st.Address;
                    sm.Class = st.Class;
                    DB.studentmaster.Add(sm);
                    DB.SaveChanges();
                    return new Response
                    {
                        Status = "Success",
                        Message = "Data Successfully"
                    };
                }
                else
                {
                    var obj = DB.studentmaster.Where(x => x.Id == st.Id).ToList().FirstOrDefault();
                    if (obj.Id > 0)
                    {

                        obj.Name = st.Name;
                        obj.RollNo = st.Rollno;
                        obj.Address = st.Address;
                        obj.Class = st.Class;
                        DB.SaveChanges();
                        return new Response
                        {
                            Status = "Updated",
                            Message = "Updated Successfully"
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return new Response
            {
                Status = "Error",
                Message = "Data not insert"
            };

        }
        [Route("Studentdetails")]
        [HttpGet]
        public object Studentdetails()
        {

            var a = DB.studentmaster.ToList();
            return a;
        }

        [Route("StudentdetailById")]
        [HttpGet]
        public object StudentdetailById(int id)
        {
            var obj = DB.studentmaster.Where(x => x.Id == id).ToList().FirstOrDefault();
            return obj;
        }
        [Route("Deletestudent")]
        [HttpDelete]
        public object Deletestudent(int id)
        {
            var obj = DB.studentmaster.Where(x => x.Id == id).ToList().FirstOrDefault();
            DB.studentmaster.Remove(obj);
            DB.SaveChanges();
            return new Response
            {
                Status = "Delete",
                Message = "Delete Successfuly"
            };
        }
    }
}