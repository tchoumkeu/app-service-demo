﻿namespace TodoApp.Web.Data;

public class TodoItem
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public bool Complete { get; set; }
}