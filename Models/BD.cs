using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Eval.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=.; DataBase=BDEscuelas;Trusted_Connection=true;";
        public static List<Alumno> GetAlumnos()
        {
            List<Alumno> Lista = null;
            string SQL = "SELECT * FROM Alumnos"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Alumno>(SQL).ToList(); 
            } 
            return Lista;
        }
        public static Alumno GetAlumnoById(int Id)
        {
            Alumno item = null;
            string SQL = "SELECT * FROM Alumnos A INNER JOIN Cursos C ON C.IdCurso=A.IdCurso"; 
            SQL +=" WHERE IdAlumno=@pId"; 

            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                item = db.QueryFirstOrDefault<Alumno>(SQL, new { pId = Id }); 
            } 
            return item;
        }
        public static bool GetAlumnoByDNI(int Dni)
        {
            Alumno item = null;
            string SQL = "SELECT * FROM Alumnos WHERE DNI=@pDni"; 

            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                item = db.QueryFirstOrDefault<Alumno>(SQL, new { pDni = Dni }); 
            } 
            return (item != null);
        }

        public static void DeleteAlumnoById(int Id)
        {
            string SQL = "DELETE FROM Alumnos WHERE IdAlumno=@pId"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new { pId = Id }); 
            } 
        }
        public static List<Curso> GetCursos()
        {
            List<Curso> Lista = null;
            string SQL = "SELECT * FROM Cursos"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Curso>(SQL).ToList(); 
            } 
            return Lista;
        }
        public static void InsertAlumno(Alumno item)
        {
            string SQL = "INSERT INTO Alumnos(NombreAlumno, DNI, FotoAlumno, FechaNacimientoAlumno, IdCurso)";
            SQL += " VALUES (@pNombreAlumno, @pDNI, @pFotoAlumno, @pFechaNacimientoAlumno, @pIdCurso) "; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new {
                    pNombreAlumno = item.NombreAlumno,
                    pDNI = item.DNI,
                    pFotoAlumno = item.FotoAlumno,
                    pFechaNacimientoAlumno = item.FechaNacimientoAlumno,
                    pIdCurso = item.IdCurso
                }); 
            }   
        }
    }
}