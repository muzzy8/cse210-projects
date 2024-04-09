// Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

//Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("My Winter 2024 Project", "megbee40", 176);
        Video video2 = new Video("Simple Pie Crust", "Howto Bake", 322);
        Video video3 = new Video("Take Care Of Your Denim!", "John Doe", 590);

        video1.MakeComment("gg47", "It looks like you had no problem in this class lol");
        video1.MakeComment("hansbeth10", "Awesome work!");
        video1.MakeComment("redorangeyellow", "ily <3");

        video2.MakeComment("Yolandi Grouse", "when I try to roll it out it sticks");
        video2.MakeComment("Harper Hammond", "Can you do a video for a gluten free pie dough??");
        video2.MakeComment("thejoneshouse", "WOW your tip with the ice really worked for me! Thank you!");
        video2.MakeComment("cubik112", "Is it just me or does her teeth get whiter with each vid? Lol love your channel");

        video3.MakeComment("snorlax70", "2:10 he's trying hard not to laugh here");
        video3.MakeComment("Winifred Belle", "Thanks so much again, always great info");
        video3.MakeComment("Matt Herber", "You have my subscription");

        var videos = new List<Video>() {video1, video2, video3};

        foreach (Video video in videos)
        {
            Console.WriteLine("- - - - - - - - - - - - - - -\n");
            Console.WriteLine($"{video.GetTitle()} ({video.GetLengthSeconds()} seconds) by {video.GetAuthor()}\n  {video.CountComments()} comments:\n");
            video.DisplayComments();
        }
    }
}