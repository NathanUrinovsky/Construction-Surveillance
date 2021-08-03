# Supervision over illegal construction using object detection
My 12th grade project as a part of Software Engineering class, with focus on Deep Learning.\
In this README I will focus on the important parts of the project, and also on where to clone it, libraries and other files that need to be installed on your computer, etc.\
This software I built has two types of users: an engineer and a supervisor.\
An engineer can add an address that still doesn't exist in the system's database and detect buildings in the image of the new address or detect buildings in an image that was taken in an existing image and compare to the previous one. An engineer can also look at older images and send reports to their supervisor.\
A supervisor can mainly add new permits and access all the permits that are stored in the system's database.
## General review
### Engineer side
As previously mentioned, on the engineer's side one can mainly detect buildings of an image in a new address that they want to add, or in an address that already exists and compare to the previous image from the same address, alongside checking older images and sending reports to their supervisor.

![Screenshot (709)](https://user-images.githubusercontent.com/54028042/126899234-63ef5805-791a-4e03-827a-24f5447ff2af.png)
Here, we can see a new address that has been added, and an uploaded image with the detected buildings in it. The engineer can either save it, so that both the address and the image will be stored, or clear the entire page.

![Screenshot (710)](https://user-images.githubusercontent.com/54028042/126899527-876052ee-5bd7-4909-890e-d3a0b3c1315d.png)
Here, we wanted to detect buildings in a new image that was taken in an existing address, so we picked the address, got the most recent image of this address, and simply clicked on the button that activates the detection. Now, the engineer can compare the two images, and also have a look at the permits in the address they picked.

![Screenshot (632)](https://user-images.githubusercontent.com/54028042/127483018-f5df3cd7-45a9-4c9e-8757-189774cb8472.png)
Here, the engineer can sent a report to their supervisor (the supervisor can send back a message)

![Screenshot (635)](https://user-images.githubusercontent.com/54028042/127490139-69ef9a2b-aabb-4b2e-9fb6-f2e26364d06a.png)
Here, an engineer can simply pick an image and a date when an image was added to the system, and view it.
### Supervisor side
![Screenshot (646)](https://user-images.githubusercontent.com/54028042/127498144-e3094a60-87fe-4839-b056-abb7bdf1d465.png)
Here the supervisor has a dropdown with all of the addresses, and when he picks one he can see all the permits of the address he picked.

![Screenshot (645)](https://user-images.githubusercontent.com/54028042/127498355-21990448-1941-4022-a1c3-88e3ef02a186.png)

A supervisor can also activate or deactivate the account of an engineer who works under them.
![Screenshot (640)](https://user-images.githubusercontent.com/54028042/127507155-e111ca12-495d-40bd-9954-7d1d06b2a301.png)

And, of course, they can add a permit.
## Installations and more
When cloning this project, please make sure all of the project's folders are inside a folder called "Project". Make sure this folder is under drive C:/.\
Also, in order to perform the detection you need the trained model file, which you can download right [here](https://drive.google.com/file/d/15T92FcBdU5371rgYS91RdcfZB7mSAlUK/view?usp=sharing). The file should be in the python-server-files folder.\
If you'd like to train a model yourself, you can take the images I used for training mine from [here](https://www.kaggle.com/kbhartiya83/swimming-pool-and-car-detection)\
In case you don't have anaconda installed, please download [anaconda](https://www.anaconda.com/products/individual) (go all the way to the bottom of the page).\
When anaconda is installed and create a new enviroment with the CPU-only release of TensorFlow, recommended for beginners, as explained [here](https://docs.anaconda.com/anaconda/user-guide/tasks/tensorflow/), and then activate the environment as you'll be told in anaconda prompt.\
Finally, install all the pyton modules required for running the project properly, by using the command pip install name_of_the_module.\
The names of the required modules for running this project are numpy==1.19.5, matplotlib, opencv-python, os-sys, flask, werkzeug, uuid, keras_resnet.\
Note: the installation of keras_retinanet is a bit trickier.\
Install it as the following says:
1. [Click here](https://pypi.org/project/keras-retinanet/#files).
2. Download the folder itself.
3. Extract it.
4. Open it.
5. Copy the folder named "keras_retinanet"
6. Open the folder where anaconda is installed on your computer. Inside this folder to go envs\environment_name\Lib\site-packages
7. Paste the folder you copied
8. In the folder you copied, enter the folder called "utils", open the file anchors.py, and delete line number 20 (causes many troubles and prevents running the detection)
9. You are good to go!
