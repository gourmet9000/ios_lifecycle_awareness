using System.Security.Cryptography.X509Certificates;
namespace PlatformAgnosticComponents
{
    public interface ISampleObserverDelegate
    {
        void InvokeSomeApiCall();
    }
}