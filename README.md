DSA Assignment Report – Death on Ypsilon 13

Part 1: Search Algorithm, Suspects Found, and Week 5 Data Structure

For Week 4, I chose Binary Search because the array of 800 employees was already sorted by their engine room entrance time using QuickSort in Week 3. Binary Search starts at the middle index and cuts the search area in half every loop. When my code found a match between 22:00 and 23:00 on August 9, 2234, it stepped left and right from that index to collect all employees in that time window. Through my search, I found four suspects: Jasper Wellington (ID 47), Alfred Pugsley (ID 192), Nem Wellington (ID 288), and Helena Blackwood (ID 764). Alfred Pugsley is the murderer because he is the only one who also exited the engine room during that same hour.

For Week 5, I chose a Binary Search Tree (BST) instead of a Hash Map because a BST keeps dates ordered and is easier to use for time range searches. I built the tree iteratively using current and lastParent pointers, and searched it using an in-order Depth-First Search (DFS) with a Stack. When I measured the speed with Stopwatch, Binary Search on the sorted array was much faster than DFS on the BST because Binary Search skips half the array every step, while DFS visits all 800 nodes in the tree.


Part 2: Challenges and How I Overcame Them

In Week 1, I understood the basics a little bit, but it was hard to know how to get started. What helped me a lot was recording the lectures on video and audio so I could watch and listen to them again at home until I understood more. In Week 2, I got a little bit of help from my classmates when I was at school, and after that I did almost everything myself and cleaned up the code to make it look better. Working with the JSON file was actually pretty okay for me since I had worked with JSON before, so I did not have many challenges there.

The hardest parts for me were SearchTask in Week 4 and the Binary Search Tree in Week 5. If someone asks me everything about how they work, I probably cannot answer every question because I did not understand much at first. In the end, after checking the lecture recordings again and testing the code step by step, I understood a part of how it works, even if I am still not 100% sure about everything.
