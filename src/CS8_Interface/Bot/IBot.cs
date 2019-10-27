using System;

namespace CS8_Interface
{
    public interface IBot
    {
        public string Generate();
        protected static string DefaultGenerate() => "デフォルトのtootです。";
    }
}
