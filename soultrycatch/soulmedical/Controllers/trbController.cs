// using Microsoft.AspNetCore.Mvc;

// using soulmedical.Services;
// using soulmedical.Models.bd;

// namespace soulmedical.Controllers;

// [Route("api/[controller]")]
// public class TrabajadorController: ControllerBase
// {
//   ITrabajadorService trabajadorService;

//   public TrabajadorController (ITrabajadorService service)
//   {
//     trabajadorService = service;
//   }

//   [HttpGet]
//   public IActionResult Get()
//   {
//     return Ok(trabajadorService.Get());
//   }

//   [HttpGet("{id}")]
//   public IActionResult Get(int id)
//   {
//     return Ok(trabajadorService.GetById(id));
//   }

//   [HttpPost]
//   public IActionResult Post([FromBody] Tbltrabajadore trabajador)
//   {
//     trabajadorService.Save(trabajador);
//     return Ok();
//   }

//   [HttpPut("{id}")]
//   public IActionResult Put(int id, [FromBody] Tbltrabajadore trabajador)
//   {
//     trabajadorService.Update(id, trabajador);
//     return Ok();
//   }

//     [HttpDelete("{id}")]
//     public IActionResult Delete (int id)
//     {
//       trabajadorService.Delete(id);
//       return Ok();
//     }
// }