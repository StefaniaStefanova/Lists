
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string command = Console.ReadLine();
while(command!="end")
{
    string[] commandpart = command.Split(" ");
    string commandname = commandpart[0];
    command = Console.ReadLine();
    int element =int.Parse( commandpart[1]);
    if (commandname == "Delete")
    {
        numbers.RemoveAll(number => number == element);

    }
    else if(commandname=="Insert")
    {
        int position = int.Parse(commandpart[2]);
        numbers.Insert(position, element);
    }
}
Console.WriteLine(string.Join(" ", numbers));



