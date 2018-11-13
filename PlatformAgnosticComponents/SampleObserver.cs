using System;
using System.Security;

namespace PlatformAgnosticComponents
{
    public class SampleObserver : ISampleObserver
    {
        public void InvokeSomeApiCall()
        {
            Console.WriteLine("Hello From HandleSomeApiCall");
        }
    }
}
