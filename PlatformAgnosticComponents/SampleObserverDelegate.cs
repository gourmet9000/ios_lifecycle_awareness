using System;
using System.Security;

namespace PlatformAgnosticComponents
{
    public class SampleObserverDelegate : ISampleObserverDelegate
    {
        public void InvokeSomeApiCall()
        {
            Console.WriteLine("Hello From HandleSomeApiCall");
        }
    }
}
