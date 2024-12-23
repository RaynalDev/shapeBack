using System;
using System.Collections.Generic;

namespace portrait.Data;

public partial class ShapeType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Shape> Shapes { get; set; } = new List<Shape>();
}
