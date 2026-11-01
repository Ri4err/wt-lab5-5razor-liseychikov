using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liseychikov.Models;
using wt_lab5_5razor_liseychikov.Data;

namespace wt_lab5_5razor_liseychikov.Pages.Tasks;

public class IndexModel : PageModel
{
    public List<TaskModel> Tasks { get; set; } = new();

    public void OnGet()
    {
        Tasks = TaskList.Tasks;
    }
}