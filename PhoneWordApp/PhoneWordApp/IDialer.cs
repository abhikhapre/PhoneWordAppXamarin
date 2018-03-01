using System;
using System.Threading.Tasks;
namespace PhoneWordApp
{
    public interface IDialer
    {
        Task<bool> DialAsync(string number);
    }
}
