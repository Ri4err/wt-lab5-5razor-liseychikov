using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liseychikov.Models;
using wt_lab5_5razor_liseychikov.Data;

namespace wt_lab5_5razor_liseychikov.Pages.Tasks;

public class CreateModel : PageModel
{
    [BindProperty]
    public TaskModel Task { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        // Проверка валидации: если есть ошибки, возвращаем ту же страницу с формой
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Task.Id = TaskList.Tasks.Count > 0 ? TaskList.Tasks.Max(t => t.Id) + 1 : 1;
        TaskList.Tasks.Add(Task);

        return RedirectToPage("Index");
    }
}