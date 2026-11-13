DSA Assignment Report – Death on Ypsilon 13

Part 1: Search Algorithm, Suspects Found, and Week 5 Data Structure

For Week 4, I used Binary Search because the array of 800 employees was already sorted by their engine room entrance time using QuickSort in Week 3. Binary Search starts at the middle index and cuts the search area in half every loop. When a match was found between 22:00 and 23:00 on August 9, 2234, it stepped left and right from that index to collect all employees in that time window. Through my search, I found four suspects: Jasper Wellington (ID 47), Alfred Pugsley (ID 192), Nem Wellington (ID 288), and Helena Blackwood (ID 764). 
My search found four suspects who entered at 22:13:17:
- Jasper Wellington (ID: 47, Last Exit: 2234-08-04T07:14:06)
- Alfred Pugsley (ID: 192, Last Exit: 2234-08-09T22:14:54)
- Nem Wellington (ID: 288, Last Exit: 2234-08-02T09:16:49)
- Helena Blackwood (ID: 764, Last Exit: 2234-08-03T09:43:27)

Alfred Pugsley is the murderer because he is the only person who both entered and exited the engine room between 22:00 and 23:00 on the night of the murder. Alfred Pugsley is the murderer because he is the only one who also exited the engine room during that same hour.

For Week 5, I used a Binary Search Tree BST keeps dates in order (smaller to the left, larger to the right) and I understood the BST example from the lectures better. I built the tree using current and lastParent in the Insert method, and searched it using Depth-First Search (DFS) with a Stack. When I measured the time with Stopwatch, Binary Search on the array was much faster than DFS on the BST. This is because Binary Search cuts the array in half every step and only checks around 10 employees, while DFS checks all 800 nodes in the tree.


Part 2: Challenges and How I Overcame Them

In Week 1, I understood the basics a little bit, but it was hard to know how to get started. What helped me a lot was recording the lectures on video and audio so I could watch and listen to them again at home until I understood more. In Week 2, I got a little bit of help from my classmates when I was at school, and after that I did almost everything myself and cleaned up the code to make it look better. Working with the JSON file was actually pretty okay for me since I had worked with JSON before, so I did not have many challenges there.

The hardest parts for me were SearchTask in Week 4 and the Binary Search Tree in Week 5. If someone asks me everything about how they work, I probably cannot answer every question because I did not understand much at first. In the end, after checking the lecture recordings again and testing the code step by step, I understood a part of how it works, even if I am still not 100% sure about everything.
