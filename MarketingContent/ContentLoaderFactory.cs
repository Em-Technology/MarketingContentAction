using System;

namespace MarketingContent
{
    public class ContentLoaderFactory
    {
        public static ContentLoader AddContentLoader(ContentSource source) => source switch
        {
            ContentSource.Markdown => new ContentLoader(MarkdownContentRepository.Repository),
            _ => throw new InvalidOperationException($"There are no content loaders for the provided {source:G}")
        };
    }
}