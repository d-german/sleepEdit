using System.Collections.Generic;

namespace PrelimInterDataManager
{
    public struct Tag
    {
        public readonly string Name;
        public readonly string Value;

        public Tag(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }


    public struct PrelimInterDataElement
    {
        public PrelimInterDataElement(List<Tag> tags, string result)
        {
            Tags = new List<Tag>(tags);
            Result = result;
        }

        public readonly List<Tag> Tags;
        public string Result;
    }

    public class PrelimInterDataList
    {
        private string mPath;

        private PrelimInterDataList(string path)
        {
            mPath = path;
        }

        public List<PrelimInterDataElement> DataList { get; } = new List<PrelimInterDataElement>();

        private void load()
        {
        }

        private void save()
        {
        }
    }
}