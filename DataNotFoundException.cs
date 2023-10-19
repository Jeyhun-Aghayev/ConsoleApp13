using System.Runtime.Serialization;

namespace ConsoleApp13
{
    [Serializable]
    internal class DataNotFoundException : Exception
    {
        public DataNotFoundException(string? message) : base(message)
        {
            
        }
    }
}