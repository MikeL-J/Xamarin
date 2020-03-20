using System;

namespace XamarinClient
{
    public class Client
    {
        public string GetGreeting(string name)
        {
            return string.IsNullOrEmpty(name) ? "Hello World" : $"Thanks, {name}";
        }
    }
}
