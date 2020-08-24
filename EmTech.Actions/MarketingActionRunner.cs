using System.Threading.Tasks;
using EmTech.MarketingContent;
using LanguageExt;
using static LanguageExt.Prelude;

namespace EmTech.Actions
{
    public class MarketingActionRunner : IActionRunner
    {
        public async Task<Try<Unit>> Run()
        {
            await Task.Delay(5000);
            return Try(() =>
            {
                var loader = ContentLoaderFactory.AddContentLoader(ContentSource.Markdown);
                loader.GetContent(new ContentQuery());
                return new Unit();
            });
        }
    }
}