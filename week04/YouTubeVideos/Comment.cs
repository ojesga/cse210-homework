using System;

namespace YouTubeVideos
{
    public class Comment
    {
        // Auto-implemented properties to store comment details safely
        public string CommenterName { get; set; }
        public string CommentText { get; set; }

        // Constructor to easily instantiate a comment with data
        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }
    }
}