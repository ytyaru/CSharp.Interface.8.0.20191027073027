using System;

namespace CS8_Interface
{
    public class DefaultBot : IBot
    {
        public string Generate() => IBot.DefaultGenerate();
    }
}
