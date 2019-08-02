namespace Scheduler.Lib
{
    public class JobDetails
    {
        public bool Processed { get; set; }

        public bool Succeeded { get; set; }

        public string Arguments { get; set; }

        public string Status { get; set; }

        public string Message { get; set; }
    }
}
