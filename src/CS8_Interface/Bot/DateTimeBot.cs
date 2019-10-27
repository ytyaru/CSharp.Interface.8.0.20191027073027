using System;

namespace CS8_Interface
{
    public class DateTimeBot : IBot
    {
        public string Generate() => $"これは{DateTime.Now:yyyy-MM-dd HH:mm:ss}時点におけるtootです。";
    }
}
