using DAL.Contracts;
using DAL.Tools;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ClienteRepository : IGenericRepository<Cliente>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Cliente] (IdCliente,FirstName,LastName,Adress) VALUES (@IdCliente,@FirstName,@LastName,@Adress)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Cliente] SET (IdCliente,FirstName,LastName,Adress) WHERE  = @";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Cliente] WHERE  = @";
        }

        private string SelectOneStatement
        {
            get => "SELECT , IdCliente,FirstName,LastName,Adress FROM [dbo].[Cliente] WHERE  = @";
        }

        private string SelectAllStatement
        {
            get => "SELECT , IdCliente,FirstName,LastName,Adress FROM [dbo].[Cliente]";
        }
        #endregion


        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cliente obj)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                new SqlParameter[] {
                    new SqlParameter("@IdCliente",new Guid()),
                    new SqlParameter("@FirstName",obj.FirstName),
                    new SqlParameter("@LastName",obj.LastName),
                    new SqlParameter("@adress",obj.Adress)
                });
        }

        public void Update(Guid id, Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
