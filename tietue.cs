using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
public class tietue
{
    public int ID {get;set;}
    public string Nimi {get;set;}
    public DateTime PVM {get;set;}
}