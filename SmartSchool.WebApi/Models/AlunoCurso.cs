﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartSchool.WebApi.Models;

namespace SmartSchool.Models
{
    public class AlunoCurso
    {
        public AlunoCurso()
        {
        }

        public AlunoCurso(int alunoId, int cursoId)
        {
            AlunoId = alunoId;
            CursoId = cursoId;
        }

        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime DataFim { get; set; }
        public int? Nota { get; set; } = null;
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
