using System.Data.SqlClient;
using APBD_tutorial_5.Models;

namespace APBD_tutorial_5.Repositories;

public class TempRepo : ITempRepo
{
    private IConfiguration _configuration;
    private static int counter;

    public TempRepo(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public int Create(Person person)
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "INSERT INTO Person(Id, FirstName, LastName) VALUES(@Id, @FirstName, @LastName)";
        cmd.Parameters.AddWithValue("@Id", person.Id);
        cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
        cmd.Parameters.AddWithValue("@LastName", person.LastName);
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;
    }
}