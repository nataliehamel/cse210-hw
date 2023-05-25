using System;

class Program
{
    static void Main(string[] args)
    {
        List<video> videos = new List<video>();

        video v1 = new video
        {
            _title = "How to Make Cookies",
            _author = "Ryan Smith",
            _length = 150,
            Comments = new List<comment>
            {
                new comment {_name = "Sam", _text = "This video is great!"},
                new comment {_name = "Lilly", _text = "👍🤩✨💕😁"},
                new comment {_name = "Winston", _text = "I've seen better videos."}
            }
        };
        videos.Add(v1);

        video v2 = new video
        {
            _title = "Bike Safety",
            _author = "Tim Walters",
            _length = 180,
            Comments = new List<comment>
            {
                new comment {_name = "Meg", _text = "Great tips!!"},
                new comment {_name = "Bayli", _text = "👍"},
                new comment {_name = "Beau", _text = "Thanks for making this video 💯"},
                new comment {_name = "Craig", _text = "Make a part 2."}
            }
        };
        videos.Add(v2);

        video v3 = new video
        {
            _title = "Easy Crafts for Kids",
            _author = "Becky Miller",
            _length = 550,
            Comments = new List<comment>
            {
                new comment {_name = "Bonnie", _text = "These are great!!"},
                new comment {_name = "Susan", _text = "My grandkids loved these :)"},
                new comment {_name = "Camri", _text = "Awesome crafts, my kids were busy all day😊💕"},
                new comment {_name = "Nora", _text = "Please make more of these!!"}
            }
        };
        videos.Add(v3);

        video v4 = new video
        {
            _title = "Marathon Training VLOG",
            _author = "Cody Cruz",
            _length = 1500,
            Comments = new List<comment>
            {
                new comment {_name = "Andy", _text = "I love these VLOGS 🏃‍♂️💯"},
                new comment {_name = "Trevor", _text = "You inspired me, I just signed up for my first marathon 💪"},
                new comment {_name = "June", _text = "Truly motivating! I just started my fitness journey thanks to you."}
            }
        };
        videos.Add(v4);

        foreach (video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length (seconds): " + video._length);
            Console.WriteLine("Comments: ");

            foreach (comment comment in video.Comments)
            {
                Console.WriteLine(comment._name + "-" + comment._text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
