using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos= new List<Video>();

        Video _video= new Video("Best Anime", "Miuki", 240);
        Comment comment= new Comment("Georgi", "I agree! That's amazing");
        _video.ListComment(comment);
        Comment comment2= new Comment("MoreFree", "I cant believe Princess mononke didn't make your cut!");
        _video.ListComment(comment2);
        Comment comment3= new Comment("Aberdeen", "I'd flip the top two, but over all, ya.");
        _video.ListComment(comment3);
        videos.Add(_video);

        Video _video2= new Video("How to pet a cat", "Mao", 120);
        Comment aComment= new Comment("Bruno5", "Stunning.");
        _video2.ListComment(aComment);
        Comment aComment2= new Comment("KittyLover2", "I can't believe I went this long without knowing.");
        _video2.ListComment(aComment2);
        Comment aComment3= new Comment("Lulu", "I'd flip the top two, but over all, ya.");
        _video2.ListComment(aComment3);
        videos.Add(_video2);

        Video _video3= new Video("Coolest Vacation spots", "WorldTraveler", 600);
        Comment bComment= new Comment("Wanderlust", "Ohhhh. Yess. Hawaaii!!!");
        _video3.ListComment(bComment);
        Comment bComment2= new Comment("MoreFree", "Can't forget about Bali!!");
        _video3.ListComment(bComment2);
        Comment bComment3= new Comment("MoreLakes", "Cannot wait for my trip out to Alaska!");
        _video3.ListComment(bComment3);
        Comment bComment4= new Comment("WhatsThat", "You haven't even been to all of these.");
        _video3.ListComment(bComment4);
        videos.Add(_video3);

        
        foreach (Video video in videos){
            video.DisplayVideos();
        }
    }
}