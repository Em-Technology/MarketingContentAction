using System;
using System.Runtime.CompilerServices;
using EmTech.ContentFileSystem;
using Microsoft.FSharp.Core;

[assembly: InternalsVisibleTo("EmtechActionsTests")]
namespace MarketingContent
{
    internal sealed class MarkdownContentRepository : IContentRepository
    {
        private static readonly Lazy<IContentRepository> ContentRepository = 
            new Lazy<IContentRepository>(() => new MarkdownContentRepository());
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