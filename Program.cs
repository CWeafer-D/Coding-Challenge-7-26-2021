using System;

namespace Coding_Challenge_7_26_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[]{14, 12, 70, 15, 99, 65, 21, 90};
            findSub(test, 97, 0);
            findSub(test, 176, 0);
            findSub(test, 249, 0);
        }

        public static void findSub(int[] test, int target, int startIndex){
            bool sumFound = false;
            int endIndex = 0;
            int sum = 0;
            if(startIndex < test.Length){
                for(int i = startIndex; i < test.Length;i++){
                    sum += test[i];
                    if(sum == target)
                    {
                        endIndex = i;
                        sumFound = true;
                        break;
                    }
                    else if(sum > target){
                        break;
                    }
                    else{

                    }
                }
                if(sumFound == true)
                {
                    Console.WriteLine("Finding a sum for target value of " + target);
                    Console.WriteLine("Sum Found between Indexes: " + startIndex + " and " + endIndex);
                    Console.Write("Elements are ");
                    for(int i = startIndex; i <= endIndex; i++)
                    {
                        if(i == endIndex-1){
                            Console.Write(test[i] + " ");
                        }
                        else if(i < endIndex ){
                            Console.Write(test[i] + ", ");  
                        }
                        else if(i == endIndex){
                            Console.Write("and " + test[i] + "\n");
                        }
                    }
                    
                }
                else{
                        int inc = startIndex += 1;
                        findSub(test, target, inc);  
                }
            }
    
        }
    }
}
