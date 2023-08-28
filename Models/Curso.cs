using System;
namespace Eval.Models
{
    public class Curso
    {
        public int IdCurso {get; set;}
        public string NombreCurso {get; set;}
        public string Especialidad {get; set;}
        public Curso(){
        }
        public Curso(int IdC, string Nom, string Esp)
        {
            IdCurso = IdC;
            NombreCurso = Nom;
            Especialidad = Esp;
        }
    }
}