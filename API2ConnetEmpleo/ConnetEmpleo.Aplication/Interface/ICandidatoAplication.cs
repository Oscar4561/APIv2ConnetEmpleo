﻿using ConnetEmpleo.Aplication.Commons.Base;
using ConnetEmpleo.Aplication.Dtos.Response;

namespace ConnetEmpleo.Aplication.Interface
{
   public interface ICandidatoAplication
   {

      Task<BaseResponse<CandidatoResponseDto>> GetCandidatoById(int id);
      Task<BaseResponse<IEnumerable<CandidatoResponseDto>>> GetAllCandidatos();
   }
}
