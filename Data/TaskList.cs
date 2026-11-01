using wt_lab5_5razor_liseychikov.Models;

namespace wt_lab5_5razor_liseychikov.Data;

public static class TaskList
{
    public static List<TaskModel> Tasks { get; set; } = new()
    {
        new TaskModel { Id = 1, Name = "Проектирование архитектуры", Category = "Архитектура", Price = 1500, IsAvaliable = true },
        new TaskModel { Id = 2, Name = "Разработка бэкенда", Category = "Разработка", Price = 3000, IsAvaliable = true },
        new TaskModel { Id = 3, Name = "Настройка базы данных", Category = "Базы данных", Price = 1200, IsAvaliable = true },
        new TaskModel { Id = 4, Name = "Интеграция API", Category = "Разработка", Price = 2000, IsAvaliable = false },
        new TaskModel { Id = 5, Name = "Тестирование и деплой", Category = "Тестирование", Price = 1800, IsAvaliable = true }
    };
}