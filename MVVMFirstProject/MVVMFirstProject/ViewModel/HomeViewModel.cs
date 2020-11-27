using MVVMFirstProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMFirstProject.ViewModel
{
    class HomeViewModel
    {
        public MenuOptions ProcessMenuOption { get; set; } = new MenuOptions();
        public MenuOptions PaymentMenuOption { get; set; } = new MenuOptions();
        public MenuOptions ReportMenuOption { get; set; } = new MenuOptions();
        public MenuOptions TeacherTestMenuOption { get; set; } = new MenuOptions();
        public MenuOptions ProgramMenuOption { get; set; } = new MenuOptions();
        public MenuOptions OfertMenuOption { get; set; } = new MenuOptions();

        public HomeViewModel()
        {
            ProcessMenuOption.Title = "Procesos Académicos";
            ProcessMenuOption.Image = "Tareas.png";

            PaymentMenuOption.Title = "Pagos";
            PaymentMenuOption.Image = "Pagos.png";

            ReportMenuOption.Title = "Reportes";
            ReportMenuOption.Image = "Reportes.png";

            TeacherTestMenuOption.Title = "Evaluación Profesoral";
            TeacherTestMenuOption.Image = "Profesor.png";

            ProgramMenuOption.Title = "Programa de Asignaturas";
            ProgramMenuOption.Image = "Horario.png";

            OfertMenuOption.Title = "Oferta Académica";
            OfertMenuOption.Image = "Libros.png";
        }
    }
}
