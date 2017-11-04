using MatthewGollaherTools;
using System;
using System.ComponentModel.DataAnnotations;

namespace TaskTime.BusinessLogic
{
    public class Task : Base
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public DateTime? EmailReminderDate { get; set; }
        [Required]
        public DateTime? TextReminderDate { get; set; }
        [Required]
        public TaskStatus Status { get; set; }
    }

    public enum TaskStatus
    {
        InProgress = 1,
        Completed = 2
    }
}
