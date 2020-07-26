using System;
using MarketingContent;
using NUnit.Framework;

namespace EmtechActionsUnitTests
{
  [TestFixture]
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
      
    }

    [Test]
    public void Test1()
    {
      MarkdownContentRepository.Repository.GetNewPosts(new ContentQuery());
    }
  }
}