using System.Transactions;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _commentText = text;
    }

    //Name
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public void SetCommenterName(string name)
    {
        _commenterName = name;
    }


    //Text
    public string GetCommentText()
    {
        return _commentText;
    }
    public void SetCommentText(string text)
    {
        _commentText = text;
    }
}