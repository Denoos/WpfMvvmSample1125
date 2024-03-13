namespace WpfMvvmSample.Components.DTO
{
    public class Cpu
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Frequency { get; set; }
        public int Threads { get; set; }
    }
    public class Gpu
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string VideoMemory { get; set; }
        public int Frequency { get; set; }
    }
}
