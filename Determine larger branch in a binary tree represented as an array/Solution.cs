
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Challenge {
    public static string Solution(long[] arr) {
        // Type your solution here
        long leftsum = GetTreeSum(arr,1);
        long rightsum = GetTreeSum(arr,2);
        
        if(leftsum == rightsum) return "";
        else if(leftsum > rightsum) return "Left";
        else return "Right";
        
        
    }
    
    public static long GetTreeSum(long[]arr , int i){
        if(i >= arr.Length || arr[i] == -1) return 0;
        long sum = 0;
        int leftchild = (2*i) + 1;
        int rightchild = (2*i) + 2;
        if(i < arr.Length){
            sum = arr[i] + GetTreeSum(arr,leftchild) + GetTreeSum(arr,rightchild); 
        }
        
        return sum;
    }
}

