# Given a string s, find the length of the longest 
# substring
#  without repeating characters.

 

# Example 1:

# Input: s = "abcabcbb"
# Output: 3
# Explanation: The answer is "abc", with the length of 3.
# Example 2:

# Input: s = "bbbbb"
# Output: 1
# Explanation: The answer is "b", with the length of 1.
# Example 3:

# Input: s = "pwwkew"
# Output: 3
# Explanation: The answer is "wke", with the length of 3.
# Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 
 class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        Dict = {}
        count = 0
        high = 0
        startIndex = 0
        #iterate over each char
        for i, element in enumerate(s):
            currKey = ord(element)
            #if repeat within current substring
            if (currKey in Dict and Dict[currKey] >= startIndex):
                #sets new high
                if (count > high):
                    high = count
                #sets appropiate count
                count = i - Dict[currKey]
                startIndex = 1 + i - count
                Dict[currKey] = i
            else:
                Dict[currKey] = i
                count += 1
        if (count > high):
            high = count
        return high

