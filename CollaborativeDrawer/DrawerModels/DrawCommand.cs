using System.Collections.Generic;

namespace CollaborativeDrawer.DrawerModels
{
  public class DrawCommand
  {
    public int LineWidth { get; set; }

    public string Color { get; set; }

    public string Command { get; set; } // TODO: make this enum

    public List<Point> DrawPath { get; set; }

  }
}
