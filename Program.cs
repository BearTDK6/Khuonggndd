// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Khuongg!");

string firstFriend = "                                                   Maria ";
string secondFriend = " Sage                                                               ";
firstFriend = firstFriend.Trim();
secondFriend = secondFriend.Trim();
Console.WriteLine("Ban Tao La " + firstFriend + " va " + secondFriend);
string friends = $"My friends are {firstFriend.Trim()} and {secondFriend.Trim()}";
Console.WriteLine(friends.ToUpper());
long a = 10000000000;
long b = 10000000000;
long c = (long)a + (long)b;
Console.WriteLine(c);
var numbers = new List<int> { 1,6,2,4,8,123,53 };

numbers.Sort();
foreach (var number in numbers)
{
  Console.WriteLine($"Hello {number}");
}


