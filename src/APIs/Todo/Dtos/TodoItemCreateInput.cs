using System.ComponentModel.DataAnnotations;
using MyService.Core.Enum;

namespace MyService.APIs.Dtos;

public class TodoItemCreateInput
{
    [Range(1, long.MaxValue)]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    public TodoItemStatus Status { get; set; }

    public long workspaceId { get; set; }

    public ICollection<AuthorDto>? Authors { get; set; }
}
