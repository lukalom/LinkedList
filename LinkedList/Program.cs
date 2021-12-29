using LinkedList;

DynamicList<int> nums = new DynamicList<int>();
nums.Add(15);
nums.Add(12);
nums.Add(300);

//nums.RemoveAt(0);
//nums.Remove(300);

//nums.Add(200);
//Console.WriteLine(nums.Count);
//Console.WriteLine(nums[0]);
//nums.PrintList();

Console.WriteLine(nums.Contains(15));
Console.WriteLine(nums.IndexOf(300));