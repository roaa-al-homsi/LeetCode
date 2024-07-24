
#include <iostream>
#include <vector>
#include <algorithm>
#include <unordered_set>
#include <map>
#include <string>
using namespace std;


int lengthOfLongestSubstring(string s)
{
	int start = 0;
	int end = 0;
	int Max = 0;

	unordered_set<char> substring;

	while (end < s.length()) {


		if (substring.find(s[end]) == substring.end())
		{
			// not found

			substring.insert(s[end]);
			end++;
			Max = max(Max, end - start);  // Update Max inside the else block

		}
		else {
			substring.erase(s[start]);
			start++;
		}
	}

	return Max;

}

int main() 
{
	cout << lengthOfLongestSubstring("abcabcbb") ;

	

	return 0;
}






