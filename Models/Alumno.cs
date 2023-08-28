using System;
namespace Eval.Models
{
    public class Alumno
    {
        public int IdAlumno {get; set;}
        public string NombreAlumno {get; set;}
        public int DNI {get; set;}
        public string FotoAlumno {get; set;}
        public int IdCurso {get; set;}
        public string NombreCurso{get; set;}
        public DateTime FechaNacimientoAlumno {get; set;}

        public Alumno(){

        }
        public Alumno(int IdA, int Dni, string Nom, string Fot, int IdC, string NomC, DateTime FNac)
        {
            IdAlumno = IdA; DNI = Dni; NombreAlumno = Nom; FotoAlumno = Fot;
            IdCurso = IdC; NombreCurso = NomC; FechaNacimientoAlumno = FNac;
        }
    }
}