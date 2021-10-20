using System;

namespace Domain.Entities
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}