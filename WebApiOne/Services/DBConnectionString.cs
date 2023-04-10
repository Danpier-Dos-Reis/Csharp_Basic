using DAL;
namespace WebApiOne.Services
{
    public class DBConnectionString : IDBConnectionString
    {
        public string GetConnString(){
            string connstring = DALConnectionString.connstring;
            return connstring;
        }
    }
    public interface IDBConnectionString {
        string GetConnString();
    }
}
