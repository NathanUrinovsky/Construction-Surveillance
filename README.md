# Supervision over illegal construction using object detection
My 12th grade project as a part of Software Engineering class, with focus on Deep Learning.\
In this README I will focus on the important parts of the project.\
This software I built has two types of users: an engineer and a supervisor.\
An engineer can add an address that still doesn't exist in the system's database and detect buildings in the image of the new address or detect buildings in an image that was taken in an existing image and compare to the previous one. An engineer can also look at older images and send reports to their supervisor.\
A supervisor can mainly add new permits and access all the permits that are stored in the system's database.
## General review
### Engineer side
As previously mentioned, on the engineer's side one can mainly detect buildings in an image in a new address that they add, or an address that alreayd exists, alongside checking older images and sending reports to their supervisor.

![Screenshot (709)](https://user-images.githubusercontent.com/54028042/126899234-63ef5805-791a-4e03-827a-24f5447ff2af.png)
Here, we can see a new address that has been added, and an uploaded image with the detected buildings in it. The engineer can either save it, so that both the address and the image will be stored, or clear the entire page.

![Screenshot (710)](https://user-images.githubusercontent.com/54028042/126899527-876052ee-5bd7-4909-890e-d3a0b3c1315d.png)
Here, wanted to analyze a new image that was taken in an existing address, so we picked the address, got the most recent image of this address
