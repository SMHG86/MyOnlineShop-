using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface ISeoMetadataService
    {
        SeoMetadata GetSeoMetadataById(int seoMetadataId);
        SeoMetadata GetSeoMetadataByProductId(int productId);
        SeoMetadata GetSeoMetadataByCategoryId(int categoryId);
        void AddSeoMetadata(SeoMetadata seoMetadata);
        void UpdateSeoMetadata(SeoMetadata seoMetadata);
        void DeleteSeoMetadata(int seoMetadataId);
    }
}