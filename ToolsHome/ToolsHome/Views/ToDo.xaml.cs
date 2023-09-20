using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsHome.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDo : ContentPage
    {
        public IList<String> Tareas1 { get; set; }
        public IList<Tarea> Tareas3 { get; private set; }
        public IList<Tarea> Tareas4 { get; private set; }
        public ToDo()
        {
            InitializeComponent();

            Tareas1 = new List<String>();
            Tareas1.Add("Tarea 4");
            Tareas1.Add("Tarea 5");
            Tareas1.Add("Tarea 6");

            listal1.ItemsSource = Tareas1;

            Tareas3 = new List<Tarea>();

            Tareas3.Add(new Tarea
            {
                IDTarea = 1,
                Descripcion = "Tarea 7",
                FechaRegistro = DateTime.Now,
                Estado = "Pendiente"
            });
            Tareas3.Add(new Tarea
            {
                IDTarea = 1,
                Descripcion = "Tarea8",
                FechaRegistro = DateTime.Now,
                Estado = "Pendiente"
            });
            Tareas3.Add(new Tarea
            {
                IDTarea = 1,
                Descripcion = "Tarea9",
                FechaRegistro = DateTime.Now,
                Estado = "Hecho"
            });

            lista3.ItemsSource = Tareas3;

            Tareas4 = new List<Tarea>();

            Tareas4.Add(new Tarea
            {
                IDTarea = 1,
                Descripcion = "Tarea 10",
                FechaRegistro = DateTime.Now,
                Estado = "Pendiente"
            });
            Tareas4.Add(new Tarea
            {
                IDTarea = 1,
                Descripcion = "Tarea11",
                FechaRegistro = DateTime.Now,
                Estado = "Pendiente"
            });

            Tareas4.Add(new Tarea
            {
                IDTarea = 1,
                Descripcion = "Tarea12",
                FechaRegistro = DateTime.Now,
                Estado = "Hecho"
            });

            cvLista4.ItemsSource = Tareas4;
        }
    }
}