using System;
using Dominio;
using persistencia;

namespace aplicacion
{
    class Program
    {
        private static IRepositorioPersona _repo = new RepositorioPersona(new ApplicationContext());
        static void Main(string[] args)
        {
            //adicionarPersona();
            //eliminarPersona(3);
            //obtenerpersona(1); 
            obtenerpersonas();       
        } 
        private static void adicionarPersona(){
            Persona p= new Persona();
            p.Nombres="Omar";
            p.Apellidos="Contreras";
            p.Direccion="Tierra linda";
            p.Celular="319999991";
            _repo.Add(p);
        }
        private static void obtenerpersona(int idPersona){
            var p1=_repo.Get(idPersona);
            Console.WriteLine(p1.Nombres+" "+p1.Apellidos);
            Console.WriteLine(p1.Direccion);
            Console.WriteLine(p1.Celular);
            {
                
            }
            
        }
        private static void obtenerpersonas(){
          var persona_s= _repo.GetAll();
          foreach (var persona in persona_s)
          {
           Console.WriteLine("Nombre:" + persona.Nombres);
           Console.WriteLine("Apellidos:" + persona.Apellidos);
           Console.WriteLine("Direccion:" + persona.Direccion);
           Console.WriteLine("Celular:" + persona.Celular); 
           Console.WriteLine("..................");     
          }
          
        }      
        private static void eliminarPersona(int idPersona){
            _repo.Delete(idPersona);
        }
    }
}
