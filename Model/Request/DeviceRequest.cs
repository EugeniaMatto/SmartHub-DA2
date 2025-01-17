﻿namespace SmartHub.Model.Request;

public class DeviceRequest
{
    public required string Name { get; set; }
    public required string ModelNumber { get; set; }
    public required string Description { get; set; }
    public required List<string> Photos { get; set; }
}
