using System.Collections.Generic;
using Azure;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface ITagService
    {
        Tag GetTagById(int tagId);
        List<Tag> GetAllTags();
        Tag GetTagByName(string name);
        void AddTag(Tag tag);
        void UpdateTag(Tag tag);
        void DeleteTag(int tagId);
    }
}