using System;

namespace SoloLearn {
    
class Program {
    static void bubbleSort(int[] arr) {
        bool swapped;
        for(int i = 0; i < arr.Length - 1; i++) {
            swapped = false;
            for(int j = 0; j < arr.Length - i - 1; j++) {
                if(arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if(swapped == false)
                break;
        }
    }
    static void printArray(int[] arr) {
        for(int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
    }
    static void Main(string[] args) {
        int [] arr =  {5, 2, 42, 6, 1, 3, 2};
        bubbleSort(arr);
        printArray(arr);
    }
  }
}
