using System;

namespace Crab.NetCoreApi.Models
{
    public class RoadobjectObject
    {
        public string RoadobjectId { get; set; }
        public int RoadobjectType { get; set; }
        public decimal CenterX { get; set; }
        public decimal CenterY { get; set; }
        public decimal MinimumX { get; set; }
        public decimal MinimumY { get; set; }
        public decimal MaximumX { get; set; }
        public decimal MaximumY { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}