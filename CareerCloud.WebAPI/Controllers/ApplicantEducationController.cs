using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/applicant/v1")]
    [ApiController]
    public class ApplicantEducationController : ControllerBase
    {

        private readonly ApplicantEducationLogic _logicref;


        public ApplicantEducationController()
        {
            var repo = new EFGenericRepository<ApplicantEducationPoco>();
            _logicref = new ApplicantEducationLogic(repo);
        }

        [HttpGet]
        [Route("education/{applicanteducationid}")]
        public ActionResult GetApplicantEducation(Guid id)
        {
            ApplicantEducationPoco poco = _logicref.Get(id);
            if (poco != null)
            {
                return Ok(poco);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("education")]
        public ActionResult GetAllApplicantEducation()
        {
            var applicants = _logicref.GetAll();
            if (applicants != null)
            {
                return Ok(applicants);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("education")]
        public ActionResult PostApplicantEducation([FromBody] ApplicantEducationPoco[] poco)
        {
            _logicref.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("education")]
        public ActionResult PutApplicantEducation([FromBody] ApplicantEducationPoco[] poco)
        {
            _logicref.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("education")]
        public ActionResult DeleteApplicantEducation([FromBody] ApplicantEducationPoco[] poco)
        {
            _logicref.Delete(poco);
            return Ok();
        }


    }
}
