using CleanArchitectureApp.Core.ProjectAggregate;
using CleanArchitectureApp.SharedKernel;

namespace CleanArchitectureApp.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}