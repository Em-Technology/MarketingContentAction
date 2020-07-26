using MarketingContent;

namespace EmtechActions
{
    public class MarketingActionRunner : IActionRunner
    {
        public void Run()
        {
            var loader = ContentLoaderFactory.AddContentLoader(ContentSource.Markdown);
            loader.GetContent(new ContentQuery());
        }
    }
}