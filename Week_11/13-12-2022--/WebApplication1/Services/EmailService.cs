﻿namespace WebApplication1.Services
{
    public class EmailService:IEmailService
    {
        public void Send(string to, string message, string topic)
        {
            Console.WriteLine($"{to}-{topic} {message}");
        }
    }
}
