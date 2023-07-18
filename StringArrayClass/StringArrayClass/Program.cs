

#region CLassWork

//static void StrToUpper(string str,int index)
//{
//    string firstChar = str[index].ToString().ToUpper();

//    char[] charArray = str.ToCharArray();

//    charArray[index] = Convert.ToChar(firstChar);

//    string result = string.Empty;

//    foreach (var item in charArray)
//    {
//        result += item;
//    }

//    Console.WriteLine(result);
//}

//StrToUpper("fidan",0);



//string name = "Fidan";

//Console.WriteLine(name.Contains("i"));

//Console.WriteLine(name.Equals("Fidan")) ;

//Console.WriteLine(name.IndexOf("a"));

//Console.WriteLine(name.EndsWith("n"));

//var result = name.Substring(1,2);

//Console.WriteLine(name.LastIndexOf("n"));

//Console.WriteLine(name.GetType());


//static bool Search(string str, string searchText)
//{
//    return str.Trim().ToLower().Contains(searchText.Trim().ToLower());
//}

//bool result = Search("Azerbaycan", "can");

//if (result)
//{
//    Console.WriteLine("Found");
//}

//else
//{
//    Console.WriteLine("Not Found");
//}



//int [] arr1 = new int[2];

//int [] arr2 = new int[2] { 1, 2 };

//int[] numbers = { 1, 2, 3, 4, 5, 6 };

//Array.Reverse(numbers);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(numbers.Length);

//Console.WriteLine(numbers.FirstOrDefault());

//Console.WriteLine(numbers.LastOrDefault());


//int[] numbers = { 1, 2, 3,55,32, 4, 5, 6 };

//Console.WriteLine(numbers.Any(m=>m==55));

//Console.WriteLine(numbers.Contains(5));

//Array.Sort(numbers);

//var data = numbers.OrderByDescending(x=>x).ToArray();

//foreach (var item in data)
//{

//    Console.WriteLine(item);
//}



//int[] nums = new int[3];

//nums[0] = 20;
//nums[1] = 30;
//nums[2] = 22;

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(nums.Rank);

//Console.WriteLine(nums.Count());



//static void Search(string searchText)
//{
//    string[] people = {"Kubra","Fidan","Samir","Ismayil" };

//    foreach (var item in people)
//    {
//        if (item.Trim().ToLower()==searchText.Trim().ToLower())
//        {
//            Console.WriteLine(item);
//            return;

//        }
//    }

//}

//Search("fidan");



//string name1 = "Ismayil";
//string surname1 = "Efendizade";
//int age1 = 29;

//string name2 = "Xeyyam";
//string surname2 = "Isgenderov";
//int age2 = 29;

//string name3 = "Cahangir";
//string surname3 = "Axundov";
//int age3 = 20;





//var stu1 = new
//{
//    name ="Ismayil",
//    surname="Efendizade",
//    age=29
//};




//var stu2 = new
//{
//    name = "Xeyyam",
//    surname = "Isgenderov",
//    age = 29
//};


//var stu3 = new
//{
//    name = "Cahangir",
//    surname = "Axundov",
//    age = 20
//};


//string result1 = $"{stu1.name} {stu1.surname} {stu1.age}";
//string result2 = $"{stu2.name} {stu2.surname} {stu2.age}";

//Console.WriteLine(result1);
//Console.WriteLine(stu2);
//Console.WriteLine(stu3);

//object[] studens = { stu1, stu2, stu3 };

//foreach (var item in studens)
//{
//    Console.WriteLine(item);
//}


using StringArrayClass;

Student stu1 = new Student();

stu1.name = "Ismayil";
stu1.surname = "Efendizade";
stu1.age = 29;
stu1.address = "Yasamal";


Student stu2 = new Student();

stu2.name = "Xeyyam";
stu2.surname = "Isgenderov";
stu2.age = 29;
stu2.address = "Yasamal";

Console.WriteLine(stu1.GetFullName());
Console.WriteLine(stu2.GetFullName());




//Console.WriteLine("Add name: ");

//string name = Console.ReadLine();

//Console.WriteLine("Add surname: ");

//string surname = Console.ReadLine();

//Console.WriteLine("Add age: ");

//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Add address: ");

//string address = Console.ReadLine();



//Student stu3 = new ()
//{
//    name=name,
//    surname=surname,
//    age=age,
//    address=address
//};



//Console.WriteLine(stu3.name+" "+stu3.surname);



//Console.WriteLine(stu1.name);



//Student[] students = { stu1, stu2, stu3 };

//foreach (var item in students)
//{
//    Console.WriteLine(item.name + " " + item.surname);
//}




//Book book1 = new()
//{
//    name="White Fang",
//    author="Jack Landon"
//};

//Console.WriteLine(book1.name +" "+ book1.author);

#endregion

