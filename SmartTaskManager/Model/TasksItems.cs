namespace SmartTaskManager.Model
{
    public class TasksItems
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public long UserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
