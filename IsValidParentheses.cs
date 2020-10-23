public class Solution {
    public bool IsValid(string s) {
        List<char> symbols = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                symbols.Add(s[i]);
            } else 
            {
                if (symbols.Count == 0)
                {
                    return false;
                }
                
                switch (s[i])
                {
                    case ')':
                        if (symbols[symbols.Count - 1] == '(')
                        {
                            symbols.RemoveAt(symbols.Count - 1);
                        } else 
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (symbols[symbols.Count -1] == '{')
                        {
                            symbols.RemoveAt(symbols.Count - 1);
                        } else 
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (symbols[symbols.Count - 1] == '[')
                        {
                            symbols.RemoveAt(symbols.Count - 1);
                        } else 
                        {
                            return false;
                        }
                        break;
                }
            }
        }
        
        if (symbols.Count > 0)
        {
            return false;
        } else 
        {
            return true;
        }
    }
}
