# .NET-Developer-Assignment
.NET Developer Assignment by Armin Hardaus

I made a DB and Table with a querry (SQL folder -> SQLQuerry8.sql file).

To run this project open "VS CoreServices" folder, then open CoreServices.sln

In this exercise I did the following:

 1. CRUD Blog posts
 2. List of one or more posts
 3. JSON Objects returned by API
 4. Different Endpoints
 

I was using IDs instead of slugs, because I don't know how to implement them.
"tagList" is implemented, but not correctly. Due to my problem with arrays, I couldn't add multiple words.



Postman:

1. To show all posts:
   
     GET api/post/getposts
     
2. To show one post (using ID):

     GET api/post/getpost?postId=1
     
3. To add new post:
 
     POST api/post/addpost
     
4. To update a post:

     POST api/post/updatepost
     (then in a Body, you have to specify "PostId")
     
5. To delete a post:

     POST api/post/deletepost?postId=1
     

Endpoints are not the same as you wanted, but I did it on the other way.
     
  
