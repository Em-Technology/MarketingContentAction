using System;
using Microsoft.FSharp.Core;
using EmTech.ContentFileSystem;
namespace EmTech.MarketingContent
{
    internal sealed class MarkdownContentRepository : IContentRepository
    {
        private static Lazy<IContentRepository> ContentRepository = new Lazy<IContentRepository>(() => new MarkdownContentRepository());
        public static IContentRepository Repository => ContentRepository.Value;

        private Unit GetCurrentDirectoryFiles() => FileManagement.logCurrentDirectory;
        private Unit GetCurrentEnv() => Env.printVariablesAndValues;
        public Content GetNewPosts(ContentQuery query)
        {
            GetCurrentEnv();
            GetCurrentDirectoryFiles();
            return new Content(); 
        }
    }
}