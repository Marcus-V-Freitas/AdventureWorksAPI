using System;

namespace Domain.Entities
{
    public class Shift
    {
        public int? ShiftID { get; private set; }
        public string Name { get; private set; }
        public DateTime? StartTime { get; private set; }
        public DateTime? EndTime { get; private set; }
    }
}