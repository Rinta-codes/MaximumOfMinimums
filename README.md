## Maximum Of Minimums  
  
Implementation of an algorithm from one of the tech tests I encountered while interviewing.  
  
In addition, contains a console app comparing bruteforce implementation speed with efficient solution, made to prove a point.  
And a basic MVC web app, just because.  
  
### Task  
For a given array of integers, find the maximum of minimums of all sequential subsets ("windows") of size n.   
  
### Example    
Array: \[1, 2, 2, 4, 3, 3\]  
Window size: 3  
Highlight of the windows of size 3 in the original array: \[**1, 2, 2**, 4, 3, 3\], \[1, **2, 2, 4**, 3, 3\], \[1, 2, **2, 4, 3**, 3\], \[1, 2, 2, **4, 3, 3**\]  
Windows of size 3: \[1, 2, 2\], \[2, 2, 4\], \[2, 4, 3\], \[4, 3, 3\]  
Minimums for these windows: 1, 2, 2, 3  
**Maximum of minimums (result): 3**  
  
### Resources    
Implementation based on the "Efficient solution" suggested [on this website](https://www.geeksforgeeks.org/find-the-maximum-of-minimums-for-every-window-size-in-a-given-array/).  
No code from the website was used - all code is written from scratch, based purely on text description of the solution, for the hell of it.  
  
  
