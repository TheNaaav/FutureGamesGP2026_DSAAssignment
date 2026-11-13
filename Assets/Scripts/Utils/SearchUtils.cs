using System;
using System.Collections.Generic;
using Environment;

namespace Utils {
    public static class SearchUtils {
        public static List<Employee> BinarySearchRange(Employee[] inArray, DateTime startTime, DateTime endTime) {
            List<Employee> matchingEmployees = new List<Employee>();
            int left = 0;
            int right = inArray.Length - 1;
            while(left <= right) {
                int middle = left + (right - left) / 2;
                DateTime middleTime = DateTime.Parse(inArray[middle].lastEntranceInEngineRoom);
                if(middleTime < startTime) {
                    left = middle + 1;
                }
                else if(middleTime > endTime) {
                    right = middle - 1;
                }
                else {
                   
                    int currentIndex = middle;
                    while(currentIndex >= 0 && DateTime.Parse(inArray[currentIndex].lastEntranceInEngineRoom) >= startTime) {
                        currentIndex--;
                    }
                    currentIndex++; // one step back to the first valid match
                    //forward (right side) and <= endTime
                    while(currentIndex < inArray.Length && DateTime.Parse(inArray[currentIndex].lastEntranceInEngineRoom) <= endTime) {
                        matchingEmployees.Add(inArray[currentIndex]);
                        currentIndex++;
                    }
                    break;
                }
            }
            return matchingEmployees;
        }
    }
}
