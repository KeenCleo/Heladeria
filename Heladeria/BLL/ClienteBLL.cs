using Heladeria.DAL;
using Heladeria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Heladeria.BLL
{
    public class ClienteBLL
    {
        public DataTable MostrarClientes()
        {
            ClienteDAL clienteDAL = new ClienteDAL();

            return clienteDAL.MostrarCliente();
        }

        public void InsertarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                throw new Exception("El Nombre es obligatorio");
            }

            if (cliente.Nombre.Length < 3)
            {
                throw new Exception("El Nombre debe contener almenos 3 caracteres");
            }

            if ( string.IsNullOrWhiteSpace(cliente.Telefono) )
            {
                throw new Exception("El Teefono es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(cliente.Direccion))
            {
                throw new Exception("La direcion es obligatoria");
            }
            ClienteDAL clienteDAL = new ClienteDAL();

            clienteDAL.InsertarCliente(cliente);

        }

        public void EditarCliente(Cliente cliente)
        {

            ClienteDAL ClienteDAL=new ClienteDAL();
            ClienteDAL.EditarCliente(cliente);
        }

        public void EliminarCliente(int idcliente)
        {
            if (idcliente <= 0)
            {
               
                 throw new Exception("ID invalido");
                
            }

            ClienteDAL clienteDAL= new ClienteDAL();
            clienteDAL.EliminarCliente(idcliente);
        }

        public DataTable BuscarCLiente(string texto)
        {
            ClienteDAL clienteDAL = new ClienteDAL();

            if (string.IsNullOrWhiteSpace(texto))
            {
                throw new Exception("Debe escribir algo para buscar.");
            }

            if (texto.Length < 2)
            {
                throw new Exception("Escriba al menos 2 caracteres.");
            }

            return clienteDAL.BuscarCliente(texto);
            
        }

        public int TotalClientes()
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.TotalClientes();
        }
    }
}
