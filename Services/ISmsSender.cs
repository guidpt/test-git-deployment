using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_git_deployment.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
