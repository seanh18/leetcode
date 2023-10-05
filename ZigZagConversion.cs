// # The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

// # P   A   H   N
// # A P L S I I G
// # Y   I   R
// # And then read line by line: "PAHNAPLSIIGYIR"

// # Write the code that will take a string and make this conversion given a number of rows:

// # string convert(string s, int numRows);
 

// # Example 1:

// # Input: s = "PAYPALISHIRING", numRows = 3
// # Output: "PAHNAPLSIIGYIR"
// # Example 2:

// # Input: s = "PAYPALISHIRING", numRows = 4
// # Output: "PINALSIGYAHRPI"
// # Explanation:
// # P     I    N
// # A   L S  I G
// # Y A   H R
// # P     I
// # Example 3:

// # Input: s = "A", numRows = 1
// # Output: "A"

public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) {
            return s;
        }
        List<string> strings = new List<string>();
        for (int i = 0; i < numRows; ++i) {
            strings.Add("");
        }

        int index = 0;
        int diff = 1;
        for (int i = 0; i < s.Length; ++i) {
            strings[index] += s[i];
            if (diff == 1 && index == numRows - 1) {
                //top -> reverse
                diff = -1;
            } else if (diff == -1 && index == 0) {
                //bottom -> reverse
                diff = 1;
            }
            index += diff;
        }
        string returnVal = "";
        for (int i = 0; i < numRows; ++i) {
            returnVal += strings[i];
        }

        return returnVal;
    }
}