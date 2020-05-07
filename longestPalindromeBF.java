//This is my brute force method of finding the longest palindrome in a substring s.

class Solution {
    public String longestPalindrome(String s) {
        String longest = "";
       
        for(int j = 0; j < s.length(); j++){
            String maybe = "";
            maybe += s.charAt(j);
            if(maybe.length() > longest.length())
                longest = maybe;
            for(int i = j+1; i < s.length(); i++)
            {
                maybe = maybe + s.charAt(i);
                if(isPalindrome(maybe))
                {
                    if(maybe.length() > longest.length())
                    {
                        longest = maybe;
                    }
                }
            }
        }
        return longest;
    }
    
    public boolean isPalindrome(String s)
    {
        String reverse = "";
        int i = s.length()-1;
        //int j = 0;
        do
        {
            reverse += s.charAt(i);
            i--;
        }while(i > -1);
            
        if(reverse.equals(s))
        {
            return true;
        }else{
            return false;
        }
    }
}
