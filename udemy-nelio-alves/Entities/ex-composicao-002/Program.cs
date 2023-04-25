using System;

// First post
DateTime moment = DateTime.Parse("21/06/2018 13:05:04");
string title = "Traveling to New Zealand";
string content = "I'm going to visit this wonderful country!";
int likes = 12;

Post post1 = new Post(moment, title, content, likes);

Comment c1 = new Comment("Have a nice trip!");
Comment c2 = new Comment("Wow, that's awesome!");
post1.AddComment(c1);
post1.AddComment(c2);

System.Console.WriteLine(post1);
System.Console.WriteLine();

// Second post
moment = DateTime.Parse("28/07/2018 23:14:19");
title = "Good night guys!";
content = "See you tomorrow!";
likes = 5;

Post post2 = new Post(moment, title, content, likes);

Comment c3 = new Comment("Good night!");
Comment c4 = new Comment("May the force be with you!");
post2.AddComment(c3);
post2.AddComment(c4);

System.Console.WriteLine(post2);