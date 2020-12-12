using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProgramacion.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProgramacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Numerito : ControllerBase
    {
        public Numero operaciones(int numero)
        {
            string texto = "";
            

            if (numero < 0) { texto = "ERROR"; }
            if (numero == 0) { texto = "REALIZADO POR DANIEL ALEXANDER VASQUEZ CAZON"; }
            if (numero > 0) { texto = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg"; }
        
            Numero numeromodel = new Numero
            {
                numero = numero,
                mensaje = texto,
            };
         return numeromodel;
        }
        
    }
}
