using System.ComponentModel.DataAnnotations;
namespace wt_lab5_5razor_liseychikov.Models;
public class TaskModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле Название обязательно для заполнения")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина названия должна быть от 3 до 100 символов")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Укажите категорию")]
    public string Category { get; set; } = string.Empty;

    [Range(0, 1000000, ErrorMessage = "Цена должна быть положительным числом")]
    public int Price { get; set; }

    public bool IsAvaliable { get; set; }
}