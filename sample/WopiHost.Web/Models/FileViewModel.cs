﻿namespace WopiHost.Web.Models;

public class FileViewModel
{
    public required string FileId { get; set; }
    public required string FileName { get; set; }
    public bool SupportsView { get; set; }
    public bool SupportsEdit { get; set; }
    public required Uri IconUri { get; set; }
}
