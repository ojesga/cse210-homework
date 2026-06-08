using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        // Properties tracking video metadata
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }

        // Encapsulated list holding individual Comment objects
        private List<Comment> _comments;

        // Constructor
        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }

        // Method to add a comment object to this video's internal list
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        // Method returning the total number of comments left on the video
        public int GetCommentCount()
        {
            return _comments.Count;
        }

        // Method returning the entire list of comments for display iteration
        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}