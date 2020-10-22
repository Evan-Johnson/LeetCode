public class Solution {
    public int RomanToInt(string s) {
        List<int> num_arr = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            { 
                case 'I':
                    num_arr.Add(1);
                    break;
                case 'V':  
                    num_arr.Add(5);
                    break;
                case 'X':
                    num_arr.Add(10);
                    break;
                case 'L':
                    num_arr.Add(50);
                    break;
                case 'C':
                    num_arr.Add(100);
                    break;
                case 'D':
                    num_arr.Add(500);
                    break;
                case 'M':
                    num_arr.Add(1000);
                    break;
            }
        }
        
        int num = 0;
        
        for (int j = 1; j < s.Length; j++)
        {
            if (num_arr[j] > num_arr[j - 1])
            {
                num -= num_arr[j - 1];
            } else
            {
                num += num_arr[j - 1];
            }
        }
        
        num += num_arr[s.Length - 1];
        
        return num;
    }
}
