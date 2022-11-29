//using generics_intro;

//Mylist<string> isimler = new Mylist<string>();
//isimler.Add("Hasan");
//Console.WriteLine(isimler);


int[] num1 = new int[] {1,2,3,4}; 
int[] num2 = new int[] {10,20,30,40};

num1 = num2;
num2[0] = 100;

Console.WriteLine(num1[0]);