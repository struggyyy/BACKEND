using ApplicationCore.Interfaces.Repository;

namespace BACKEND;

public class User: IIdentity<int>
{
    public int Id { get; set; }
    
    public string Username { get; init; }
}