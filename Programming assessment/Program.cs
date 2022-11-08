//-----TASK 1-----

List<int> Listofnums = new List<int>() //creates new list Containing 89, 42, 65 etc
{
    89, 42, 65, 18, 73, 15, 6, 89, 71, 17, 11, 51, 55, 91
};

//Sort
bool swapActive = true;//used in the while loop
while (swapActive)//while Swap active is true
{
    swapActive = false;
    int temp = 0;//used in if statment
    for (int i = 0; i < Listofnums.Count; i++)//loops through the items in the list
    {
        for (int j = i + 1; j < Listofnums.Count; j++)
        {
            if (Listofnums[i] > Listofnums[j])//checks whether the first value is higher than the second
            {
                temp = Listofnums[i];//Stores value 1 in a temporary value
                Listofnums[i] = Listofnums[j];//changes the first value to the second
                Listofnums[j] = temp;//changes second value to the temporary value
                swapActive = true;//notifies the code that a swap has occured
            }
        }
    }
}

//count
Console.WriteLine(Listofnums.Count);//displays length of the list

//mean
int value = 0;
int count = 0;
for (int i = 0;i < Listofnums.Count; i++)//adds all the values together using the value variable
{
    value = Listofnums[i] + value;
    count++;
}

Console.WriteLine(value/count);//works out and displays the mean

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

Console.WriteLine(CommonKey);

//median
int len = Listofnums.Count();//works out the length of the list
int median = len % 2;//works out which index will be the median value
Console.WriteLine(Listofnums[median]);//displays the median of the list



//-----TASK 2-----

Queue<string> position = new Queue<string>();//creates queue
position.Enqueue("One");//adds queue values
position.Enqueue("Two");
position.Enqueue("Three");
position.Enqueue("Four");
position.Enqueue("Five");
Console.WriteLine(position);

position.Enqueue("Six");//adds six to the end of the queue
Console.WriteLine(position);

position.Dequeue();//Removes one from the queue
Console.WriteLine(position);

Console.WriteLine(position.Count);


//-----TASK 3-----

