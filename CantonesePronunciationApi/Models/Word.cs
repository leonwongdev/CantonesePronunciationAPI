using System.Diagnostics.CodeAnalysis;

namespace CantonesePronunciationApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Word
{
    [Key]
    public int Id { get; set; }

    public int Page { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Text { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string? AlternativeWord { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(10)")]
    public string Jyutping { get; set; }
    
    [Column(TypeName = "nvarchar(5)")]
    public string? Consonant { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(5)")]
    public string Vowel { get; set; }

    public int Tone { get; set; }
}