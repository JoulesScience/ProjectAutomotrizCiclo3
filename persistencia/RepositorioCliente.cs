using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioCliente: IRepositorioCliente
    {
        private readonly ApplicationContext _applicationContext;
        public RepositorioCliente(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }
        public RepositorioCliente(){

        }
        //implementado repositorio sirve para guardar datos en base de datos
        Cliente IRepositorioCliente.Add(Cliente cliente){
            var  new_cliente = _applicationContext.clientes.Add(cliente);
            _applicationContext.SaveChanges();
            return new_cliente.Entity;
        }
        //implementado repositorio Read, leer o buscar listas
        IEnumerable<Cliente> IRepositorioCliente.GetAll(){
            return _applicationContext.clientes;
        }
        //implementado repositorio  Read, Leer o buscar un persona por id
        Cliente IRepositorioCliente.Get(int idCliente){
            return  _applicationContext.clientes.FirstOrDefault(
                c => c.Id == idCliente);
        }
        //implementado repositorio Update, actulizar datos
        Cliente IRepositorioCliente.Update(Cliente cliente){
            var  cliente_encontrada = _applicationContext.clientes.FirstOrDefault(
                c => c.Id == cliente.Id);
            if(cliente_encontrada != null){
                //cliente_encontrada.Factura_id = cliente.Factura_id;
                cliente_encontrada.Identificaion_id = cliente.Identificaion_id;
                cliente_encontrada.placa_id  = cliente.placa_id;                
                }
            _applicationContext.SaveChanges();
            return cliente_encontrada;
        }    
        //implementado repositorio Delete 
        void IRepositorioCliente.Delete(int idCliente){
            var  cliente_encontrada = _applicationContext.clientes.FirstOrDefault(
                c => c.Id == idCliente);
            if(cliente_encontrada== null){
                return;
                }
            _applicationContext.Remove(cliente_encontrada);
            _applicationContext.SaveChanges();
        }   
       
    }
}