using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Eval.Models;

namespace Eval.Controllers;

public class HomeController : Controller
{
    DateTime fecha= 2007/7/7;
    public iActionResult CrearAlumno()
    {
        Viewbag.Alumno.DNI
        foreach (int i in ViewBag.Alumnos.DNI)
        {
            if(viewbag.DNI[i]=ViewBag.Alumnos.DNI)
            {
                ViewBag.error="Error en el ingreso de datos";
                return View("CrearAlumno");
            }
        }
    } 
    public iActionResult EliminarAlumno(int IdAlumno)
    {
        Viewbag.Alumno.EliminarAlumno=BD.DeleteAlumnoById(IdAlumno);
        return("Alumnos");
    }
    public iActionResult VerDetalleAlumno()
    {
        Viewbag.VerDetalleAlumno=BD.GetAlumnoById
        return view();
    }
    public IActionResult Index()
    {
        ViewBag.Alumno= BD.GetAlumnos();
        Viewbag.AlumnoChico = Viewbag.Alumnos.FechaNacimientoAlumno;
        if (Viewbag.AlumnoChico<fecha)
        {
            fecha=ViewBag.AlumnoChico;
        }
        fecha=Viewbag.AlumnoChico;
        return View("VerDetalleAlumno");
    }
}