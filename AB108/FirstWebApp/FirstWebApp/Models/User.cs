using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Models;

public partial class User
{
    [Key]
    public int Id { get; set; }

    [StringLength(64)]
    public string? Title { get; set; }

    [StringLength(256)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Deadline { get; set; }

    public bool IsDone { get; set; }
}
