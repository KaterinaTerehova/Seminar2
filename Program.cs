void HelloFunc(string name){
    Console.WriteLine($"Hello, {name}! How are you?");
}
Console.WriteLine("Hi, what is your name?");
string fio = Console.ReadLine();
HelloFunc(fio);
