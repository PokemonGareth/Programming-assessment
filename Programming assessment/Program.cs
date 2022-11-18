//-----TASK 1-----
//Solution1 = With Predefined Functions
/*
static void PrintList(List<int> list, string Title)//a mathod to print lists
{
    Console.WriteLine($"{ Title }");
    foreach (int i in list)
    {
        Console.WriteLine($"{ i }");
    }
}

List<int> Listofnums = new List<int>() //creates new list Containing 89, 42, 65 etc
{
    89, 42, 65, 18, 73, 15, 6, 89, 71, 17, 11, 51, 55, 91
};

PrintList(Listofnums, "Original List:");//calls function to display list

Listofnums.Sort();//calls function to sort list

PrintList(Listofnums, "Sorted List:");//calls function to display the sorted list

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
*/

//Solution 2 = Without Predefined Functions
/*
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
    bool swapActive = true;
    int temp = 0;
    while (swapActive)
    {
        swapActive = false;
        for (int i = 0; i <= nums.Count - 2; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                temp = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = temp;
                swapActive = true;
            }
        }
    }

    return nums;
};

static Dictionary<int, int> OrderDictionary(Dictionary<int, int> Dictionary)
{
    List<int> keys = new List<int>();
    List<int> values = new List<int>();
    foreach (int key in Dictionary.Keys)//gathers the dictionary keys into a list
    {
        keys.Add(key);
    }
    foreach (int Value in Dictionary.Values)//gathers the dictionary keys into a list
    {
        values.Add(Value);
    }

    bool swapActive = true;
    int keytemp = 0;
    int valuetemp = 0;

    while (swapActive)
    {
        swapActive=false;
        for (int i = 0; i <= Dictionary.Count - 2; i++)//organizes Both the list , using the value, making sure the key and value from the dictionary chare the same index
        {
            if (values[i] > values[i + 1])
            {
                keytemp = keys[i];
                valuetemp = values[i];

                keys[i] = keys[i + 1];
                values[i] = values[i + 1];

                keys[i + 1] = keytemp;
                values[i + 1] = valuetemp;

                swapActive = true;
            }
        }
    }

    Dictionary<int, int> SortedDict = new Dictionary<int, int>();//copies value using the keys from sorted list 
    for (int j = 0; j <= values.Count - 1; j++)
    {
        int CorrectKey = keys[j];
        int CorrectValue = values[j];
        SortedDict.Add(CorrectKey, CorrectValue);
    }

    return SortedDict;

}

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
for (int i = 0; i < Listofnums.Count; i++)//adds all the values together using the value variable
{
    value = Listofnums[i] + value;
    count++;
}

Console.WriteLine($"Mean: { value / count }");//works out and displays the mean

//mode
Dictionary<int, int> Mode = new Dictionary<int, int>();//creates new dictionary
for (int i = 0; i < Listofnums.Count; i++)//loops through all of the list
{
    if (!Mode.ContainsKey(Listofnums[i]))
    { //works ou whether the number is in the dictionary already
        Mode.Add(Listofnums[i], 0);//if it is NOT, then it will add as a new item into the dictionary
    }
    else
    {
        Mode[Listofnums[i]]++;//if it IS in the dictionary, then it will increment the value of the dictionary item
    }
}

Dictionary<int,int> SortedDict = OrderDictionary(Mode);//orders the dictionary so the highest valued item is at the top. it then gets the key from the first item in the dictionary

var CommonKey = SortedDict.Last().Key;//gets first element from the dictionary

Console.WriteLine($"Mode: { CommonKey }");

//median
int len = Listofnums.Count();//works out the length of the list
int median = len % 2;//works out which index will be the median value
Console.WriteLine($"Median: { Listofnums[median] }");//displays the median of the list
*/
//-----TASK 2-----

// Solution 1 = With Predefined functions
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

//Solution 2 = Without Predefined functions
/*
static void PrintQueue(string title, List<string> Queue)
{
    Console.WriteLine(title);
    foreach (string i in Queue)//prints queue
    {
        Console.WriteLine($"{ i }");
    };

    Console.WriteLine("----------------------");
}

static List<string> AddQueue(List<string> Queue, string Item)
{
    Queue.Insert(Queue.Count, Item);

    return Queue;
}

static List<string> RemoveQueue(List<string> Queue)
{
    Queue.Remove(Queue[0]);


    return Queue;
}

List<string> Queue = new List<string>()
{
    "One", "Two", "Three", "Four", "Five"
};

int QueueLength = Queue.Count;
PrintQueue("Origional Queue:", Queue);

Queue = AddQueue(Queue, "Six");//adds six to the end of the queue
PrintQueue("Added 6:", Queue);

Queue = RemoveQueue(Queue);//Removes one from the queue
PrintQueue("Removed 1:", Queue);

Console.WriteLine($"Count: { Queue.Count }");
*/

//-----TASK 3-----
//Solution 1 = With Predefinied Functions
/*
List<int> A = new List<int>()
{
    19, 3, 2, 1, 7, 4, 7, 4, 10, 9, 10, 1, 3, 19
};

A.Sort();

List<int> X = A.Distinct().ToList();//Distinct Generates a table that then uses the table to eliminate any duplicates storing
                                                          //the non duplicates within a column called results

foreach (var item in X)//Prints the final list
{
    Console.WriteLine($"{item}");
}
*/

//Solution 2 = Without Predefinied Functions
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
//Solution 1 = With Predefined Functions
List<int> Checklist = new List<int>();

for (int i = 0; i < 26; i++)
{
    Checklist.Add(0);
}

List<char> Alphabet = new List<char>()
{
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
};

Console.WriteLine("Please enter a Pangram: ");
string UserInput = Console.ReadLine().ToLower();

bool AllInAlphabet = false;
foreach (char i in Alphabet)
{
    if (UserInput.Contains(i))
    {
        AllInAlphabet = true;
    }
    else
    {
        AllInAlphabet = false;
        break;
    }
}

if (AllInAlphabet == true)
{
    Console.WriteLine($"'{UserInput}' is a pangram.");
}
else
{
    Console.WriteLine($"'{UserInput}' is not a pangram. :)");
}

//Solution 2 = Without Predefined Functions
/*
List<int> Checklist = new List<int>();

for (int i = 0; i < 26; i++)
{
    Checklist.Add(0);
}

List<char> Alphabet = new List<char>()
{
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
};

Console.WriteLine("Please enter a Pangram: ");
string UserInput = Console.ReadLine().ToLower();

foreach (char c in UserInput)
{
    if (c == ' ')
    {
        UserInput.Remove(c);
    }
}

int loopcount = 0;
foreach (char i in UserInput)
{
    bool nextletter = false;
    while (nextletter == false)
    {
        foreach (char c in Alphabet)
         {
            if (c == i)
            {
                Checklist[loopcount] = Checklist[loopcount] + 1;
                loopcount++;
                nextletter = true;
                break;
            }
        }
    }
    nextletter = false;
}

bool swapActive = true;
int temp = 0;
while (swapActive)
{
    swapActive = false;
    for (int i = 0; i <=Checklist.Count - 2; i++)
    {
        if (Checklist[i] > Checklist[i + 1])
        {
            temp = Checklist[i];
            Checklist[i] = Checklist[i + 1];
            Checklist[i + 1] = temp;
            swapActive = true;
        }
    }
}

if (Checklist[0] == 0)
{
    Console.WriteLine($"'{UserInput}' is not a pangram.");
}
else
{
    Console.WriteLine($"'{UserInput}' is a pangram. :)");
}
*/