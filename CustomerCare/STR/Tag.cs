namespace CustomerCare.STR
{
    internal class Tag
    {
        public Tag(string tagName, string tagTitle)
        {
            TagName = tagName;
            TagTitle = tagTitle;
        }

        public string TagName { get; set; }
        public string TagTitle { get; set; }
    }
}