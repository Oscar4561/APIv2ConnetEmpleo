﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnetEmpleo.Aplication.Dtos.Response
{
   public class ExperienciaLaboralResponseDto
   {
      public int Id { get; set; }
      public string? Puesto { get; set; }

      public string? Establecimiento { get; set; }

      public int? AniosExperiencia { get; set; }

      public string? Descripcion { get; set; }

   }
}