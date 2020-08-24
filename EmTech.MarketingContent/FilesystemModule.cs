using System;
using System.Collections.Generic;
using System.IO;

namespace EmTech.MarketingContent
{
    public static class FilesystemModule
    {
        private static readonly Func<string, string, Func<string[]>> FileGetter = 
            (dir, filter) => () => Directory.GetFiles(dir, filter);
        private static Lazy<IEnumerable<string>> LazyFileNames(string dir, string filter) =>
            new Lazy<IEnumerable<string>>(FileGetter(dir, filter));
        public static Lazy<IEnumerable<string>> GetFileNames(string dir, string filter) => LazyFileNames(dir, filter);
    }
}