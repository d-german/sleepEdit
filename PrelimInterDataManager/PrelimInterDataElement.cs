using System;
using System.Collections.Generic;
using System.Text;

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
        PrelimInterDataList(string path)
        {
            mPath = path;
        }
        private string mPath;
        private List<PrelimInterDataElement> mDataList = new List<PrelimInterDataElement>();
        public List<PrelimInterDataElement> DataList
        {
            get { return mDataList; }
        }

        private void load()
        {

        }

        private void save()
        {

        }
    }






}
