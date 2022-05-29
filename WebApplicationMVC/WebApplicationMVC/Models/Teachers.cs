using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models;

public class Teachers
{
    [Key]
    public int idteacher { get; set; }
    public string? Fullname { get; set; }
}
