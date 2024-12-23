using System;
using System.Collections.Generic;

namespace portrait.Data;

public partial class Shape
{
    public Guid Id { get; set; }

    public int FormsTypeId { get; set; }

    public decimal PositionX { get; set; }

    public decimal PositionY { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? Text { get; set; }

    public int Order { get; set; }

    public virtual ShapeType FormsType { get; set; } = null!;
}
