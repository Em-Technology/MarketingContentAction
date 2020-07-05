namespace MarketingContent
{
    public class ContentLoader
    {
        private readonly IContentRepository _contentRepository;
        
        internal ContentLoader(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public Content GetContent(ContentQuery contentRequest) => _contentRepository.GetNewPosts(contentRequest);
    }
}