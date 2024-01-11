using BO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using SQLitePCL;

namespace TPDojo1.Models
{
    public class SamuraiVM
    {
        public Samurai Samurai { get; set; }
        public SelectList? WeaponsSelection { get; set; }
    }
}
