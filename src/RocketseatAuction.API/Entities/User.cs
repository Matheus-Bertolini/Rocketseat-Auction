namespace RocketseatAuction.API.Entities;

public class User
{
    public int id {  get; set; }
    public int Id { get; internal set; }
    public string name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

}
