#include <iostream>
#include <vector>
#include <algorithm>
#include <unordered_set>
#include <map>
#include <string>

using namespace std;

//bool containsDuplicate(vector<int>& nums)
//{
//
//	unordered_set<int>v;
//	int i = 0;
//	int j = nums.size();
//
//	while (i < j)
//	{
//		if (v.find(nums[i]) == v.end())
//		{
//			//not found 
//			v.insert(nums[i]);
//			i++;
//		}
//		else
//			return true;
//	}
//	return false;
//
//}

bool containsDuplicate(vector<int>& nums)
{
	unordered_set<int> seen;
	for (int num : nums) 
	{
		if (seen.count(num) > 0)
			return true;
		seen.insert(num);
	}
	return false;
	
}

int main() 
{
	vector<int>v = { 1,1,1,3,3,4,3,2,4,2 };
	cout<<containsDuplicate(v);
	

	return 0;
}






