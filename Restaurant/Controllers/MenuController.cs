using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Dto;
using Restaurant.Models;
using Restaurant.Reposistory;

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuInterface menuInterface;
        private readonly IMapper mapper;

        public MenuController(IMenuInterface menuInterface, IMapper mapper)
        {
            this.menuInterface = menuInterface;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            //Convert Domain to Dto
            var data = await menuInterface.GetAll();
            var dto = mapper.Map<List<MenuDto>>(data);
            return Ok(dto);

        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var data = await menuInterface.GetById(id);
            if (data == null)
            {
                return NotFound($"The Enter With id {id} not found");

            }

            var dto = mapper.Map<MenuDto>(data);
            return Ok(dto);



        }
        [HttpPost]
        public async Task<IActionResult> Create(AddMenudto menu)

        {
            if (ModelState.IsValid)
            {
                //convert dto to domain

                var data = mapper.Map<Menu>(menu);
                //getting data from database
                data = await menuInterface.Create(data);
                //convert domain to dto

                var dto = mapper.Map<MenuDto>(data);

                return Ok(dto);


            }
            else
            {
                return BadRequest(new Response
                {
                    StatusCode = 400,
                    Message = "Please Pass all the requried field and valid data"
                });
            }


        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(AddMenudto menu, int id)
        {
            var data = mapper.Map<Menu>(menu);

            data = await menuInterface.Update(id, data);

            if (data == null)
            {
                return NotFound($"The Enter With id {id} not found");


            }

            var dto = mapper.Map<MenuDto>(data);

            return Ok(dto);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var data = await menuInterface.Delete(id);
            if (data == null)
            {
                return NotFound($"The Enter With id {id} not found");

            }
            var dto = mapper.Map<MenuDto>(data);
            return Ok(dto);




        }
    }
}
