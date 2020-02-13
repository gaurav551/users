using System;
using System.ComponentModel.DataAnnotations;

namespace users.Models
{
    public class user_details
    {
    [Key]
    public int user_id { get; set; }
    public string username { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string gender {get;set;}
    public string password { get; set;}
    public bool status {get;set;}

    }
}