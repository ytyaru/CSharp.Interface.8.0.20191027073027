using System;

namespace CS8_Interface
{
    public class GreetingBot : IBot
    {
        public string Generate() => DateTime.Now.Hour switch 
        {
            int n when (3 < n && n < 10) => "おはようございます。",
            int n when (9 < n && n < 17) => "こんにちは。",
            int _ => "こんばんは。",
        };
    }
}
