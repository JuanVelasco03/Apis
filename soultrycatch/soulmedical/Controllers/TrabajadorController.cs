using Microsoft.AspNetCore.Mvc;

using soulmedical.Models.bd;
using Microsoft.EntityFrameworkCore;

namespace soulmedical.Controllers;

[Route("api/[controller]")]
public class TrabajadorController: ControllerBase
{
  public readonly SoulMedicalContext _dbcontext;

  public TrabajadorController(SoulMedicalContext _context) 
  {
    _dbcontext = _context;
  }

  [HttpGet]
  public IActionResult Get() {
    List<Tbltrabajadore> lista = new List<Tbltrabajadore>();
      try
      {
        lista = _dbcontext.Tbltrabajadores.Include(c => c.Tblusuarios).ToList();

        return StatusCode(StatusCodes.Status200OK, new {mensaje = "ok", response = lista});
      }
      catch (Exception ex){
        return StatusCode(StatusCodes.Status200OK, new {mensaje = ex.Message, response = lista});
      }
  }

  [HttpGet("{id}")]
  public IActionResult GetById(int id){
   Tbltrabajadore worker  = _dbcontext.Tbltrabajadores.Find(id);

   if(worker == null){
    return BadRequest("Trabajador no encontrado");
   }
      try
      {
        worker = _dbcontext.Tbltrabajadores.Include(c => c.Tblusuarios).Where(p => p.TraDocumento == id).FirstOrDefault();

        return StatusCode(StatusCodes.Status200OK, new {mensaje = "ok", response = worker});
      }
      catch (Exception ex){
        return StatusCode(StatusCodes.Status200OK, new {mensaje = ex.Message, response = worker});
      }
  }

  [HttpPost]
  public IActionResult Post([FromBody] Tbltrabajadore trabajador)
  {
    try{
      _dbcontext.Tbltrabajadores.Add(trabajador);

      _dbcontext.SaveChanges();

      return StatusCode(StatusCodes.Status200OK, new {mensaje = "ok"});

    }catch (Exception ex){

      return StatusCode(StatusCodes.Status200OK, new {mensaje = ex.Message});
    }
  }

  
  [HttpPut]
  public IActionResult Put([FromBody] Tbltrabajadore objeto)
  {
    Tbltrabajadore oTrabajador = _dbcontext.Tbltrabajadores.Find(objeto.TraDocumento);

    if(oTrabajador == null){
      return BadRequest("Trabajador no encontrado");
    }

    try{
      oTrabajador.TraNombre = objeto.TraNombre is null ? oTrabajador.TraNombre : objeto.TraNombre;
      oTrabajador.TraApellido = objeto.TraApellido is null ? oTrabajador.TraApellido : objeto.TraApellido;
      oTrabajador.TraDireccion = objeto.TraDireccion is null ? oTrabajador.TraDireccion : objeto.TraDireccion;
      oTrabajador.TraCelular = objeto.TraCelular is null ? oTrabajador.TraCelular : objeto.TraCelular;
      oTrabajador.TraEmail = objeto.TraEmail is null ? oTrabajador.TraEmail : objeto.TraEmail;
      oTrabajador.TraFechaNacimiento = objeto.TraFechaNacimiento;
      oTrabajador.TraCodigocuenta = objeto.TraCodigocuenta is null ? oTrabajador.TraCodigocuenta : objeto.TraCodigocuenta;
      oTrabajador.TraEdad = objeto.TraEdad;


      _dbcontext.Tbltrabajadores.Update(oTrabajador);
      _dbcontext.SaveChanges();

      return StatusCode(StatusCodes.Status200OK, new {mensaje = "ok"});

    }catch (Exception ex){

      return StatusCode(StatusCodes.Status200OK, new {mensaje = ex.Message});
    }
  }
}

      // worker.TraNombre = trabajador.TraNombre is null ? worker.TraNombre : trabajador.TraNombre;
      // worker.TraApellido = trabajador.TraApellido is null ? worker.TraApellido : trabajador.TraApellido;
      // worker.TraDireccion = trabajador.TraDireccion is null ? worker.TraDireccion : trabajador.TraDireccion;
      // worker.TraCelular = trabajador.TraCelular is null ? worker.TraCelular : trabajador.TraCelular;
      // worker.TraEmail = trabajador.TraEmail is null ? worker.TraEmail : trabajador.TraEmail;
      // worker.TraFechaNacimiento = trabajador.TraFechaNacimiento;
      // worker.TraCodigocuenta = trabajador.TraCodigocuenta is null ? worker.TraCodigocuenta : trabajador.TraCodigocuenta;
      // worker.TraEdad = trabajador.TraEdad;