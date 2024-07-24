
#include <iostream>
#include <vector>
#include <algorithm>
#include <unordered_set>
#include <map>
#include <string>
using namespace std;

int GetTheSecondIndex(vector<int>& nums, int index1,int NumToCheck)
{
	int i = index1;

	for (int i= index1+1;  i< nums.size();i++)
	{
		if (nums[i] == NumToCheck)
			return i;
	}


}

vector<int> twoSum(vector<int>& nums, int target) 
{
	vector<int> vsorted = nums;
	sort(vsorted.begin(), vsorted.end());

	int Left = 0;
	int Right = nums.size() - 1;
	int Current = 0;
	int index1, index2 = 0;

	while (Left < Right) {
		Current = vsorted[Left] + vsorted[Right];



		if (Current == target) 
		{
		
			auto it1 = find(nums.begin(), nums.end(), vsorted[Left]);
			 index1 = it1 - nums.begin();
			//int index1=std::distance(nums.begin(), it1);

			if (vsorted[Left] == vsorted[Right])
			{
				index2 = GetTheSecondIndex(nums, index1, vsorted[Right]);
				return { index1, index2 };
			}
		
			auto it2 = find(nums.begin(), nums.end(), vsorted[Right]);
			 index2 = it2 - nums.begin();
			//int index2=std::distance(nums.begin(), it2);
			if (index1 != index2)
			{
				return { index1, index2 };
			}
			
		}
		else if (Current < target) {
			++Left;
		}
		else {
			--Right;
		}
	}

	return {}; 
}

int main() {

	vector<int>v = { 2,5,5,1 };


	v=twoSum(v, 10);

	cout << "[";
	for (int& i : v)
	{
		cout << i;
		if (i != v.back())
		{
			cout << ",";
		}
	}

	cout<< "]";

	return 0;
}






