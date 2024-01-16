using FirstProject.BL.Service;
using FirstProject.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        //[TypeFilter(typeof(TestResourceFilterAttribute))]
        [TypeFilter(typeof(TestActionFitlerAttribute))]

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_departmentService.GetByIdWithChilds(id));
        }
    }
}
