using System;
using Environment;

namespace Utils {
    public static class SortingUtils {
        public static void QuickSort(Employee[] inArray, int left, int right) {
            if(left < right) {
                int pivotIndex = Partition(inArray, left, right);

                QuickSort(inArray, left, pivotIndex - 1);
                QuickSort(inArray, pivotIndex + 1, right);
            }
        }

        private static int Partition(Employee[] inArray, int left, int right) {
            DateTime pivotValue = DateTime.Parse(inArray[right].lastEntranceInEngineRoom);
            int iIndex = left - 1;

            for(int jIndex = left; jIndex < right; jIndex++) {
                DateTime currentValue = DateTime.Parse(inArray[jIndex].lastEntranceInEngineRoom);

                if(currentValue <= pivotValue) {
                    iIndex++;

                    Employee temp = inArray[iIndex];
                    inArray[iIndex] = inArray[jIndex];
                    inArray[jIndex] = temp;
                }
            }

            Employee tempPivot = inArray[iIndex + 1];
            inArray[iIndex + 1] = inArray[right];
            inArray[right] = tempPivot;

            return iIndex + 1;
        }
    }
}
