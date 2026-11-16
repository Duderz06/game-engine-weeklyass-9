Zach Cooke
100982545

Github - https://github.com/Duderz06/game-engine-weeklyass-9 
Release - https://github.com/Duderz06/game-engine-weeklyass-9/releases/tag/lab_assignment_2 

Building off of what was made for weekly assignment 9
https://docs.google.com/document/d/1WqMlXCUNe87xt-GMEah_1qKvsFvUtP6rfNSWP160CrQ/edit?tab=t.0 - what was submitted for that assignment if it helps


Title - Lots of Fish
Description - spawns a lot of fish that fly out due to collision

Before implementing update
<img width="2559" height="1517" alt="Screenshot 2026-11-16 145850" src="https://github.com/user-attachments/assets/46586a77-9cd7-452b-a7ec-96bba85b2340" />


What did you notice was impacting the performance of your project?
Massive lag spikes when spawning in all of the objects to be pooled on the first frame, otherwise it is fine. First few frames are all below the target framerate, which is 60 frames per second.

Which pattern(s) did you implement, and what behavior did they replace?
Implemented the factory, and it replaced the instantiate part of the object pooler. I did have a factory script already inside the project before this assignment but it was never used.


Do your patterns / technique implementations improve performance? Why or why not?
<img width="2559" height="1516" alt="Screenshot 2026-11-16 145949" src="https://github.com/user-attachments/assets/d5482304-a0d6-4023-9f45-180f079944c1" />

It did improve my performance, but it still is not perfect. What was originally a giant red block is now around half gray, which means it is now hitting the target framerate. 



Can you demonstrate what the profiling process revealed?
It showed me that factories are a lot better than just instantiating objects inside of other scripts. This test had me spawning 50 fish on the first frame, which is far more than what should normally be used in games, and it still sped it up by a pretty good amount. If i was only spawning in 1 or 2 things, it would most likely be a lot faster than using instantiate inside of other scripts



For testing i have included a button that switches between 2 scenes
One scene has the factory implemented
The other is instantiating it inside the object pooling script

It may not be the best for testing with the profiler as switching scenes does cause some lag, which does appear in the profiler. For better testing just enter play mode in the scene you want to test.
