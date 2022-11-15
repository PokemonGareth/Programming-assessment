//-----TASK 1-----
static void PrintList(List<int> list, string Title)//a mathod to print lists
{
    Console.WriteLine($"{ Title }");
    foreach (int i in list)
    {
        Console.WriteLine($"{ i }");
    }
}

static List<int> BubbleSort(List<int> nums)//Bubble sort
{
    bool swapActive = false;
    int temp = 0;
    for (int i = 0; i <= nums.Count; i++)
    {
        for (int j = i + 1; j <= nums.Count;)
        {
            if (nums[j] > nums[i])
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                swapActive = true;
            }
        }
    }
    while (swapActive) ;
    return nums;
};

List<int> Listofnums = new List<int>() //creates new list Containing 89, 42, 65 etc
{
    89, 42, 65, 18, 73, 15, 6, 89, 71, 17, 11, 51, 55, 91
};

PrintList(Listofnums, "Original List:");//calls function to display list

List<int> sorted = BubbleSort(Listofnums);//calls function to sort list

PrintList(sorted, "Sorted List:");//calls function to display the sorted list

//count
Console.WriteLine($"Count: { Listofnums.Count }");//displays length of the list

//mean
int value = 0;
int count = 0;
for (int i = 0;i < Listofnums.Count; i++)//adds all the values together using the value variable
{
    value = Listofnums[i] + value;
    count++;
}

Console.WriteLine($"Mean: { value/count }");//works out and displays the mean

//mode
Dictionary<int, int> Mode = new Dictionary<int, int>();//creates new dictionary
for (int i = 0; i < Listofnums.Count; i++)//loops through all of the list
{
    if (!Mode.ContainsKey(Listofnums[i])) { //works ou whether the number is in the dictionary already
        Mode.Add(Listofnums[i], 0);//if it is NOT, then it will add as a new item into the dictionary
    }
    else
    {
        Mode[Listofnums[i]]++;//if it IS in the dictionary, then it will increment the value of the dictionary item
    }
}

var CommonKey = Mode.OrderByDescending(x => x.Value).First().Key;//orders the dictionary so the highest valued item is at the top. it then gets the key from the first item in the dictionary

Console.WriteLine($"Mode: { CommonKey }");

//median
int len = Listofnums.Count();//works out the length of the list
int median = len % 2;//works out which index will be the median value
Console.WriteLine($"Median: { Listofnums[median] }");//displays the median of the list


//-----TASK 2-----
/*
Queue<string> position = new Queue<string>();//creates queue
position.Enqueue("One");//adds queue values
position.Enqueue("Two");
position.Enqueue("Three");
position.Enqueue("Four");
position.Enqueue("Five");

foreach (string i in position)//prints queue
{
    Console.WriteLine($"{ i }");
};
Console.WriteLine("----------------------");


position.Enqueue("Six");//adds six to the end of the queue
foreach (string i in position)
{
    Console.WriteLine($"{ i }");
};

Console.WriteLine("----------------------");

position.Dequeue();//Removes one from the queue
foreach (string i in position)
{
    Console.WriteLine($"{ i }");
};

Console.WriteLine("----------------------");

Console.WriteLine(position.Count);
*/

//-----TASK 3-----
/*
List<int> A = new List<int>()
{
    19, 3, 2, 1, 7, 4, 7, 4, 10, 9, 10, 1, 3, 19
};

bool swapActive2 = true;//used in the while loop
while (swapActive2)//while Swap active is true
{
    swapActive2 = false;
    int temp2 = 0;//used in if statment
    for (int i = 0; i < A.Count; i++)//loops through the items in the list
    {
        for (int j = i + 1; j < A.Count; j++)
        {
            if (A[i] > A[j])//checks whether the first value is higher than the second
            {
                temp2 = A[i];//Stores value 1 in a temporary value
                A[i] = A[j];//changes the first value to the second
                A[j] = temp2;//changes second value to the temporary value
                swapActive2 = true;//notifies the code that a swap has occured
            }
        }
    }
}

Dictionary<int, int> AlmostX = new Dictionary<int, int>();//creates new dictionary

for (int i = 0; i < A.Count; i++)//loops through all of the list
{
    if (!AlmostX.ContainsKey(A[i]))
    { //works ou whether the number is in the dictionary already
        AlmostX.Add(A[i], 0);//if it is NOT, then it will add as a new item into the dictionary
    }
    else
    {
        AlmostX[A[i]]++;//if it IS in the dictionary, then it will increment the value of the dictionary item
    }
}

List<int> X = new List<int>();

foreach(var item in AlmostX.Keys)//goes through all the keys in the dictionary
{
    X.Add(item);//adds the key to the "X" List
}

foreach (var item in X)//Prints the final list
{
    Console.WriteLine($"{ X }");
}
*/

//-----TASK 4-----

