using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Build a Basic Website with HTML and CSS", "Free Code Camp", 1800);
        video1.AddComment(new Comment("Sarah Smith", "This was so helpful! It was clear and concise."));
        video1.AddComment(new Comment("John Howard", "I'm still confused about the difference between HTML and CSS. Could you explain in simpler terms?"));
        video1.AddComment(new Comment("Destiny Cunningham", "Great video! I'm excited to implement what I learned in your video!"));
        video1.AddComment(new Comment("Abram Levinski", "This video helped me setup my first website. They portrayed the concepts in a simple way that was easy to replicate."));

        Video video2 = new Video("How to Knit a Scarf", "Yarn Theory", 1200);
        video2.AddComment(new Comment("Maria Martinez", "I've always wanted to learn how to knit. This video makes it seem doable!"));
        video2.AddComment(new Comment("Sam Browning", "I'm having trouble with the purl stitch. Could you demonstrate that again?"));
        video2.AddComment(new Comment("David Lee", "This is such a relaxing hobby. I can't wait to finish my first scarf."));

        Video video3 = new Video("How to Overcome Procrastination: Productivity Tips", "Time Managers", 900);
        video3.AddComment(new Comment("Michael Davis", "These tips are really helpful. I've been struggling with procrastination lately."));
        video3.AddComment(new Comment("Ashley Taylor", "I love the idea of creating a to-do list and breaking down tasks into smaller steps."));
        video3.AddComment(new Comment("Chou Lang", "I've already started implementing these techniques and they have helped me to stay focused!"));
        video3.AddComment(new Comment("Andrew Evans", "Thank you for the tips! I am going to share this with my daughter who struggles to keep up with her schoolwork due to procrastination."));

        Video video4 = new Video("How to Make Homemade Pizza", "Pizza Lover", 600);
        video4.AddComment(new Comment("Olivia Carter", "This looks so delicious! I can't wait to try making my own pizza at home."));
        video4.AddComment(new Comment("Ethan Miller", "I'm not a great cook, but this recipe seems pretty straightforward. I'll give it a shot."));
        video4.AddComment(new Comment("Sophia Wilson", "I love the idea of customizing my own pizza toppings. Endless possibilities!"));
    
        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine(video.DisplayAll());
        }
        
    }
}