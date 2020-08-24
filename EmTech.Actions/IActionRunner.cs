using System.Threading.Tasks;
using LanguageExt;

namespace EmTech.Actions
{
    public interface IActionRunner
    {
        public Task<Try<Unit>> Run();
    }
}