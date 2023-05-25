using System;

public class video
{
    public string _title;
    public string _author;
    public int _length;
    public List<comment> Comments;

    public int GetNumberOfComments()
    {
        return Comments.Count; 
    }
}