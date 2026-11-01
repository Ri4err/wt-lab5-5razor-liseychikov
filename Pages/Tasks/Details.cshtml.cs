using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liseychikov.Models;
using wt_lab5_5razor_liseychikov.Data;

namespace wt_lab5_5razor_liseychikov.Pages.Tasks;

public class EditModel : PageModel
{
    [BindProperty]
    public TaskModel Task { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var taskFromStore = TaskList.Tasks.FirstOrDefault(x => x.Id == id);

        if (taskFromStore == null)
        {
            return NotFound();
        }

        Task = taskFromStore;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var taskFromStore = TaskList.Tasks.FirstOrDefault(x => x.Id == Task.Id);
        if (taskFromStore == null)
        {
            return NotFound();
        }

        taskFromStore.Name = Task.Name;
        taskFromStore.Category = Task.Category;
        taskFromStore.Price = Task.Price;
        taskFromStore.IsAvaliable = Task.IsAvaliable;

        return RedirectToPage("Index");
    }
}