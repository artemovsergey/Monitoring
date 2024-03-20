namespace Monitoring.API.Models;

public class User
{
    public int Id { get; set; }
    public string PersonCode { get; set; }
    public string PersonRole { get; set; }
    public int LastSecurityPointNumber { get; set; }
    public string LastSecurityPointDirection { get; set; }
    public DateTime LastSecurityPointTime {get; set;} = DateTime.Now;

}
